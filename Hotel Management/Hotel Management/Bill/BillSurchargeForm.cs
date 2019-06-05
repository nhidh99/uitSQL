using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
    public partial class BillSurchargeForm : Form
    {
        public BillSurchargeForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSurchargeDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void DgvSurchargeDetail_SelectionChanged(object sender, EventArgs e)
        {
            this.dgvSurchargeDetail.ClearSelection();
        }

        private void BillSurchargeForm_Load(object sender, EventArgs e)
        {
            BillDetailForm billForm = (BillDetailForm)Owner;
            var rows = billForm.GetAllPaidRoomInBill();

            foreach (DataGridViewRow row in rows)
            {
                object[] rowData = new object[4];
                rowData[0] = row.Cells["PaidRoomID"].Value;
                rowData[1] = row.Cells["AdditionalCustomerSurcharge"].Value;
                rowData[2] = row.Cells["ForeignCustomerSurcharge"].Value;
                rowData[3] = (Int64.Parse(rowData[1].ToString().Replace(",","")) + 
                    Int64.Parse(rowData[2].ToString().Replace(",",""))).ToString("N0");
                this.dgvSurchargeDetail.Rows.Add(rowData);
            }
        }
    }
}
