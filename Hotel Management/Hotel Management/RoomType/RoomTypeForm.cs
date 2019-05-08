using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.RoomType
{
    public partial class RoomTypeForm : Form
    {
        public RoomTypeForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomTypeForm_Load(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "AddForm":
                    {
                        this.Text = this.lbRoomTypeHeader.Text = "THÊM THÔNG TIN LOẠI PHÒNG";
                        this.lbRoomTypeHeader.Left = (this.ClientSize.Width - lbRoomTypeHeader.Size.Width) / 2 + 32;
                        this.imgAddRoomType.Left = this.lbRoomTypeHeader.Left - 45;
                        break;
                    }

                case "EditForm":
                    {
                        this.Text = this.lbRoomTypeHeader.Text = "THAY ĐỔI THÔNG TIN LOẠI PHÒNG";
                        this.tbRoomType.ReadOnly = true;
                        this.tbRoomTypePrice.Select();
                        break;
                    }
            }
        }
    }
}
