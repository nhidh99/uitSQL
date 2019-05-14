using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
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
            this.cbRoomStatus.DataSource = sqlExecuter.GetRoomStatusData();
            this.cbRoomType.DisplayMember = "MaLoaiPhong";
            this.cbRoomStatus.DisplayMember = "TenTinhTrang";

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
                        this.cbRoomStatus.Enabled = this.cbRoomStatus.TabStop = !sqlExecuter.CheckRentedRoom(room["ID"]);
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
            if (string.IsNullOrWhiteSpace(tbRoomID.Text))
            {
                MessageBox.Show("Phòng không được để trống!", "THÊM PHÒNG THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var room = GetRoomData();

            switch (this.Tag)
            {
                case "AddForm":
                    {
                        if (sqlExecuter.AddRoom(room))
                        {
                            MessageBox.Show("Thêm phòng " + room["ID"] + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Phòng " + room["ID"] + " đã tồn tại!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "EditForm":
                    {
                        if (sqlExecuter.EditRoom(room))
                        {
                            MessageBox.Show("Sửa phòng " + room["ID"] + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa phòng " + room["ID"] + " thất bại!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }
        }
        private void Combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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