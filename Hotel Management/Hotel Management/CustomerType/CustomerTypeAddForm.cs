using BUS;
using System;
using System.Windows.Forms;

namespace GUI.CustomerType
{
    public partial class CustomerTypeAddForm : Form
    {
        public CustomerTypeAddForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbCustomerType.Text))
            {
                MessageBox.Show("Các thông tin không được để trống",
                    "THÊM LOẠI KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var customerType = this.tbCustomerType.Text;

                if (CustomerTypeBUS.InsertCustomerType(customerType))
                {
                    MessageBox.Show(
                    "Thêm loại khách " + customerType + " thành công!",
                    "THÊM LOẠI KHÁCH THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    var mainForm = (MainForm)Owner;
                    mainForm.ReLoadCustomerTypeList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    "Loại khách " + customerType + " đã tồn tại!",
                    "THÊM LOẠI KHÁCH THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
