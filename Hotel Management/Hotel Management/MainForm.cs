using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel_Management.Bill;
using Hotel_Management.Room;
using Hotel_Management.Rule;
using Hotel_Management.CustomerType;
using Hotel_Management.RoomType;

namespace Hotel_Management
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
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

        }

        // Tab 01: Room List

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "AddForm";
            RoomForm.ShowDialog();
        }


        private void BtnDelRoom_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            var RoomForm = new RoomForm();
            RoomForm.Tag = "EditForm";
            RoomForm.ShowDialog();
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
            CustomerForm.ShowDialog();
        }


        private void BtnDelNoteCustomer_Click(object sender, EventArgs e)
        {

        }


        private void BtnEditNoteCustomer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomerForm();
            CustomerForm.FormType = "EditForm";
            CustomerForm.ShowDialog();
        }


        private void BtnCreateNote_Click(object sender, EventArgs e)
        {
            var RoomDetailForm = new RoomDetailForm();
            RoomDetailForm.ShowDialog();
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
            RoomForm.ShowDialog();
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
            DetailForm.ShowDialog();
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
            EditForm.ShowDialog();
        }

        private void BtnEditThirdCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new ThirdCustomerTaxEditForm();
            EditForm.ShowDialog();
        }

        private void BtnEditForeignCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new ForeignCustomerEditForm();
            EditForm.ShowDialog();
        }

        private void BtnAddRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeForm = new RoomTypeForm();
            RoomTypeForm.Tag = "AddForm";
            RoomTypeForm.ShowDialog();
        }

        private void BtnDelRoomType_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeForm = new RoomTypeForm();
            RoomTypeForm.Tag = "EditForm";
            RoomTypeForm.ShowDialog();
        }

        private void BtnAddCustomerType_Click(object sender, EventArgs e)
        {
            var AddForm = new CustomerTypeAddForm();
            AddForm.ShowDialog();
        }

        private void BtnDelCustomerType_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditCustomerType_Click(object sender, EventArgs e)
        {
            var EditForm = new CustomerTypeEditForm();
            EditForm.ShowDialog();
        }
    }
}
