using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI.Room
{
    public partial class RoomLeaseForm : Form
    {
        public RoomLeaseForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomDetailForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var room = mainForm.GetRoomLease();

            this.tbRoomID.Text = room.RoomID;
            this.tbRoomType.Text = room.RoomTypeID;
            this.tbRoomPrice.Text = room.RoomPrice.ToString("N0") + " VND";
            this.tbRoomDate.Text = DateTime.ParseExact(room.LeaseDate, "M/d/yyyy", CultureInfo.InvariantCulture).ToString("d/M/yyyy");

            var rows = mainForm.GetAllRowsCustomerInNote();
            foreach (DataGridViewRow row in rows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dgvCustomerData.Rows.Add(rowData);
            }
        }

        private void DgvCustomerData_SelectionChanged(object sender, EventArgs e)
        {
            dgvCustomerData.ClearSelection();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var lease = new RoomLeaseDTO();
            lease.RoomID = this.tbRoomID.Text;
            lease.RoomTypeID = this.tbRoomType.Text;
            lease.RoomPrice = Int64.Parse(this.tbRoomPrice.Text.Split()[0].Replace(",", ""));
            lease.LeaseDate = DateTime.ParseExact(tbRoomDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("d");

            if (RoomLeaseBUS.InsertRoomLease(lease))
            {
                RoomLeaseDetailDTO detail = new RoomLeaseDetailDTO();
                detail.LeaseID = RoomLeaseBUS.GetLastLeaseIDOfRoom(lease.RoomID);

                foreach (DataGridViewRow row in dgvCustomerData.Rows)
                {
                    detail.CustomerName = row.Cells["CustomerName"].Value.ToString();
                    detail.CustomerPassportID = row.Cells["CustomerPassportID"].Value.ToString();
                    detail.CustomerTypeID = Convert.ToInt32(row.Cells["CustomerTypeID"].Value);
                    detail.CustomerAddress = row.Cells["CustomerAddress"].Value.ToString();
                    RoomLeaseDetailBUS.InsertDetail(detail);
                }

                MainForm mainForm = (MainForm)Owner;
                mainForm.ReLoadAvailableRoom();
                mainForm.ReLoadRoomData();
                mainForm.ReCreateNote();

                MessageBox.Show("Lập phiếu thuê phòng " + lease.RoomID + " thành công!", "LẬP PHIẾU THUÊ PHÒNG THÀNH CÔNG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void DgvCustomerData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
    }
}