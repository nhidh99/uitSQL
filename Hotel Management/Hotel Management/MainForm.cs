using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel_Management.Bill;
using Hotel_Management.Room;
using Hotel_Management.Rule;
using Hotel_Management.CustomerType;
using Hotel_Management.RoomType;
using System.Collections.Generic;

namespace Hotel_Management
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        SqlExecuter sqlExecuter = new SqlExecuter();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadRoomData();
            this.LoadAvailableRoom();
        }


        // Auto numbering first columns in DataGrid
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void Rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void Combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Tab 01: Room List

        void LoadSelectedRoom(DataGridViewRow row)
        {
            tbListRoomID.Text = row.Cells["RoomID"].Value.ToString();
            tbListRoomType.Text = row.Cells["RoomType"].Value.ToString();
            tbListRoomPrice.Text = row.Cells["RoomPrice"].Value.ToString();
            rtbListRoomNote.Text = row.Cells["RoomNote"].Value.ToString();
        }

        public Dictionary<string, string> GetSelectedRoom() => new Dictionary<string, string>()
        {
            {"ID", tbListRoomID.Text },
            {"Type", tbListRoomType.Text },
            {"Note", rtbListRoomNote.Text }
        };

        public void LoadRoomData() => dgvListRoom.DataSource = sqlExecuter.GetRoomData();

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "AddForm";
            RoomForm.ShowDialog(this);
        }

        private void BtnDelRoom_Click(object sender, EventArgs e)
        {
            var RoomID = tbListRoomID.Text;

            if (sqlExecuter.CheckRentedRoom(RoomID))
            {
                MessageBox.Show("Không thể xoá phòng đang thuê!", "XOÁ PHÒNG THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                var dialogResult = MessageBox.Show("Bạn có muốn xoá phòng " + RoomID + "?", "XÁC NHẬN XOÁ PHÒNG",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes && sqlExecuter.DeleteRoom(RoomID))
                {
                    MessageBox.Show("Xoá phòng " + RoomID + " thành công!", "XOÁ PHÒNG THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadRoomData();
                    this.LoadAvailableRoom();
                }
            }
        }

        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "EditForm";
            RoomForm.ShowDialog(this);
        }
        private void DgvListRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.LoadSelectedRoom(dgvListRoom.CurrentRow);
        }

        // Tab 02: Room Note
        public void LoadAvailableRoom()
        {
            this.cbNoteRoomID.SelectedIndexChanged -= new EventHandler(CbNoteRoomID_SelectedIndexChanged);
            this.cbNoteRoomID.DataSource = sqlExecuter.GetAvailableRoomData();
            this.cbNoteRoomID.DisplayMember = "MaPhong";
            this.cbNoteRoomID.SelectedIndexChanged += new EventHandler(CbNoteRoomID_SelectedIndexChanged);
            this.deNoteRoomDate.Text = DateTime.Now.ToString();
        }

        public void AddCustomer(Dictionary<string, string> customer)
        {
            this.dgvNoteCustomer.Rows.Add(customer["Name"], customer["Type"], customer["PassportID"], customer["Address"]);
        }

        public void EditCustomer(Dictionary<string, string> customer)
        {
            this.dgvNoteCustomer.CurrentRow.SetValues(customer["Name"], customer["Type"], customer["PassportID"], customer["Address"]);
        }

        public Dictionary<string, string> GetSelectedCustomer() => new Dictionary<string, string>()
        {
            {"Name", tbNoteCustomerName.Text },
            {"Type", tbNoteCustomerType.Text },
            {"PassportID", tbNoteCustomerPassport.Text },
            {"Address", rtbNoteCustomerAddress.Text }
        };

        public Dictionary<string, string> GetRoomDetail()
        {
            var RoomType = sqlExecuter.GetRoomType(cbNoteRoomID.Text).ToString();

            return new Dictionary<string, string>()
            {
                {"ID", cbNoteRoomID.Text },
                {"Type", RoomType },
                {"Price", tbNoteRoomPrice.Text },
                {"RentDate", deNoteRoomDate.Text }
            };
        }

        public DataGridViewRowCollection GetAllRowsCustomerInNote() => this.dgvNoteCustomer.Rows;

        public void RecreateNoteRoom()
        {
            this.btnLockNoteRoom.Enabled = true;
            this.btnCancelNote.Enabled = false;
            this.btnAddNoteCustomer.Enabled = false;
            this.btnDelNoteCustomer.Enabled = false;
            this.btnEditNoteCustomer.Enabled = false;
            this.cbNoteRoomID.Enabled = true;
            this.deNoteRoomDate.Enabled = true;
            this.gcNoteCustomer.Text = "DANH SÁCH KHÁCH";
            this.dgvNoteCustomer.Rows.Clear();
        }

        private void LoadSelectedCustomer(DataGridViewRow row)
        {
            this.tbNoteCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            this.tbNoteCustomerPassport.Text = row.Cells["CustomerPassportID"].Value.ToString();
            this.tbNoteCustomerType.Text = row.Cells["CustomerType"].Value.ToString();
            this.rtbNoteCustomerAddress.Text = row.Cells["CustomerAddress"].Value.ToString();
        }

        private void CbNoteRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbNoteRoomPrice.Text = sqlExecuter.GetRoomPriceByRoomID(cbNoteRoomID.Text).ToString() + " VND";
        }

        private void TabNoteRoom_VisibleChanged(object sender, EventArgs e)
        {
            this.tbNoteRoomPrice.Text = sqlExecuter.GetRoomPriceByRoomID(cbNoteRoomID.Text).ToString() + " VND";
        }

        private void BtnLockNoteRoom_Click(object sender, EventArgs e)
        {
            this.btnLockNoteRoom.Enabled = false;
            this.btnAddNoteCustomer.Enabled = true;
            this.cbNoteRoomID.Enabled = false;
            this.deNoteRoomDate.Enabled = false;
            this.btnCancelNote.Enabled = true;
            this.gcNoteCustomer.Text += " [PHÒNG: " + cbNoteRoomID.Text + " - NGÀY THUÊ: " + deNoteRoomDate.Text + "]";
        }


        private void BtnAddNoteCustomer_Click(object sender, EventArgs e)
        {
            var MaxCustomers = Convert.ToInt16(sqlExecuter.GetMaxCustomersInRoom());

            if (this.dgvNoteCustomer.Rows.Count == MaxCustomers)
            {
                MessageBox.Show("Số khách trong phòng đã đạt mức tối đa!", "THÊM KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var CustomerForm = new CustomerForm();
                CustomerForm.Tag = "AddForm";
                CustomerForm.ShowDialog(this);
            }
        }

        private void BtnDelNoteCustomer_Click(object sender, EventArgs e)
        {
            var customerName = dgvNoteCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            var dialogResult = MessageBox.Show("Bạn có muốn xoá khách \"" + customerName + "\"?", "XÁC NHẬN XOÁ KHÁCH",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Xoá khách \"" + customerName + "\" thành công!", "XOÁ KHÁCH THÀNH CÔNG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvNoteCustomer.Rows.Remove(this.dgvNoteCustomer.CurrentRow);
            }
        }


        private void BtnEditNoteCustomer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomerForm();
            CustomerForm.Tag = "EditForm";
            CustomerForm.ShowDialog(this);
        }


        private void BtnCreateNote_Click(object sender, EventArgs e)
        {
            var RoomDetailForm = new RoomDetailForm();
            RoomDetailForm.ShowDialog(this);
        }

        private void BtnCancelNote_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có muốn huỷ lập phiếu thuê phòng " + cbNoteRoomID.Text + "?", "XÁC NHẬN HUỶ LẬP PHIẾU",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Huỷ lập phiếu thuê phòng " + cbNoteRoomID.Text + " thành công", "HUỶ PHIẾU THUÊ THÀNH CÔNG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.RecreateNoteRoom();
            }
        }

        private void DgvNoteCustomer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnDelNoteCustomer.Enabled = true;
            this.btnEditNoteCustomer.Enabled = true;
            this.btnCreateNote.Enabled = true;
            this.btnCancelNote.Enabled = true;
        }

        private void DgvNoteCustomer_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvNoteCustomer.Rows.Count == 0)
            {
                this.btnDelNoteCustomer.Enabled = false;
                this.btnEditNoteCustomer.Enabled = false;
                this.btnCreateNote.Enabled = false;
                this.tbNoteCustomerName.Text = null;
                this.tbNoteCustomerPassport.Text = null;
                this.tbNoteCustomerType.Text = null;
                this.rtbNoteCustomerAddress.Text = null;
            }
        }

        private void DgvNoteCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.LoadSelectedCustomer(dgvNoteCustomer.CurrentRow);
        }

        private void DgvNoteCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.LoadSelectedCustomer(dgvNoteCustomer.CurrentRow);
            }
        }

        // Tab 03: Room Search
        private void BtnFindRoom_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelFindRoom_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditFindRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "EditForm";
            RoomForm.ShowDialog(this);
        }

        // Tab 04: Room Bill

        private void BtnLockBill_Click(object sender, EventArgs e)
        {
            this.btnDelBillRoom.Enabled
                = this.btnAddBillRoom.Enabled
                = this.btnCreateBillRoom.Enabled
                = this.btnCancelBillRoom.Enabled
                = this.cbAddBillRoomID.Enabled = true;
        }


        private void BtnDelBillRoom_Click(object sender, EventArgs e)
        {

        }


        private void BtnAddBillRoom_Click(object sender, EventArgs e)
        {

        }


        private void BtnCreateBillRoom_Click(object sender, EventArgs e)
        {
            var DetailForm = new BillDetailForm();
            DetailForm.ShowDialog(this);
        }


        private void BtnCancelBillRoom_Click(object sender, EventArgs e)
        {

        }

        //Tab 05: Room-Revenue Report

        private void BtnCreateMonthRevenue_Click(object sender, EventArgs e)
        {

        }

        //Tab 06: Room-Rule Edit
        private void BtnEditMaxCustomerRule_Click(object sender, EventArgs e)
        {
            var EditForm = new MaxCustomerEditForm();
            EditForm.ShowDialog(this);
        }

        private void BtnEditThirdCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new ThirdCustomerTaxEditForm();
            EditForm.ShowDialog(this);
        }

        private void BtnEditForeignCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new ForeignCustomerEditForm();
            EditForm.ShowDialog(this);
        }

        private void BtnAddRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeForm = new RoomTypeForm();
            RoomTypeForm.Tag = "AddForm";
            RoomTypeForm.ShowDialog(this);
        }

        private void BtnDelRoomType_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeForm = new RoomTypeForm();
            RoomTypeForm.Tag = "EditForm";
            RoomTypeForm.ShowDialog(this);
        }

        private void BtnAddCustomerType_Click(object sender, EventArgs e)
        {
            var AddForm = new CustomerTypeAddForm();
            AddForm.ShowDialog(this);
        }

        private void BtnDelCustomerType_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditCustomerType_Click(object sender, EventArgs e)
        {
            var EditForm = new CustomerTypeEditForm();
            EditForm.ShowDialog(this);
        }
    }
}