using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerForm : Form
    {
        SqlExecuter sqlExecuter = new SqlExecuter();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var dt = sqlExecuter.GetAvailableCustomerType();

            Dictionary<string, int> type = new Dictionary<string, int>();

            foreach (DataRow dr in dt.Rows)
            {
                type.Add(dr["TenLoaiKhach"].ToString(), Convert.ToInt32(dr["MaLoaiKhach"]));
            }

            this.cbCustomerType.DataSource = new BindingSource(type, null);
            this.cbCustomerType.DisplayMember = "Key";
            this.cbCustomerType.ValueMember = "Value";


            switch (this.Tag)
            {
                case "AddForm":
                    {
                        this.lbCustomerHeader.Text = this.Text = "THÊM THÔNG TIN KHÁCH";
                        break;
                    }

                case "EditForm":
                    {
                        MainForm mainForm = (MainForm)Owner;
                        var customer = mainForm.GetSelectedCustomer();

                        this.lbCustomerHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
                        this.tbCustomerName.Text = customer.CustomerName;
                        this.tbCustomerPassport.Text = customer.CustomerPassportID;
                        this.cbCustomerType.Text = CustomerTypeBUS.GetCustomerTypeByID(customer.CustomerTypeID);
                        this.rtbCustomerAddress.Text = customer.CustomerAddress;
                        break;
                    }
            }
            this.lbCustomerHeader.Left = (this.ClientSize.Width - lbCustomerHeader.Size.Width) / 2 + 32;
            this.imgCustomer.Left = this.lbCustomerHeader.Left - 45;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void CbCustomerType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string[] data = { tbCustomerName.Text, tbCustomerPassport.Text, cbCustomerType.Text, rtbCustomerAddress.Text };

            if (data.Any(d => string.IsNullOrWhiteSpace(d)))
            {
                MessageBox.Show("Các thông tin không được để trống!", "THÊM THẤT BẠI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainForm mainForm = (MainForm)Owner;
                var customer = new RoomLeaseDetailDTO();
                customer.CustomerName = this.tbCustomerName.Text;
                customer.CustomerPassportID = this.tbCustomerPassport.Text;
                customer.CustomerTypeID = ((KeyValuePair<string, int>)this.cbCustomerType.SelectedItem).Value;
                customer.CustomerAddress = this.rtbCustomerAddress.Text;

                switch (this.Tag)
                {
                    case "AddForm":
                        {
                            MessageBox.Show("Thêm khách \"" + data[0] + "\" thành công!", "THÊM THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.AddCustomer(customer);
                            break;
                        }

                    case "EditForm":
                        {
                            MessageBox.Show("Sửa khách \"" + data[0] + "\" thành công!", "SỬA THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.EditCustomer(customer);
                            break;
                        }
                }
                this.Close();
            }
        }

        private void TbCustomerPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}