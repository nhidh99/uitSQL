using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
            mainForm = new MainForm();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var result = LoginBUS.Login(tbUsername.Text, tbPassword.Text);
            switch (result)
            {
                case 0:
                    {
                        mainForm.HideRoomRuleEdit();
                        mainForm.Show(this);
                        this.Hide();
                        break;
                    }

                case 1:
                    {
                        mainForm.Show(this);
                        this.Hide();
                        break;
                    }

                case -1:
                    {
                        MessageBox.Show("Không thể kết nối CSDL hoặc lỗi đăng nhập!",
                               "ĐĂNG NHẬP THẤT BẠI!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.PerformClick();
            }
        }
    }
}
