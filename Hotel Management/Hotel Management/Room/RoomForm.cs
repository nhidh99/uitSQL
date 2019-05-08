using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }
        private void Rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void EditFormRoom_Load(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "AddForm":
                    {
                        this.lbRoomHeader.Text = this.Text = "THÊM THÔNG TIN PHÒNG";
                        this.lbRoomHeader.Left = (this.ClientSize.Width - lbRoomHeader.Size.Width) / 2 + 32;
                        this.imgEditRoom.Left = this.lbRoomHeader.Left - 45;
                        break;
                    }

                case "EditForm":
                    {
                        this.lbRoomHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
                        this.tbRoomID.ReadOnly = true;
                        this.cbRoomType.Select();
                        break;
                    }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
