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
            this.LoadRoomData();
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

        // Tab 01: Room List

        void ListRoom_LoadSelectedRow(DataGridViewRow row)
        {
            tbListRoomID.Text = row.Cells["RoomID"].Value.ToString();
            tbListRoomType.Text = row.Cells["RoomType"].Value.ToString();
            tbListRoomPrice.Text = row.Cells["RoomPrice"].Value.ToString();
            rtbListRoomNote.Text = row.Cells["RoomNote"].Value.ToString();
        }

        public Dictionary<string, string> GetSelectedRoomData()
        {
            return new Dictionary<string, string>()
            {
                {"RoomID",tbListRoomID.Text },
                {"RoomType",tbListRoomType.Text },
                {"RoomNote",rtbListRoomNote.Text }
            };
        }

        public void LoadRoomData()
        {
            dgvListRoom.DataSource = sqlExecuter.GetRoomData();
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "AddForm";
            RoomForm.ShowDialog(this);
        }

        private void BtnDelRoom_Click(object sender, EventArgs e)
        {
            var RoomID = tbListRoomID.Text;

            if (sqlExecuter.IsRentedRoom(RoomID))
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
            ListRoom_LoadSelectedRow(dgvListRoom.CurrentRow);
        }

        // Tab 02: Room Note

        private void BtnLockNoteRoom_Click(object sender, EventArgs e)
        {
            this.btnAddNoteCustomer.Enabled
                = this.btnDelNoteCustomer.Enabled
                = this.btnEditNoteCustomer.Enabled
                = this.btnCreateNote.Enabled
                = this.btnCancelNote.Enabled = true;
        }


        private void BtnAddNoteCustomer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomerForm();
            CustomerForm.Tag = "AddForm";
            CustomerForm.ShowDialog(this);
        }


        private void BtnDelNoteCustomer_Click(object sender, EventArgs e)
        {

        }


        private void BtnEditNoteCustomer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomerForm();
            CustomerForm.FormType = "EditForm";
            CustomerForm.ShowDialog(this);
        }


        private void BtnCreateNote_Click(object sender, EventArgs e)
        {
            var RoomDetailForm = new RoomDetailForm();
            RoomDetailForm.ShowDialog(this);
        }

        private void BtnCancelNote_Click(object sender, EventArgs e)
        {

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