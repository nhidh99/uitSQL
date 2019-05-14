namespace Hotel_Management.Bill
{
    partial class BillDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetailForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTaxDetail = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBillDate = new System.Windows.Forms.TextBox();
            this.tbBillAddress = new System.Windows.Forms.TextBox();
            this.tbBillCustomer = new System.Windows.Forms.TextBox();
            this.lbBillDate = new DevExpress.XtraEditors.LabelControl();
            this.lbBillAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCustomer = new DevExpress.XtraEditors.LabelControl();
            this.imgRoomBill = new DevExpress.XtraEditors.LabelControl();
            this.lbBillHeader = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcBillData = new DevExpress.XtraEditors.GroupControl();
            this.dgvBillData = new System.Windows.Forms.DataGridView();
            this.PaidRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomRentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTaxCurrency = new DevExpress.XtraEditors.LabelControl();
            this.tbBillTax = new System.Windows.Forms.TextBox();
            this.lbBillTax = new DevExpress.XtraEditors.LabelControl();
            this.tbBillID = new System.Windows.Forms.TextBox();
            this.lbBillID = new DevExpress.XtraEditors.LabelControl();
            this.lbChangeCurrency = new DevExpress.XtraEditors.LabelControl();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.lbChange = new DevExpress.XtraEditors.LabelControl();
            this.lbReceivedMoneyCurrency = new DevExpress.XtraEditors.LabelControl();
            this.tbReceivedMoney = new System.Windows.Forms.TextBox();
            this.lbReceivedMoney = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCostCurrency = new DevExpress.XtraEditors.LabelControl();
            this.tbBillCost = new System.Windows.Forms.TextBox();
            this.lbBillCost = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillData)).BeginInit();
            this.gcBillData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(264, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 45);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTaxDetail);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 45);
            this.panel5.TabIndex = 6;
            // 
            // btnTaxDetail
            // 
            this.btnTaxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaxDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaxDetail.ImageOptions.Image")));
            this.btnTaxDetail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTaxDetail.Location = new System.Drawing.Point(0, 0);
            this.btnTaxDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaxDetail.Name = "btnTaxDetail";
            this.btnTaxDetail.Size = new System.Drawing.Size(255, 45);
            this.btnTaxDetail.TabIndex = 27;
            this.btnTaxDetail.Text = "CHI TIẾT PHỤ THU";
            this.btnTaxDetail.Click += new System.EventHandler(this.BtnTaxDetail_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.tbBillDate);
            this.panel2.Controls.Add(this.tbBillAddress);
            this.panel2.Controls.Add(this.tbBillCustomer);
            this.panel2.Controls.Add(this.lbBillDate);
            this.panel2.Controls.Add(this.lbBillAddress);
            this.panel2.Controls.Add(this.lbBillCustomer);
            this.panel2.Controls.Add(this.imgRoomBill);
            this.panel2.Controls.Add(this.lbBillHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 168);
            this.panel2.TabIndex = 1;
            // 
            // tbBillDate
            // 
            this.tbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillDate.Location = new System.Drawing.Point(261, 61);
            this.tbBillDate.Name = "tbBillDate";
            this.tbBillDate.ReadOnly = true;
            this.tbBillDate.Size = new System.Drawing.Size(117, 20);
            this.tbBillDate.TabIndex = 41;
            // 
            // tbBillAddress
            // 
            this.tbBillAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillAddress.Location = new System.Drawing.Point(261, 127);
            this.tbBillAddress.Name = "tbBillAddress";
            this.tbBillAddress.ReadOnly = true;
            this.tbBillAddress.Size = new System.Drawing.Size(360, 20);
            this.tbBillAddress.TabIndex = 42;
            // 
            // tbBillCustomer
            // 
            this.tbBillCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillCustomer.Location = new System.Drawing.Point(261, 92);
            this.tbBillCustomer.Name = "tbBillCustomer";
            this.tbBillCustomer.ReadOnly = true;
            this.tbBillCustomer.Size = new System.Drawing.Size(360, 20);
            this.tbBillCustomer.TabIndex = 43;
            // 
            // lbBillDate
            // 
            this.lbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillDate.Appearance.Options.UseFont = true;
            this.lbBillDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillDate.Location = new System.Drawing.Point(148, 64);
            this.lbBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(99, 13);
            this.lbBillDate.TabIndex = 40;
            this.lbBillDate.Text = "NGÀY THANH TOÁN:";
            // 
            // lbBillAddress
            // 
            this.lbBillAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillAddress.Appearance.Options.UseFont = true;
            this.lbBillAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillAddress.Location = new System.Drawing.Point(199, 130);
            this.lbBillAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillAddress.Name = "lbBillAddress";
            this.lbBillAddress.Size = new System.Drawing.Size(44, 13);
            this.lbBillAddress.TabIndex = 39;
            this.lbBillAddress.Text = "ĐỊA CHỈ:";
            // 
            // lbBillCustomer
            // 
            this.lbBillCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomer.Appearance.Options.UseFont = true;
            this.lbBillCustomer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomer.Location = new System.Drawing.Point(158, 95);
            this.lbBillCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomer.Name = "lbBillCustomer";
            this.lbBillCustomer.Size = new System.Drawing.Size(89, 13);
            this.lbBillCustomer.TabIndex = 38;
            this.lbBillCustomer.Text = "KHÁCH/CƠ QUAN:";
            // 
            // imgRoomBill
            // 
            this.imgRoomBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgRoomBill.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgRoomBill.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomBill.Appearance.Image")));
            this.imgRoomBill.Appearance.Options.UseFont = true;
            this.imgRoomBill.Appearance.Options.UseImage = true;
            this.imgRoomBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomBill.ImageOptions.Image")));
            this.imgRoomBill.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgRoomBill.Location = new System.Drawing.Point(201, 16);
            this.imgRoomBill.Margin = new System.Windows.Forms.Padding(2);
            this.imgRoomBill.Name = "imgRoomBill";
            this.imgRoomBill.Size = new System.Drawing.Size(32, 32);
            this.imgRoomBill.TabIndex = 36;
            // 
            // lbBillHeader
            // 
            this.lbBillHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbBillHeader.Appearance.Options.UseFont = true;
            this.lbBillHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillHeader.Location = new System.Drawing.Point(247, 17);
            this.lbBillHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbBillHeader.Name = "lbBillHeader";
            this.lbBillHeader.Size = new System.Drawing.Size(332, 24);
            this.lbBillHeader.TabIndex = 35;
            this.lbBillHeader.Text = "CHI TIẾT HOÁ ĐƠN THANH TOÁN";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.gcBillData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 210);
            this.panel1.TabIndex = 0;
            // 
            // gcBillData
            // 
            this.gcBillData.Controls.Add(this.dgvBillData);
            this.gcBillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillData.Location = new System.Drawing.Point(0, 0);
            this.gcBillData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBillData.Name = "gcBillData";
            this.gcBillData.Size = new System.Drawing.Size(516, 210);
            this.gcBillData.TabIndex = 2;
            this.gcBillData.Text = "DANH MỤC THANH TOÁN";
            // 
            // dgvBillData
            // 
            this.dgvBillData.AllowUserToAddRows = false;
            this.dgvBillData.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaidRoomID,
            this.PaidRoomRentDays,
            this.PaidRoomPrice,
            this.PaidRoomTotalPrice});
            this.dgvBillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillData.Location = new System.Drawing.Point(2, 20);
            this.dgvBillData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillData.MultiSelect = false;
            this.dgvBillData.Name = "dgvBillData";
            this.dgvBillData.ReadOnly = true;
            this.dgvBillData.RowTemplate.Height = 24;
            this.dgvBillData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillData.Size = new System.Drawing.Size(512, 188);
            this.dgvBillData.TabIndex = 2;
            // 
            // PaidRoomID
            // 
            this.PaidRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PaidRoomID.HeaderText = "PHÒNG";
            this.PaidRoomID.Name = "PaidRoomID";
            this.PaidRoomID.ReadOnly = true;
            this.PaidRoomID.Width = 67;
            // 
            // PaidRoomRentDays
            // 
            this.PaidRoomRentDays.HeaderText = "SỐ NGÀY THUÊ";
            this.PaidRoomRentDays.Name = "PaidRoomRentDays";
            this.PaidRoomRentDays.ReadOnly = true;
            this.PaidRoomRentDays.Width = 110;
            // 
            // PaidRoomPrice
            // 
            this.PaidRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.PaidRoomPrice.Name = "PaidRoomPrice";
            this.PaidRoomPrice.ReadOnly = true;
            // 
            // PaidRoomTotalPrice
            // 
            this.PaidRoomTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomTotalPrice.HeaderText = "THÀNH TIỀN (VND)";
            this.PaidRoomTotalPrice.Name = "PaidRoomTotalPrice";
            this.PaidRoomTotalPrice.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(255, 45);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "HUỶ BỎ";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 45);
            this.panel4.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.61153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.38847F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 441);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(525, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 210);
            this.panel6.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTaxCurrency);
            this.groupControl1.Controls.Add(this.tbBillTax);
            this.groupControl1.Controls.Add(this.lbBillTax);
            this.groupControl1.Controls.Add(this.tbBillID);
            this.groupControl1.Controls.Add(this.lbBillID);
            this.groupControl1.Controls.Add(this.lbChangeCurrency);
            this.groupControl1.Controls.Add(this.tbChange);
            this.groupControl1.Controls.Add(this.lbChange);
            this.groupControl1.Controls.Add(this.lbReceivedMoneyCurrency);
            this.groupControl1.Controls.Add(this.tbReceivedMoney);
            this.groupControl1.Controls.Add(this.lbReceivedMoney);
            this.groupControl1.Controls.Add(this.lbBillCostCurrency);
            this.groupControl1.Controls.Add(this.tbBillCost);
            this.groupControl1.Controls.Add(this.lbBillCost);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(256, 210);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "THANH TOÁN HOÁ ĐƠN";
            // 
            // lbTaxCurrency
            // 
            this.lbTaxCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTaxCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbTaxCurrency.Appearance.Options.UseFont = true;
            this.lbTaxCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbTaxCurrency.Location = new System.Drawing.Point(212, 74);
            this.lbTaxCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTaxCurrency.Name = "lbTaxCurrency";
            this.lbTaxCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbTaxCurrency.TabIndex = 56;
            this.lbTaxCurrency.Text = "(VND)";
            // 
            // tbBillTax
            // 
            this.tbBillTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillTax.Location = new System.Drawing.Point(93, 71);
            this.tbBillTax.Name = "tbBillTax";
            this.tbBillTax.ReadOnly = true;
            this.tbBillTax.Size = new System.Drawing.Size(113, 21);
            this.tbBillTax.TabIndex = 55;
            // 
            // lbBillTax
            // 
            this.lbBillTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillTax.Appearance.Options.UseFont = true;
            this.lbBillTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillTax.Location = new System.Drawing.Point(40, 74);
            this.lbBillTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillTax.Name = "lbBillTax";
            this.lbBillTax.Size = new System.Drawing.Size(47, 13);
            this.lbBillTax.TabIndex = 54;
            this.lbBillTax.Text = "PHỤ THU:";
            // 
            // tbBillID
            // 
            this.tbBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillID.Location = new System.Drawing.Point(93, 38);
            this.tbBillID.Name = "tbBillID";
            this.tbBillID.ReadOnly = true;
            this.tbBillID.Size = new System.Drawing.Size(113, 21);
            this.tbBillID.TabIndex = 46;
            // 
            // lbBillID
            // 
            this.lbBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillID.Appearance.Options.UseFont = true;
            this.lbBillID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillID.Location = new System.Drawing.Point(17, 41);
            this.lbBillID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(70, 13);
            this.lbBillID.TabIndex = 45;
            this.lbBillID.Text = "MÃ HOÁ ĐƠN:";
            // 
            // lbChangeCurrency
            // 
            this.lbChangeCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChangeCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbChangeCurrency.Appearance.Options.UseFont = true;
            this.lbChangeCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbChangeCurrency.Location = new System.Drawing.Point(212, 176);
            this.lbChangeCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbChangeCurrency.Name = "lbChangeCurrency";
            this.lbChangeCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbChangeCurrency.TabIndex = 53;
            this.lbChangeCurrency.Text = "(VND)";
            // 
            // tbChange
            // 
            this.tbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbChange.Location = new System.Drawing.Point(93, 170);
            this.tbChange.Name = "tbChange";
            this.tbChange.ReadOnly = true;
            this.tbChange.Size = new System.Drawing.Size(113, 21);
            this.tbChange.TabIndex = 52;
            // 
            // lbChange
            // 
            this.lbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChange.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbChange.Appearance.Options.UseFont = true;
            this.lbChange.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbChange.Location = new System.Drawing.Point(29, 176);
            this.lbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(58, 13);
            this.lbChange.TabIndex = 51;
            this.lbChange.Text = "TIỀN THỪA:";
            // 
            // lbReceivedMoneyCurrency
            // 
            this.lbReceivedMoneyCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceivedMoneyCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbReceivedMoneyCurrency.Appearance.Options.UseFont = true;
            this.lbReceivedMoneyCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbReceivedMoneyCurrency.Location = new System.Drawing.Point(212, 140);
            this.lbReceivedMoneyCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReceivedMoneyCurrency.Name = "lbReceivedMoneyCurrency";
            this.lbReceivedMoneyCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbReceivedMoneyCurrency.TabIndex = 50;
            this.lbReceivedMoneyCurrency.Text = "(VND)";
            // 
            // tbReceivedMoney
            // 
            this.tbReceivedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReceivedMoney.Location = new System.Drawing.Point(93, 137);
            this.tbReceivedMoney.Name = "tbReceivedMoney";
            this.tbReceivedMoney.Size = new System.Drawing.Size(113, 21);
            this.tbReceivedMoney.TabIndex = 49;
            // 
            // lbReceivedMoney
            // 
            this.lbReceivedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceivedMoney.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbReceivedMoney.Appearance.Options.UseFont = true;
            this.lbReceivedMoney.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbReceivedMoney.Location = new System.Drawing.Point(29, 140);
            this.lbReceivedMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReceivedMoney.Name = "lbReceivedMoney";
            this.lbReceivedMoney.Size = new System.Drawing.Size(58, 13);
            this.lbReceivedMoney.TabIndex = 48;
            this.lbReceivedMoney.Text = "TIỀN NHẬN:";
            // 
            // lbBillCostCurrency
            // 
            this.lbBillCostCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCostCurrency.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCostCurrency.Appearance.Options.UseFont = true;
            this.lbBillCostCurrency.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCostCurrency.Location = new System.Drawing.Point(212, 107);
            this.lbBillCostCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCostCurrency.Name = "lbBillCostCurrency";
            this.lbBillCostCurrency.Size = new System.Drawing.Size(28, 13);
            this.lbBillCostCurrency.TabIndex = 47;
            this.lbBillCostCurrency.Text = "(VND)";
            // 
            // tbBillCost
            // 
            this.tbBillCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillCost.Location = new System.Drawing.Point(93, 104);
            this.tbBillCost.Name = "tbBillCost";
            this.tbBillCost.ReadOnly = true;
            this.tbBillCost.Size = new System.Drawing.Size(113, 21);
            this.tbBillCost.TabIndex = 46;
            // 
            // lbBillCost
            // 
            this.lbBillCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCost.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCost.Appearance.Options.UseFont = true;
            this.lbBillCost.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCost.Location = new System.Drawing.Point(45, 106);
            this.lbBillCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCost.Name = "lbBillCost";
            this.lbBillCost.Size = new System.Drawing.Size(42, 13);
            this.lbBillCost.TabIndex = 45;
            this.lbBillCost.Text = "GIÁ TRỊ:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCreate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(525, 393);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(256, 45);
            this.panel7.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(256, 45);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "THANH TOÁN HOÁ ĐƠN";
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "BillDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT HOÁ ĐƠN THANH TOÁN";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBillData)).EndInit();
            this.gcBillData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBillDate;
        private System.Windows.Forms.TextBox tbBillAddress;
        private System.Windows.Forms.TextBox tbBillCustomer;
        private DevExpress.XtraEditors.LabelControl lbBillDate;
        private DevExpress.XtraEditors.LabelControl lbBillAddress;
        private DevExpress.XtraEditors.LabelControl lbBillCustomer;
        private DevExpress.XtraEditors.LabelControl imgRoomBill;
        private DevExpress.XtraEditors.LabelControl lbBillHeader;
        private DevExpress.XtraEditors.GroupControl gcBillData;
        private System.Windows.Forms.DataGridView dgvBillData;
        private DevExpress.XtraEditors.SimpleButton btnTaxDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomRentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomTotalPrice;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbTaxCurrency;
        private System.Windows.Forms.TextBox tbBillTax;
        private DevExpress.XtraEditors.LabelControl lbBillTax;
        private System.Windows.Forms.TextBox tbBillID;
        private DevExpress.XtraEditors.LabelControl lbBillID;
        private DevExpress.XtraEditors.LabelControl lbChangeCurrency;
        private System.Windows.Forms.TextBox tbChange;
        private DevExpress.XtraEditors.LabelControl lbChange;
        private DevExpress.XtraEditors.LabelControl lbReceivedMoneyCurrency;
        private System.Windows.Forms.TextBox tbReceivedMoney;
        private DevExpress.XtraEditors.LabelControl lbReceivedMoney;
        private DevExpress.XtraEditors.LabelControl lbBillCostCurrency;
        private System.Windows.Forms.TextBox tbBillCost;
        private DevExpress.XtraEditors.LabelControl lbBillCost;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}