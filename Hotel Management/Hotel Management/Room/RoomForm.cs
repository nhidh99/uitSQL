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
        SqlExecuter sqlExecuter = new SqlExecuter();
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

        public void LoadSelectedRoomData(Dictionary<string, string> room)
        {
            tbRoomID.Text = room["ID"];
            cbRoomType.Text = room["Type"];
            rtbRoomNote.Text = room["Note"];
        }

        Dictionary<string, string> GetRoomData()
        {
            return new Dictionary<string, string>()
            {
                {"ID", tbRoomID.Text },
                {"Type", cbRoomType.Text },
                {"Price", tbRoomPrice.Text },
                {"Status", cbRoomStatus.Text },
                {"Note", rtbRoomNote.Text }
            };
        }

        private void EditFormRoom_Load(object sender, EventArgs e)
        {
            this.cbRoomType.SelectedIndexChanged -= new EventHandler(CbRoomType_SelectedIndexChanged);
            this.cbRoomType.DataSource = sqlExecuter.GetRoomTypeData();
            this.cbRoomType.DisplayMember = "MaLoaiPhong";

            DataTable dt = sqlExecuter.GetRoomStatusData();
            Dictionary<string, string> status = new Dictionary<string, string>();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TenTinhTrang"].ToString() != "Thuê")
                {
                    status.Add(dr["MaTinhTrang"].ToString(), dr["TenTinhTrang"].ToString());
                }
            }

            this.cbRoomStatus.DataSource = new BindingSource(status, null);
            this.cbRoomStatus.DisplayMember = "Value";
            this.cbRoomStatus.ValueMember = "Key";

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
                        this.cbRoomStatus.Text = sqlExecuter.GetRoomStatus(room["ID"]).ToString();
                        break;
                    }
            }

            this.lbRoomHeader.Left = (this.ClientSize.Width - lbRoomHeader.Size.Width) / 2 + 32;
            this.imgEditRoom.Left = this.lbRoomHeader.Left - 45;
            this.tbRoomPrice.Text = sqlExecuter.GetRoomPriceByType(cbRoomType.Text).ToString() + " VND";
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
            room.RoomStatusID = ((KeyValuePair<string, string>)this.cbRoomStatus.SelectedItem).Key;
            room.RoomTypeID = this.cbRoomType.Text;
            room.RoomNote = this.rtbRoomNote.Text;

            switch (this.Tag)
            {
                case "AddForm":
                    {
                        if (string.IsNullOrWhiteSpace(tbRoomID.Text))
                        {
                            MessageBox.Show("Phòng không được để trống!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (RoomBUS.InsertRoom(room))
                        {
                            MessageBox.Show("Thêm phòng " + room.RoomID + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Phòng " + room.RoomID + " đã tồn tại!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }

                case "EditForm":
                    {
                        if (RoomBUS.UpdateRoom(room))
                        {
                            MessageBox.Show("Sửa phòng " + room.RoomID + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa phòng đang thuê", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }

            MainForm mainForm = (MainForm)Owner;
            mainForm.LoadRoomData();
            mainForm.LoadAvailableRoom();
        }
        private void CbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbRoomPrice.Text = sqlExecuter.GetRoomPriceByType(cbRoomType.Text).ToString() + " VND";
        }
    }
}