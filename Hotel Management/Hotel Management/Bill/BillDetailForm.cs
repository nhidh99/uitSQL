using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Hotel_Management.Bill
{
    public partial class BillDetailForm : Form
    {
        Int64 TotalTax = 0;
        Int64 TotalPrice = 0;
        SqlExecuter sqlExecuter = new SqlExecuter();

        public BillDetailForm()
        {
            InitializeComponent();
        }

        public DataGridViewRowCollection GetAllPaidRoomInBill() => this.dgvBillData.Rows;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTaxDetail_Click(object sender, EventArgs e)
        {
            var TaxForm = new BillTaxForm();
            TaxForm.ShowDialog(this);
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var payer = mainForm.GetPayerDetail();
            var rows = mainForm.GetAllPaidRoomInBill();

            // Load thông tin khách thanh toán
            this.tbBillCustomer.Text = payer["Name"];
            this.tbBillDate.Text = payer["BillDate"];
            this.tbBillAddress.Text = payer["Address"];

            // Load thông tin chi tiết thanh toán
            foreach (DataGridViewRow row in rows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;

                    switch (i)
                    {
                        // Cột phụ thu khách thứ 3 + khách nước ngoài
                        case 3:
                        case 4:
                            {
                                TotalTax += Int64.Parse(rowData[i].ToString().Replace(",", ""));
                                break;
                            }

                        // Cột thành tiền
                        case 5:
                            {
                                TotalPrice += Int64.Parse(rowData[i].ToString().Replace(",", ""));
                                break;
                            }
                    }
                }
                this.dgvBillData.Rows.Add(rowData);
            }

            // Tính toán thông tin thanh toán
            this.tbBillTax.Text = TotalTax.ToString("N0");
            this.tbBillPrice.Text = TotalPrice.ToString("N0");
            this.tbChange.Text = "-" + this.tbBillPrice.Text;
        }

        private void DgvBillData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void TbReceivedMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbReceivedMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbReceivedMoney.Text))
            {
                this.tbReceivedMoney.Text = "0";
            }

            this.tbReceivedMoney.Text = Int64.Parse(this.tbReceivedMoney.Text.Replace(",", "")).ToString("N0");
            this.tbChange.Text = (Int64.Parse(this.tbReceivedMoney.Text.ToString().Replace(",", "")) - TotalPrice).ToString("N0");
            this.tbReceivedMoney.SelectionStart = this.tbReceivedMoney.Text.Length;
            this.tbReceivedMoney.SelectionLength = 0;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (this.tbChange.Text[0] == '-')
            {
                MessageBox.Show(
                    "Số tiền nhận chưa đủ tiền thanh toán",
                    "THANH TOÁN HOÁ ĐƠN THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var BillDate = DateTime.ParseExact(this.tbBillDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture);

                var payer = new Dictionary<string, string>()
                {
                    {"Name", this.tbBillCustomer.Text },
                    {"BillDate", BillDate.ToString("d") },
                    {"Address",this.tbBillAddress.Text }
                };

                sqlExecuter.AddBill(payer, this.tbBillPrice.Text.Replace(",", ""));

                foreach (DataGridViewRow row in this.dgvBillData.Rows)
                {
                    sqlExecuter.PayRoom(row.Cells["PaidRoomID"].Value.ToString(), 
                        row.Cells["PaidRoomTotalPrice"].Value.ToString().Replace(",",""));
                }

                MainForm mainForm = (MainForm)Owner;
                mainForm.LoadRoomData();
                mainForm.LoadAvailableRoom();
                mainForm.ReCreateBill();

                MessageBox.Show(
                    "Thanh toán hoá đơn thành công",
                    "THANH TOÁN HOÁ ĐƠN THÀNH CÔNG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
