using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
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

        public void LoadSelectedRoomData(RoomDTO room)
        {
            tbRoomID.Text = room.RoomID;
            cbRoomType.Text = room.RoomTypeID;
            rtbRoomNote.Text = room.RoomNote;
        }
        private void EditFormRoom_Load(object sender, EventArgs e)
        {
            this.cbRoomType.SelectedIndexChanged -= new EventHandler(CbRoomType_SelectedIndexChanged);
            this.cbRoomType.DataSource = RoomTypeBUS.GetRoomTypeList();
            this.cbRoomType.DisplayMember = "MaLoaiPhong";

            DataTable dt = RoomStatusBUS.GetRoomStatusList();
            Dictionary<string, string> status = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TenTinhTrang"].ToString() != "Thuê")
                {
                    status.Add(dr["TenTinhTrang"].ToString(), dr["MaTinhTrang"].ToString());
                }
            }

            this.cbRoomStatus.DataSource = new BindingSource(status, null);
            this.cbRoomStatus.DisplayMember = "Key";
            this.cbRoomStatus.ValueMember = "Value";

            switch (this.Tag)
            {
                case "AddForm":
                    {
                        this.lbRoomHeader.Text = this.Text = "THÊM THÔNG TIN PHÒNG";
                        this.cbRoomType.SelectedIndex = 0;
                        this.cbRoomStatus.SelectedIndex = 0;
                        break;
                    }

                case "EditForm":
                    {
                        MainForm mainForm = (MainForm)Owner;
                        var room = mainForm.GetSelectedRoom();

                        this.LoadSelectedRoomData(room);
                        this.lbRoomHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
                        this.tbRoomID.ReadOnly = true;
                        this.tbRoomID.TabStop = false;
                        break;
                    }
            }

            this.lbRoomHeader.Left = (this.ClientSize.Width - lbRoomHeader.Size.Width) / 2 + 32;
            this.imgEditRoom.Left = this.lbRoomHeader.Left - 45;
            this.tbRoomPrice.Text = Convert.ToInt64(RoomTypeBUS.GetRoomPriceByType(cbRoomType.Text)).ToString("N0") + " VND";
            this.cbRoomType.SelectedIndexChanged += new EventHandler(CbRoomType_SelectedIndexChanged);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            RoomDTO room = new RoomDTO();
            room.RoomID = this.tbRoomID.Text;
            room.RoomTypeID = this.cbRoomType.Text;
            room.RoomNote = this.rtbRoomNote.Text;
            room.RoomStatusID = ((KeyValuePair<string, string>)this.cbRoomStatus.SelectedItem).Value;

            switch (this.Tag)
            {
                case "AddForm":
                    {
                        if (RoomBUS.InsertRoom(room))
                        {
                            MessageBox.Show("Thêm phòng " + room.RoomID + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Phòng đã tồn tại hoặc tên phòng không được để trống", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }

                case "EditForm":
                    {
                        if (RoomBUS.UpdateRoom(room))
                        {
                            MessageBox.Show("Sửa phòng " + room.RoomID + " thành công!", "SỬA PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa phòng đang thuê", "SỬA PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }

            MainForm mainForm = (MainForm)Owner;
            mainForm.ReLoadRoomData();
            mainForm.ReLoadAvailableRoom();
            mainForm.ReLoadFindRoom();
        }
        private void CbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbRoomPrice.Text = Convert.ToInt64(RoomTypeBUS.GetRoomPriceByType(cbRoomType.Text)).ToString("N0") + " VND";
        }
    }
}