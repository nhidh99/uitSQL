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

        public void LoadSelectedRoomData(Dictionary<string, string> data)
        {
            tbRoomID.Text = data["RoomID"];
            cbRoomType.Text = data["RoomType"];
            rtbRoomNote.Text = data["RoomNote"];
        }

        Dictionary<string, string> GetRoomData()
        {
            return new Dictionary<string, string>()
            {
                {"RoomID", tbRoomID.Text },
                {"RoomType", cbRoomType.Text },
                {"RoomPrice", tbRoomPrice.Text },
                {"RoomStatus", cbRoomStatus.Text },
                {"RoomNote", rtbRoomNote.Text }
            };
        }

        private void EditFormRoom_Load(object sender, EventArgs e)
        {
            cbRoomType.DataSource = sqlExecuter.GetRoomTypeData();
            cbRoomStatus.DataSource = sqlExecuter.GetRoomStatusData();
            cbRoomType.DisplayMember = "MaLoaiPhong";
            cbRoomStatus.DisplayMember = "TenTinhTrang";

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
                        var RoomData = mainForm.GetSelectedRoomData();

                        this.LoadSelectedRoomData(RoomData);
                        this.lbRoomHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
                        this.tbRoomID.ReadOnly = true;
                        this.cbRoomStatus.Enabled = !sqlExecuter.IsRentedRoom(RoomData["RoomID"]);
                        this.cbRoomStatus.Text = sqlExecuter.GetRoomStatus(RoomData["RoomID"]).ToString();
                        break;
                    }
            }

            this.lbRoomHeader.Left = (this.ClientSize.Width - lbRoomHeader.Size.Width) / 2 + 32;
            this.imgEditRoom.Left = this.lbRoomHeader.Left - 45;
            this.tbRoomPrice.Text = sqlExecuter.GetRoomPrice(cbRoomType.Text).ToString() + " VND";
            this.cbRoomType.SelectedIndexChanged += new EventHandler(CbRoomType_SelectedIndexChanged);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var RoomData = GetRoomData();

            switch (this.Tag)
            {
                case "AddForm":
                    {
                        if (sqlExecuter.AddRoom(RoomData))
                        {
                            MessageBox.Show("Thêm phòng " + RoomData["RoomID"] + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Phòng " + RoomData["RoomID"] + " đã tồn tại!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "EditForm":
                    {
                        if (sqlExecuter.EditRoom(RoomData))
                        {
                            MessageBox.Show("Sửa phòng " + RoomData["RoomID"] + " thành công!", "THÊM PHÒNG THÀNH CÔNG",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa phòng " + RoomData["RoomID"] + " thất bại!", "THÊM PHÒNG THẤT BẠI",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }
            this.Close();
        }
        private void Combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            mainForm.LoadRoomData();
        }

        private void CbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbRoomPrice.Text = sqlExecuter.GetRoomPrice(cbRoomType.Text).ToString() + " VND";
        }
    }
}