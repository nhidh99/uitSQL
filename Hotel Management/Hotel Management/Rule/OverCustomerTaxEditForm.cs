using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class OverCustomerTaxEditForm : Form
    {
        public OverCustomerTaxEditForm()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (RoomLeaseBUS.UpdateOverCustomerTaxPercent(Convert.ToInt16(this.nudTaxPercent.Value)))
            {
                MessageBox.Show(
                    "Chỉnh sửa số phụ thu khách thêm thành công!\n" +
                    "Lưu ý: Phụ thu tối đa có thể quy định là " + this.nudTaxPercent.Maximum.ToString() + "%",
                    "CHỈNH SỬA THÀNH CÔNG!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var mainForm = (MainForm)Owner;
                mainForm.ReLoadOverCustomerTax();
                this.Close();
            }
            else MessageBox.Show(
                    "Chỉnh sửa phụ thu khách thêm thất bại!",
                    "CHỈNH SỬA THẤT BẠI!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NudTaxPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NudTaxPercent_Enter(object sender, EventArgs e)
        {
            this.nudTaxPercent.Select(0, this.nudTaxPercent.Text.Length);
        }
    }
}
