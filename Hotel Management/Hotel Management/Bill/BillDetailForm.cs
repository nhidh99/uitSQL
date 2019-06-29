using BUS;
using DTO;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI.Bill
{
    public partial class BillDetailForm : Form
    {
        Int64 TotalSurcharge = 0;
        Int64 TotalPrice = 0;

        public BillDetailForm()
        {
            InitializeComponent();
        }

        public DataGridViewRowCollection GetAllPaidRoomInBill() => this.dgvBillData.Rows;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSurchargeDetail_Click(object sender, EventArgs e)
        {
            var SurchargeForm = new BillSurchargeForm();
            SurchargeForm.ShowDialog(this);
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            var payer = mainForm.GetBillPayer();
            var rows = mainForm.GetAllPaidRoomInBill();

            // Load thông tin khách thanh toán
            this.tbBillCustomer.Text = payer.CustomerName;
            this.tbBillAddress.Text = payer.CustomerAddress;
            this.tbBillDate.Text = DateTime.ParseExact(payer.BillDate,"M/d/yyyy",CultureInfo.InvariantCulture).ToString("d/M/yyyy");

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
                                TotalSurcharge += Int64.Parse(rowData[i].ToString().Replace(",", ""));
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
            this.tbBillSurcharge.Text = TotalSurcharge.ToString("N0");
            this.tbBillPrice.Text = TotalPrice.ToString("N0");
            this.tbChange.Text = "-" + this.tbBillPrice.Text;
            if (tbChange.Text == "-0")
                tbChange.Text = "0";
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

                var bill = new RoomBillDTO();
                bill.BillDate = DateTime.ParseExact(this.tbBillDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("d");
                bill.CustomerName = this.tbBillCustomer.Text;
                bill.CustomerAddress = this.tbBillAddress.Text;
                bill.BillCost = Convert.ToInt64(this.tbBillPrice.Text.Replace(",",""));
                RoomBillBUS.InsertBill(bill);

                foreach (DataGridViewRow row in this.dgvBillData.Rows)
                {
                    var roomID = row.Cells["PaidRoomID"].Value.ToString();
                    var price = Convert.ToInt64(row.Cells["PaidRoomTotalPrice"].Value.ToString().Replace(",", ""));
                    RoomLeaseBUS.InsertRoomLeasePayment(roomID, price);
                }

                MainForm mainForm = (MainForm)Owner;
                mainForm.ReLoadRoomData();
                mainForm.ReLoadAvailableRoom();
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
