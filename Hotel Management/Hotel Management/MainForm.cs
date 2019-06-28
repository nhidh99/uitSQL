using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Bill;
using GUI.Room;
using GUI.Rule;
using GUI.CustomerType;
using GUI.RoomType;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.ComponentModel;
using DevExpress.XtraTab;
using BUS;
using DTO;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ReLoadRoomData();
            this.ReLoadAvailableRoom();
            this.ReLoadFindRoom();
            this.ReLoadBillRoom();
            this.ReLoadRuleRoom();
            this.cbRevenueMonth.SelectedIndex = 0;
        }

        // Hide Room Rule Edit when access is not admin
        public void HideRoomRuleEdit()
        {
            this.tcHotelManagement.TabPages.Remove(tabRoomRules);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Owner;
            loginForm.Dispose();
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

        public RoomDTO GetSelectedRoom()
        {
            RoomDTO room = new RoomDTO();
            room.RoomID = this.tbListRoomID.Text;
            room.RoomTypeID = this.tbListRoomType.Text;
            room.RoomNote = this.rtbListRoomNote.Text;
            return room;
        }

        public void ReLoadRoomData()
        {
            this.dgvListRoom.DataSource = RoomBUS.GetRoomList();

            if (dgvListRoom.Rows.Count > 0)
            {
                this.btnDelRoom.Enabled = this.btnEditRoom.Enabled = true;
            }
            else
            {
                this.btnDelRoom.Enabled = this.btnEditRoom.Enabled = false;
                this.tbListRoomID.Text
                    = this.tbListRoomPrice.Text
                    = this.tbListRoomStatus.Text
                    = this.tbListRoomType.Text
                    = this.rtbListRoomNote.Text = null;
            }
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            if (RoomTypeBUS.GetRoomTypeList().Rows.Count > 0)
            {
                var RoomForm = new RoomForm();
                RoomForm.Tag = "AddForm";
                RoomForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Chưa có loại phòng!",
                    "THÊM PHÒNG THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnDelRoom_Click(object sender, EventArgs e)
        {
            var RoomID = tbListRoomID.Text;

            var dialogResult = MessageBox.Show(
                   "Bạn có muốn xoá phòng " + RoomID + "?",
                   "XÁC NHẬN XOÁ PHÒNG",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (RoomBUS.DeleteRoom(RoomID))
                {
                    MessageBox.Show(
                        "Xoá phòng " + RoomID + " thành công!",
                        "XOÁ PHÒNG THÀNH CÔNG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.ReLoadRoomData();
                    this.ReLoadAvailableRoom();
                    this.ReLoadFindRoom();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể xoá phòng đang thuê!",
                        "XOÁ PHÒNG THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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
            if (e.RowIndex >= 0)
            {
                var row = this.dgvListRoom.CurrentRow;
                tbListRoomID.Text = row.Cells["RoomID"].Value.ToString();
                tbListRoomType.Text = row.Cells["RoomType"].Value.ToString();
                tbListRoomPrice.Text = row.Cells["RoomPrice"].Value.ToString() + " VND";
                tbListRoomStatus.Text = row.Cells["RoomStatus"].Value.ToString();
                rtbListRoomNote.Text = row.Cells["RoomNote"].Value.ToString();
            }
        }

        // Tab 02: Room Lease
        public void ReLoadAvailableRoom()
        {
            this.cbLeaseRoomID.Items.Clear();
            this.deLeaseRoomDate.Text = DateTime.Now.ToString();

            var dt = RoomBUS.GetAvailableRoomList();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    this.cbLeaseRoomID.Items.Add(dr["MaPhong"]);
                }
                this.cbLeaseRoomID.SelectedIndex = 0;
            }
        }

        public void AddCustomer(RoomLeaseDetailDTO customer)
        {
            this.dgvLeaseCustomer.Rows.Add(
                customer.CustomerName,
                customer.CustomerTypeID,
                CustomerTypeBUS.GetCustomerTypeByID(customer.CustomerTypeID),
                customer.CustomerPassportID,
                customer.CustomerAddress);
        }

        public void EditCustomer(RoomLeaseDetailDTO customer)
        {
            this.dgvLeaseCustomer.CurrentRow.SetValues(
                customer.CustomerName,
                customer.CustomerTypeID,
                CustomerTypeBUS.GetCustomerTypeByID(customer.CustomerTypeID),
                customer.CustomerPassportID,
                customer.CustomerAddress);

            var row = this.dgvLeaseCustomer.CurrentRow;
            this.tbCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            this.tbCustomerPassport.Text = row.Cells["CustomerPassportID"].Value.ToString();
            this.tbCustomerType.Text = row.Cells["CustomerType"].Value.ToString();
            this.rtbCustomerAddress.Text = row.Cells["CustomerAddress"].Value.ToString();
        }

        public RoomLeaseDetailDTO GetSelectedCustomer()
        {
            var detail = new RoomLeaseDetailDTO();
            detail.CustomerName = tbCustomerName.Text;
            detail.CustomerPassportID = tbCustomerPassport.Text;
            detail.CustomerAddress = rtbCustomerAddress.Text;
            detail.CustomerTypeID = Convert.ToInt32(dgvLeaseCustomer.CurrentRow.Cells["CustomerTypeID"].Value);
            return detail;
        }

        public RoomLeaseDTO GetRoomLease()
        {
            var lease = new RoomLeaseDTO();
            lease.RoomID = cbLeaseRoomID.Text;
            lease.RoomTypeID = RoomTypeBUS.GetRoomTypeByID(lease.RoomID);
            lease.LeaseDate = DateTime.ParseExact(deLeaseRoomDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("d");
            lease.RoomPrice = Convert.ToInt64(tbLeaseRoomPrice.Text.Split()[0].Replace(",", ""));
            return lease;
        }

        public DataGridViewRowCollection GetAllRowsCustomerInNote() => this.dgvLeaseCustomer.Rows;

        private void LoadSelectedCustomer(DataGridViewRow row)
        {
        }

        private void CbNoteRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var price = RoomTypeBUS.GetRoomPriceByID(cbLeaseRoomID.Text);
            this.tbLeaseRoomPrice.Text = price.ToString("N0") + " VND";
        }

        private void BtnLockNoteRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cbLeaseRoomID.Text))
            {
                this.btnLockRoom.Enabled = false;
            }
            else if (this.cbLeaseRoomID.Items.Count == 0)
            {
                MessageBox.Show(
                    "Không còn phòng trống",
                    "KHÔNG CÒN PHÒNG TRỐNG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnLockNoteRoom_EnabledChanged(object sender, EventArgs e)
        {
            if (this.btnLockRoom.Enabled == true)
            {
                this.btnCancelLease.Enabled = false;
                this.btnAddCustomer.Enabled = false;
                this.btnDelCustomer.Enabled = false;
                this.btnEditCustomer.Enabled = false;
                this.cbLeaseRoomID.Enabled = true;
                this.deLeaseRoomDate.Enabled = true;
                this.gcLeaseCustomerData.Text = "DANH SÁCH KHÁCH";
                this.deLeaseRoomDate.Text = DateTime.Now.ToString();
                this.dgvLeaseCustomer.Rows.Clear();
            }
            else
            {
                this.btnAddCustomer.Enabled = true;
                this.cbLeaseRoomID.Enabled = false;
                this.deLeaseRoomDate.Enabled = false;
                this.btnCancelLease.Enabled = true;
                this.gcLeaseCustomerData.Text += " [PHÒNG: " + cbLeaseRoomID.Text + " - NGÀY THUÊ: " + deLeaseRoomDate.Text + "]";
            }
        }

        private void BtnAddLeaseCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerTypeBUS.GetCustomerTypeList().Rows.Count > 0)
            {
                if (this.dgvLeaseCustomer.Rows.Count == RoomBUS.GetMaxCustomerInRoom())
                {
                    MessageBox.Show(
                        "Số khách trong phòng đã đạt mức tối đa!",
                        "THÊM KHÁCH THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    var CustomerForm = new CustomerForm();
                    CustomerForm.Tag = "AddForm";
                    CustomerForm.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show(
                    "Chưa có loại khách!",
                    "THÊM KHÁCH THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BtnDelLeaseCustomer_Click(object sender, EventArgs e)
        {
            var customerName = dgvLeaseCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            var dialogResult = MessageBox.Show(
                "Bạn có muốn xoá khách \"" + customerName + "\"?",
                "XÁC NHẬN XOÁ KHÁCH",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Xoá khách \"" + customerName + "\" thành công!",
                    "XOÁ KHÁCH THÀNH CÔNG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.dgvLeaseCustomer.Rows.Remove(this.dgvLeaseCustomer.CurrentRow);
            }
        }


        private void BtnEditLeaseCustomer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomerForm();
            CustomerForm.Tag = "EditForm";
            CustomerForm.ShowDialog(this);
        }


        private void BtnCreateLease_Click(object sender, EventArgs e)
        {
            var RoomDetailForm = new RoomLeaseForm();
            RoomDetailForm.ShowDialog(this);
        }

        private void BtnCancelLease_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Bạn có muốn huỷ lập phiếu thuê phòng " + cbLeaseRoomID.Text + "?",
                "XÁC NHẬN HUỶ LẬP PHIẾU",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Huỷ lập phiếu thuê phòng " + cbLeaseRoomID.Text + " thành công",
                    "HUỶ PHIẾU THUÊ THÀNH CÔNG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.btnLockRoom.Enabled = true;
            }
        }

        public void ReCreateLease()
        {
            this.btnLockRoom.Enabled = true;
        }

        private void DgvLeaseCustomer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnDelCustomer.Enabled = true;
            this.btnEditCustomer.Enabled = true;
            this.btnCreateLease.Enabled = true;
            this.btnCancelLease.Enabled = true;
        }

        private void DgvLeaseCustomer_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvLeaseCustomer.Rows.Count == 0)
            {
                this.btnDelCustomer.Enabled = false;
                this.btnEditCustomer.Enabled = false;
                this.btnCreateLease.Enabled = false;
                this.tbCustomerName.Text = null;
                this.tbCustomerPassport.Text = null;
                this.tbCustomerType.Text = null;
                this.rtbCustomerAddress.Text = null;
            }
        }

        private void DgvLeaseCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.dgvLeaseCustomer.CurrentRow;
                this.tbCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                this.tbCustomerPassport.Text = row.Cells["CustomerPassportID"].Value.ToString();
                this.tbCustomerType.Text = row.Cells["CustomerType"].Value.ToString();
                this.rtbCustomerAddress.Text = row.Cells["CustomerAddress"].Value.ToString();
            }
        }

        private void DgvLeaseCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.LoadSelectedCustomer(dgvLeaseCustomer.CurrentRow);
            }
        }

        // Tab 03: Room Search
        public void ReLoadFindRoom()
        {
            DataTable dt = RoomBUS.GetRoomList();
            Dictionary<string, string> id = new Dictionary<string, string>()
            {
                {"Tất cả phòng", null}
            };

            foreach (DataRow dr in dt.Rows)
            {
                var key = dr["MaPhong"].ToString();
                var value = key;
                id.Add(key, value);
            }

            this.cbFindRoomID.DataSource = new BindingSource(id, null);
            this.cbFindRoomID.DisplayMember = "Key";
            this.cbFindRoomID.ValueMember = "Value";

            dt = RoomTypeBUS.GetRoomTypeList();
            Dictionary<string, string> type = new Dictionary<string, string>()
            {
                {"Tất cả loại phòng", null}
            };

            foreach (DataRow dr in dt.Rows)
            {
                var key = dr["MaLoaiPhong"].ToString();
                var value = key;
                type.Add(key, value);
            }

            this.cbFindRoomType.DataSource = new BindingSource(type, null);
            this.cbFindRoomType.DisplayMember = "Key";
            this.cbFindRoomType.ValueMember = "Value";

            dt = RoomTypeBUS.GetRoomPriceList();
            Dictionary<string, Int64> price = new Dictionary<string, Int64>()
            {
                {"Tất cả đơn giá", -1}
            };

            foreach (DataRow dr in dt.Rows)
            {
                var key = Convert.ToInt64(dr["DonGia"]).ToString("N0") + " VND";
                var value = Int64.Parse(key.Split()[0].Replace(",", ""));
                price.Add(key, value);
            }

            this.cbFindRoomPrice.DataSource = new BindingSource(price, null);
            this.cbFindRoomPrice.DisplayMember = "Key";
            this.cbFindRoomPrice.ValueMember = "Value";

            dt = RoomStatusBUS.GetRoomStatusList();
            Dictionary<string, string> status = new Dictionary<string, string>()
            {
                {"Tất cả tình trạng", null}
            };

            foreach (DataRow dr in dt.Rows)
            {
                var key = dr["TenTinhTrang"].ToString();
                var value = dr["MaTinhTrang"].ToString();
                status.Add(key, value);
            }

            this.cbFindRoomStatus.DataSource = new BindingSource(status, null);
            this.cbFindRoomStatus.DisplayMember = "Key";
            this.cbFindRoomStatus.ValueMember = "Value";
        }

        private void CbFindRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var RoomType = cbFindRoomType.Text;
                if (RoomType != "Tất cả loại phòng")
                {
                    this.cbFindRoomPrice.Text = RoomTypeBUS.GetRoomPriceByType(RoomType).ToString("N0") + " VND";
                }
                else this.cbFindRoomPrice.Text = "Tất cả đơn giá";
            }
            catch (Exception) { }
        }

        private void BtnFindRoom_Click(object sender, EventArgs e)
        {
            this.dgvFindRoom.DataSource = RoomBUS.FindRoom(
                ((KeyValuePair<string, string>)cbFindRoomID.SelectedItem).Value,
                ((KeyValuePair<string, string>)cbFindRoomType.SelectedItem).Value,
                ((KeyValuePair<string, Int64>)cbFindRoomPrice.SelectedItem).Value,
                ((KeyValuePair<string, string>)cbFindRoomStatus.SelectedItem).Value);

            if (this.dgvFindRoom.Rows.Count == 0)
            {
                this.tbFindRoomID.Text
                = this.tbFindRoomType.Text
                = this.tbFindRoomPrice.Text
                = this.tbFindRoomStatus.Text
                = this.rtbFindRoomNote.Text = null;

                MessageBox.Show("Không tìm thấy phòng phù hợp!",
                    "KHÔNG TÌM THẤY KẾT QUẢ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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

        private void DgvFoundRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var curRow = this.dgvFindRoom.CurrentRow;
                this.tbFindRoomID.Text = curRow.Cells["FindRoomID"].Value.ToString();
                this.tbFindRoomType.Text = curRow.Cells["FindRoomType"].Value.ToString();
                this.tbFindRoomPrice.Text = curRow.Cells["FindRoomPrice"].Value.ToString() + " VND";
                this.tbFindRoomStatus.Text = curRow.Cells["FindRoomStatus"].Value.ToString();
                this.rtbFindRoomNote.Text = curRow.Cells["FindRoomNote"].Value.ToString();
            }
        }

        // Tab 04: Room Bill
        void ReLoadBillRoom()
        {
            this.deBillDate.Text = DateTime.Now.ToString();
        }

        void LoadRentRoom()
        {
            var BillDate = DateTime.ParseExact(deBillDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
            var dt = RoomLeaseBUS.GetRentedRoomList(BillDate.ToString("d"));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không có phòng nào được thuê trước ngày " + deBillDate.Text,
                    "KHÔNG CÓ PHÒNG ĐANG THUÊ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    this.cbAddBillRoomID.Items.Add(row["MaPhong"]);
                }
                this.cbAddBillRoomID.SelectedIndex = 0;
                this.btnLockBill.Enabled = false;
            }
        }

        public void ReCreateBill()
        {
            this.btnLockBill.Enabled = true;
        }

        public RoomBillDTO GetBillPayer()
        {
            var bill = new RoomBillDTO();
            bill.CustomerName = this.tbBillCustomerName.Text;
            bill.CustomerAddress = this.rtbBillCustomerAddress.Text;
            bill.BillDate = DateTime.ParseExact(this.deBillDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("M/d/yyyy");
            return bill;
        }

        public DataGridViewRowCollection GetAllPaidRoomInBill() => this.dgvBillRoom.Rows;

        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void DgvBillRoom_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Xoá phòng vừa chọn trong danh sách phòng cần thanh toán
            this.cbAddBillRoomID.Items.Remove(cbAddBillRoomID.SelectedItem);
            this.dgvBillRoom.Sort(this.dgvBillRoom.Columns["PaidRoomID"], ListSortDirection.Ascending);
            this.btnCreateBillRoom.Enabled = true;
            this.btnDelBillRoom.Enabled = true;

            if (this.cbAddBillRoomID.Items.Count == 0)
            {
                this.btnAddBillRoom.Enabled = false;
                MessageBox.Show(
                    "Không còn phòng thanh toán",
                    "KHÔNG CÒN PHÒNG THANH TOÁN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this.cbAddBillRoomID.SelectedIndex = 0;
            }
        }

        private void DgvBillRoom_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btnAddBillRoom.Enabled = true;

            if (this.dgvBillRoom.Rows.Count == 0)
            {
                this.tbBillRoomID.Text
                = this.tbBillRoomPrice.Text
                = this.tbBillRoomDay.Text
                = this.tbBillRoomCost.Text = null;

                this.btnCreateBillRoom.Enabled = false;
                this.btnDelBillRoom.Enabled = false;
            }
        }

        private void BtnLockBill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbBillCustomerName.Text) && !string.IsNullOrEmpty(this.rtbBillCustomerAddress.Text))
            {
                this.LoadRentRoom();
            }
            else
            {
                MessageBox.Show(
                    "Thông tin khách thanh toán không được để trống",
                    "LẬP HOÁ ĐƠN THẤT BẠI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnLockBill_EnabledChanged(object sender, EventArgs e)
        {
            if (this.btnLockBill.Enabled == true)
            {
                this.tbBillCustomerName.Text = null;
                this.rtbBillCustomerAddress.Text = null;
                this.cbAddBillRoomID.Text = null;
                this.cbAddBillRoomID.Items.Clear();
                this.dgvBillRoom.Rows.Clear();
                this.deBillDate.Text = DateTime.Now.ToString();
            }

            this.tbBillCustomerName.Enabled
            = this.deBillDate.Enabled
            = this.rtbBillCustomerAddress.Enabled
            = this.btnLockBill.Enabled;

            this.btnAddBillRoom.Enabled
            = this.btnCancelBillRoom.Enabled
            = this.cbAddBillRoomID.Enabled = !this.btnLockBill.Enabled;
        }

        private void DgvBillRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.dgvBillRoom.CurrentRow;
                this.tbBillRoomID.Text = row.Cells["PaidRoomID"].Value.ToString();
                this.tbBillRoomDay.Text = row.Cells["PaidRoomRentDays"].Value.ToString();
                this.tbBillRoomPrice.Text = row.Cells["PaidRoomPrice"].Value.ToString() + " VND";
                this.tbBillRoomCost.Text = row.Cells["PaidRoomTotalPrice"].Value.ToString() + " VND";
            }
        }

        private void BtnDelBillRoom_Click(object sender, EventArgs e)
        {
            var RoomID = this.tbBillRoomID.Text;

            var dialogResult = MessageBox.Show(
                "Bạn có muốn xoá thanh toán phòng " + RoomID + "?",
                "XÁC NHẬN HUỶ THANH TOÁN PHÒNG",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.dgvBillRoom.Rows.Remove(this.dgvBillRoom.CurrentRow);
                this.cbAddBillRoomID.Items.Add(RoomID);
                this.cbAddBillRoomID.SelectedIndex = 0;
            }
        }


        private void BtnAddBillRoom_Click(object sender, EventArgs e)
        {
            // Thêm chi tiết thanh toán của phòng đã chọn vào DataGrid
            var BillDate = DateTime.ParseExact(deBillDate.Text, "d/M/yyyy", CultureInfo.InvariantCulture).ToString("d");
            var dr = RoomBillBUS.GetLeasePayment(this.cbAddBillRoomID.Text, BillDate).Rows[0];
            this.dgvBillRoom.Rows.Add(
                dr["MaPhong"],
                dr["SoNgayThue"],
                Convert.ToInt64(dr["DonGia"]).ToString("N0"),
                Convert.ToInt64(dr["PhuThuKhachThem"]).ToString("N0"),
                Convert.ToInt64(dr["PhuThuKhachNuocNgoai"]).ToString("N0"),
                Convert.ToInt64(dr["ThanhTien"]).ToString("N0"));
        }


        private void BtnCreateBillRoom_Click(object sender, EventArgs e)
        {
            var DetailForm = new BillDetailForm();
            DetailForm.ShowDialog(this);
        }


        private void BtnCancelBillRoom_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Bạn có muốn huỷ hoá đơn thanh toán?",
                "XÁC NHẬN HUỶ HOÁ ĐƠN",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.btnLockBill.Enabled = true;
            }
        }

        //Tab 05: Room-Revenue Report

        private void BtnCreateMonthRevenue_Click(object sender, EventArgs e)
        {
            this.dgvRevenueList.Rows.Clear();
            var dt = RoomBillBUS.GetMonthRevenueReport(Convert.ToInt16(this.cbRevenueMonth.SelectedItem.ToString()));

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    this.dgvRevenueList.Rows.Add
                        (dr["LoaiPhong"].ToString(),
                        Convert.ToInt64(dr["DoanhThu"]).ToString("N0"),
                        String.Format("{0:0.00}", dr["TiLe"]));
                }
            }
            else
            {
                MessageBox.Show("Không có doanh thu trong tháng " + this.cbRevenueMonth.SelectedItem.ToString(),
                    "KHÔNG CÓ DOANH THU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //Tab 06: Room-Rule Edit
        private void ReLoadRuleRoom()
        {
            this.lbMaxCustomerValue.Text = RoomBUS.GetMaxCustomerInRoom().ToString();
            this.lbAdditionalCustomerSurchargeValue.Text = RoomLeaseBUS.GetOverCustomerTaxPercent().ToString() + "%";
            this.lbForeignCustomerSurchargeValue.Text = RoomLeaseBUS.GetForeignCustomerTaxPercent().ToString() + "%";
            this.dgvCustomerType.DataSource = CustomerTypeBUS.GetCustomerTypeList();

            var dt = RoomTypeBUS.GetRoomTypeList();
            foreach (DataRow dr in dt.Rows)
            {
                this.dgvRoomType.Rows.Add
                    (dr["MaLoaiPhong"].ToString(),
                    Convert.ToInt64(dr["DonGia"]).ToString("N0"));
            }
        }

        public void ReLoadMaxCustomerInRoom()
        {
            this.lbMaxCustomerValue.Text = RoomBUS.GetMaxCustomerInRoom().ToString();
        }

        public void ReLoadOverCustomerTax()
        {
            this.lbAdditionalCustomerSurchargeValue.Text = RoomLeaseBUS.GetOverCustomerTaxPercent().ToString() + "%";
        }

        public void ReLoadForeignCustomerTax()
        {
            this.lbForeignCustomerSurchargeValue.Text = RoomLeaseBUS.GetForeignCustomerTaxPercent().ToString() + "%";
        }

        public void ReLoadRoomTypeList()
        {
            this.dgvRoomType.Rows.Clear();
            var dt = RoomTypeBUS.GetRoomTypeList();
            foreach (DataRow dr in dt.Rows)
            {
                this.dgvRoomType.Rows.Add
                    (dr["MaLoaiPhong"].ToString(),
                    Convert.ToInt64(dr["DonGia"]).ToString("N0"));
            }

            if (dt.Rows.Count > 0)
            {
                this.btnDelRoomType.Enabled = this.btnEditRoomType.Enabled = true;
            }
            else
            {
                this.btnDelRoomType.Enabled = this.btnEditRoomType.Enabled = false;
            }
        }

        public void ReLoadCustomerTypeList()
        {
            this.dgvCustomerType.DataSource = CustomerTypeBUS.GetCustomerTypeList();

            if (dgvCustomerType.Rows.Count > 0)
            {
                this.btnDelCustomerType.Enabled = this.btnEditCustomerType.Enabled = true;
            }
            else
            {
                this.btnDelCustomerType.Enabled = this.btnEditCustomerType.Enabled = false;
            }
        }

        private void BtnEditMaxCustomerRule_Click(object sender, EventArgs e)
        {
            var EditForm = new MaxCustomerEditForm();
            EditForm.ShowDialog(this);
        }

        private void BtnEditThirdCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new OverCustomerTaxEditForm();
            EditForm.ShowDialog(this);
        }

        private void BtnEditForeignCustomerTax_Click(object sender, EventArgs e)
        {
            var EditForm = new ForeignCustomerEditForm();
            EditForm.ShowDialog(this);
        }

        public RoomTypeDTO GetSelectedRoomType()
        {
            var row = this.dgvRoomType.CurrentRow;
            var roomType = new RoomTypeDTO();
            roomType.RoomTypeID = row.Cells["EditRoomTypeID"].Value.ToString();
            roomType.RoomTypePrice = Convert.ToInt64(row.Cells["EditRoomTypePrice"].Value.ToString().Replace(",", ""));
            return roomType;
        }

        public string GetSelectedCustomerType()
        {
            return this.dgvCustomerType.CurrentRow.Cells["EditCustomerTypeName"].Value.ToString();
        }

        private void BtnAddRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeForm = new RoomTypeForm();
            RoomTypeForm.Tag = "AddForm";
            RoomTypeForm.ShowDialog(this);
        }

        private void BtnDelRoomType_Click(object sender, EventArgs e)
        {
            var RoomTypeID = this.dgvRoomType.CurrentRow.Cells["EditRoomTypeID"].Value.ToString();

            var dialogResult = MessageBox.Show(
                  "Bạn có muốn xoá loại phòng " + RoomTypeID + "?",
                  "XÁC NHẬN XOÁ LOẠI PHÒNG",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (RoomTypeBUS.CountRoomWithType(RoomTypeID) > 0)
                {
                    MessageBox.Show(
                       "Vẫn còn phòng loại " + RoomTypeID + "!\n" +
                       "Xoá loại phòng thất bại!",
                       "XOÁ LOẠI PHÒNG THẤT BẠI",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    return;
                }

                if (RoomTypeBUS.DeleteRoomType(RoomTypeID))
                {
                    MessageBox.Show(
                        "Xoá loại phòng " + RoomTypeID + " thành công!",
                        "XOÁ LOẠI PHÒNG THÀNH CÔNG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.ReLoadRoomTypeList();
                }
                else
                {
                    MessageBox.Show(
                        "XOÁ LOẠI PHÒNG THẤT BẠI!",
                        "XOÁ LOẠI PHÒNG THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
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
            var row = this.dgvCustomerType.CurrentRow;
            var customerType = row.Cells["EditCustomerTypeName"].Value.ToString();

            if (customerType == "Nước ngoài")
            {
                MessageBox.Show(
                        "Không thể xoá loại khách 'Nước ngoài'!",
                        "XOÁ LOẠI KHÁCH THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                  "Bạn có muốn xoá loại khách '" + customerType + "'?",
                  "XÁC NHẬN XOÁ LOẠI KHÁCH KHÁCH",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (CustomerTypeBUS.DeleteCustomerType(customerType))
                {
                    MessageBox.Show(
                        "Xoá loại khách " + customerType + " thành công!",
                        "XOÁ LOẠI PHÒNG THÀNH CÔNG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.ReLoadCustomerTypeList();
                }
                else
                {
                    MessageBox.Show(
                        "XOÁ LOẠI KHÁCH THẤT BẠI!",
                        "XOÁ LOẠI KHÁCH THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnEditCustomerType_Click(object sender, EventArgs e)
        {
            var row = this.dgvCustomerType.CurrentRow;
            var customerType = row.Cells["EditCustomerTypeName"].Value.ToString();
            if (customerType == "Nước ngoài")
            {
                MessageBox.Show(
                        "Không thể sửa loại khách 'Nước ngoài'!",
                        "SỬA LOẠI KHÁCH THẤT BẠI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            var EditForm = new CustomerTypeEditForm();
            EditForm.ShowDialog(this);
        }

        // Các quy định khi chuyển tab
        private void TcHotelManagement_SelectedPageChanging(object sender, TabPageChangingEventArgs e)
        {
            switch (this.tcHotelManagement.SelectedTabPage.Name)
            {
                // Khi đang lập phiếu thuê phòng
                case "tabRoomLease":
                    {
                        if (this.btnLockRoom.Enabled == false)
                        {
                            var dialogResult = MessageBox.Show(
                                "Bạn có muốn dừng lập phiếu thuê phòng?\n" +
                                "Các thông tin lập phiếu hiện tại sẽ bị xoá!",
                                "NGƯNG LẬP PHIẾU THUÊ PHÒNG",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                this.btnLockRoom.Enabled = true;
                            }
                            else
                            {
                                e.Cancel = true;
                            }
                        }
                        break;
                    }

                // Khi đang tìm kiếm phòng
                case "tabRoomFind":
                    {
                        if (this.dgvFindRoom.Rows.Count > 0)
                        {
                            var dialogResult = MessageBox.Show(
                                "Bạn có muốn dừng tìm kiếm phòng?\n" +
                                "Các thông tin tìm kiếm hiện tại sẽ bị xoá!",
                                "NGƯNG TÌM KIẾM PHÒNG",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                var dt = this.dgvFindRoom.DataSource as DataTable;
                                dt.Rows.Clear();
                                this.dgvFindRoom.DataSource = dt;

                                this.cbFindRoomID.SelectedIndex
                                    = this.cbFindRoomPrice.SelectedIndex
                                    = this.cbFindRoomStatus.SelectedIndex
                                    = this.cbFindRoomType.SelectedIndex = 0;

                                this.tbFindRoomID.Text
                                    = this.tbFindRoomPrice.Text
                                    = this.tbFindRoomStatus.Text
                                    = this.tbFindRoomType.Text = null;
                            }
                        }
                        break;
                    }

                // Khi đang tìm lập hoá đơn thanh toán
                case "tabRoomBill":
                    {
                        if (this.btnLockBill.Enabled == false)
                        {
                            var dialogResult = MessageBox.Show(
                                "Bạn có muốn dừng lập hoá đơn thanh toán?\n" +
                                "Các thông tin hoá đơn hiện tại sẽ bị xoá!",
                                "NGƯNG LẬP HOÁ ĐƠN",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                this.btnLockBill.Enabled = true;
                            }
                            else
                            {
                                e.Cancel = true;
                            }
                        }
                        break;
                    }
            }
        }
    }
}