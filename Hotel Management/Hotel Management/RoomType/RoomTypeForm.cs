using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.RoomType
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
                        this.tbRoomType.TabStop = false;
                        this.tbRoomType.ReadOnly = true;

                        var mainForm = (MainForm)Owner;
                        var roomType = mainForm.GetSelectedRoomType();
                        this.tbRoomType.Text = roomType.RoomTypeID;
                        this.tbRoomTypePrice.Text = roomType.RoomTypePrice.ToString("N0");
                        break;
                    }
            }
        }

        private void TbRoomTypePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbRoomTypePrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbRoomTypePrice.Text))
            {
                this.tbRoomTypePrice.Text = "0";
            }

            this.tbRoomTypePrice.Text = Int64.Parse(this.tbRoomTypePrice.Text.Replace(",", "")).ToString("N0");
            this.tbRoomTypePrice.SelectionStart = this.tbRoomTypePrice.Text.Length;
            this.tbRoomTypePrice.SelectionLength = 0;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "AddForm":
                    {
                        if (string.IsNullOrEmpty(this.tbRoomTypePrice.Text) || string.IsNullOrEmpty(this.tbRoomType.Text))
                        {
                            MessageBox.Show("Các thông tin không được để trống",
                                "THÊM LOẠI PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var roomType = new RoomTypeDTO();
                            roomType.RoomTypeID = this.tbRoomType.Text;
                            roomType.RoomTypePrice = Convert.ToInt64(this.tbRoomTypePrice.Text.Replace(",", ""));

                            if (RoomTypeBUS.InsertRoomType(roomType))
                            {
                                MessageBox.Show(
                                "Thêm loại phòng " + roomType.RoomTypeID + " thành công!",
                                "THÊM LOẠI PHÒNG THÀNH CÔNG!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                                var mainForm = (MainForm)Owner;
                                mainForm.ReLoadRoomTypeList();
                                mainForm.ReLoadFindRoom();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                "Loại phòng " + roomType.RoomTypeID + " đã tồn tại!",
                                "THÊM LOẠI PHÒNG THẤT BẠI!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    }

                case "EditForm":
                    {
                        if (string.IsNullOrEmpty(this.tbRoomType.Text))
                        {
                            MessageBox.Show("Các thông tin không được để trống",
                                "THÊM LOẠI PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var roomType = new RoomTypeDTO();
                            roomType.RoomTypeID = this.tbRoomType.Text;
                            roomType.RoomTypePrice = Convert.ToInt64(this.tbRoomTypePrice.Text.Replace(",", ""));

                            if (RoomTypeBUS.UpdateRoomType(roomType))
                            {
                                MessageBox.Show(
                                "Sửa loại phòng " + roomType.RoomTypeID + " thành công!",
                                "SỬA LOẠI PHÒNG THÀNH CÔNG!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                                var mainForm = (MainForm)Owner;
                                mainForm.ReLoadRoomTypeList();
                                mainForm.ReLoadRoomData();
                                mainForm.ReLoadAvailableRoom();
                                mainForm.ReLoadFindRoom();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                "Sửa loại phòng " + roomType.RoomTypeID + " thất bại!",
                                "THÊM LOẠI PHÒNG THẤT BẠI!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    }
            }
        }
    }
}
