using BUS;
using System;
using System.Windows.Forms;

namespace GUI.CustomerType
{
    public partial class CustomerTypeEditForm : Form
    {
        public CustomerTypeEditForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbNewCustomerType.Text))
            {
                MessageBox.Show("Các thông tin không được để trống",
                    "SỬA LOẠI KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var oldType = this.tbOldCustomerType.Text;
                var newType = this.tbNewCustomerType.Text;
                if (CustomerTypeBUS.UpdateCustomerType(oldType, newType))
                {
                    MessageBox.Show(
                    "Sửa loại khách thành công!",
                    "SỬA LOẠI KHÁCH THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    var mainForm = (MainForm)Owner;
                    mainForm.ReLoadCustomerTypeList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    $"Loại khách {newType} đã tồn tại!",
                    "SỬA LOẠI KHÁCH THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        private void CustomerTypeEditForm_Load(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Owner;
            this.tbOldCustomerType.Text = mainForm.GetSelectedCustomerType();
        }
    }
}
