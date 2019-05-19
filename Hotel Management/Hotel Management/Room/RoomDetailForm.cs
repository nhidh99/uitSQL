using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Hotel_Management.Room
{
    public partial class RoomDetailForm : Form
    {
        SqlExecuter sqlExecuter = new SqlExecuter();
        public RoomDetailForm()
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
            var room = mainForm.GetRoomDetail();

            this.tbRoomID.Text = room["ID"];
            this.tbRoomType.Text = room["Type"];
            this.tbRoomDate.Text = room["RentDate"];
            this.tbRoomPrice.Text = room["Price"];

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
            var roomDate = DateTime.ParseExact(tbRoomDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
            var roomPrice = sqlExecuter.GetRoomPriceByRoomID(tbRoomID.Text).ToString().Replace(",", "");

            var room = new Dictionary<string, string>()
            {
                {"ID", tbRoomID.Text },
                {"Type", tbRoomType.Text },
                {"Price", roomPrice },
                {"Date", roomDate.ToString("d") }
            };

            if (sqlExecuter.AddNoteRoom(room))
            {
                var noteID = Convert.ToInt32(sqlExecuter.GetLastNoteIDByRoomID(room["ID"]));
                foreach (DataGridViewRow row in dgvCustomerData.Rows)
                {
                    var customer = new Dictionary<string, string>()
                    {
                        {"PassportID", row.Cells["CustomerPassportID"].Value.ToString() },
                        {"Name", row.Cells["CustomerName"].Value.ToString() },
                        {"Type", row.Cells["CustomerType"].Value.ToString() },
                        {"Address", row.Cells["CustomerAddress"].Value.ToString() }
                    };
                    sqlExecuter.AddCustomerInNoteRoom(noteID, customer);
                }

                MainForm mainForm = (MainForm)Owner;
                mainForm.LoadAvailableRoom();
                mainForm.LoadRoomData();

                MessageBox.Show("Lập phiếu thuê phòng " + room["ID"] + " thành công!", "LẬP PHIẾU THUÊ PHÒNG THÀNH CÔNG",
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