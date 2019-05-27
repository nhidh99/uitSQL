namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcHotelManagement = new DevExpress.XtraTab.XtraTabControl();
            this.tabListRoom = new DevExpress.XtraTab.XtraTabPage();
            this.tlpListRoom = new System.Windows.Forms.TableLayoutPanel();
            this.gcRoomData = new DevExpress.XtraEditors.GroupControl();
            this.tbListRoomStatus = new System.Windows.Forms.TextBox();
            this.lbListRoomStatus = new DevExpress.XtraEditors.LabelControl();
            this.tbListRoomType = new System.Windows.Forms.TextBox();
            this.tbListRoomPrice = new System.Windows.Forms.TextBox();
            this.lbListRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.tbListRoomID = new System.Windows.Forms.TextBox();
            this.rtbListRoomNote = new System.Windows.Forms.RichTextBox();
            this.lbListRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.lbListRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbListRoomType = new DevExpress.XtraEditors.LabelControl();
            this.gcListRoom = new DevExpress.XtraEditors.GroupControl();
            this.dgvListRoom = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gcListRoomEdit = new DevExpress.XtraEditors.GroupControl();
            this.btnAddRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tabNoteRoom = new DevExpress.XtraTab.XtraTabPage();
            this.tlpNoteRoom = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelNote = new DevExpress.XtraEditors.SimpleButton();
            this.gcNoteRoom = new DevExpress.XtraEditors.GroupControl();
            this.tbNoteRoomPrice = new System.Windows.Forms.TextBox();
            this.cbNoteRoomID = new System.Windows.Forms.ComboBox();
            this.lbNoteRoomID = new DevExpress.XtraEditors.LabelControl();
            this.deNoteRoomDate = new DevExpress.XtraEditors.DateEdit();
            this.lbNoteRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbNoteRoomDate = new DevExpress.XtraEditors.LabelControl();
            this.btnLockNoteRoom = new DevExpress.XtraEditors.SimpleButton();
            this.gcNoteCustomer = new DevExpress.XtraEditors.GroupControl();
            this.dgvNoteCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPassportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNoteCustomerData = new DevExpress.XtraEditors.GroupControl();
            this.tbNoteCustomerType = new System.Windows.Forms.TextBox();
            this.tbNoteCustomerPassport = new System.Windows.Forms.TextBox();
            this.lbNoteCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.tbNoteCustomerName = new System.Windows.Forms.TextBox();
            this.rtbNoteCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.lbNoteCustomerPassport = new DevExpress.XtraEditors.LabelControl();
            this.lbNoteCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lbNoteCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.gcEditNoteCustomer = new DevExpress.XtraEditors.GroupControl();
            this.btnEditNoteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelNoteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNoteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCreateNote = new DevExpress.XtraEditors.SimpleButton();
            this.tabFindRoom = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gcFindRoomData = new DevExpress.XtraEditors.GroupControl();
            this.rtbFindRoomNote = new System.Windows.Forms.RichTextBox();
            this.lbFindRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.tbFindRoomStatus = new System.Windows.Forms.TextBox();
            this.tbFindRoomPrice = new System.Windows.Forms.TextBox();
            this.tbFindRoomType = new System.Windows.Forms.TextBox();
            this.tbFindRoomID = new System.Windows.Forms.TextBox();
            this.lbFindRoomID2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomStatus2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomPrice2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomType2 = new DevExpress.XtraEditors.LabelControl();
            this.gcFindRoom = new DevExpress.XtraEditors.GroupControl();
            this.cbFindRoomPrice = new System.Windows.Forms.ComboBox();
            this.cbFindRoomStatus = new System.Windows.Forms.ComboBox();
            this.cbFindRoomID = new System.Windows.Forms.ComboBox();
            this.lbFindRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbFindRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.btnFindRoom = new DevExpress.XtraEditors.SimpleButton();
            this.lbFindRoomType = new DevExpress.XtraEditors.LabelControl();
            this.cbFindRoomType = new System.Windows.Forms.ComboBox();
            this.gcRoomList = new DevExpress.XtraEditors.GroupControl();
            this.dgvFindRoom = new System.Windows.Forms.DataGridView();
            this.FindRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindRoomNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBillRoom = new DevExpress.XtraTab.XtraTabPage();
            this.gcBillCreate_4 = new System.Windows.Forms.TableLayoutPanel();
            this.gcBill = new DevExpress.XtraEditors.GroupControl();
            this.btnLockBill = new DevExpress.XtraEditors.SimpleButton();
            this.deBillDate = new DevExpress.XtraEditors.DateEdit();
            this.lbBillDate = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.tbBillCustomerName = new System.Windows.Forms.TextBox();
            this.rtbBillCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.lbBillCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.gcBillRoom = new DevExpress.XtraEditors.GroupControl();
            this.dgvBillRoom = new System.Windows.Forms.DataGridView();
            this.PaidRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomRentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidRoomTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gcBillRoomData = new DevExpress.XtraEditors.GroupControl();
            this.btnDelBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tbBillRoomCost = new System.Windows.Forms.TextBox();
            this.tbBillRoomPrice = new System.Windows.Forms.TextBox();
            this.tbBillRoomDay = new System.Windows.Forms.TextBox();
            this.tbBillRoomID = new System.Windows.Forms.TextBox();
            this.lbBillRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomCost = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbBillRoomDay = new DevExpress.XtraEditors.LabelControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gcAddBillRoom = new DevExpress.XtraEditors.GroupControl();
            this.lbAddBillRoomID = new DevExpress.XtraEditors.LabelControl();
            this.cbAddBillRoomID = new System.Windows.Forms.ComboBox();
            this.btnAddBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateBillRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tabRevenueRoom = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gcRevenueSelect = new DevExpress.XtraEditors.GroupControl();
            this.nudRevenue = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMonthRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.lbMonthRevenue = new DevExpress.XtraEditors.LabelControl();
            this.gcRevenueList = new DevExpress.XtraEditors.GroupControl();
            this.dgvRevenueList = new System.Windows.Forms.DataGridView();
            this.tabRules = new DevExpress.XtraTab.XtraTabPage();
            this.gcEditRule = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomerType = new DevExpress.XtraEditors.SimpleButton();
            this.gcCustomerTypeList = new DevExpress.XtraEditors.GroupControl();
            this.dgvCustomerType = new System.Windows.Forms.DataGridView();
            this.gcRoomTypeList = new DevExpress.XtraEditors.GroupControl();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.panelEditRules = new System.Windows.Forms.Panel();
            this.lbMaxCustomerRule = new DevExpress.XtraEditors.LabelControl();
            this.lbMaxCustomerValue = new DevExpress.XtraEditors.LabelControl();
            this.lbForeignCustomerTaxValue = new DevExpress.XtraEditors.LabelControl();
            this.lbOverCustomerTaxValue = new DevExpress.XtraEditors.LabelControl();
            this.btnEditMaxCustomerRule = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditForeignCustomerTax = new DevExpress.XtraEditors.SimpleButton();
            this.lbForeignCustomerTax = new DevExpress.XtraEditors.LabelControl();
            this.btnEditThirdCustomerTax = new DevExpress.XtraEditors.SimpleButton();
            this.lbOverCustumerRuleTax = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton19 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.ReportedRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedRoomRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedRoomPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRoomTypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCustomerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tcHotelManagement)).BeginInit();
            this.tcHotelManagement.SuspendLayout();
            this.tabListRoom.SuspendLayout();
            this.tlpListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomData)).BeginInit();
            this.gcRoomData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoom)).BeginInit();
            this.gcListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoomEdit)).BeginInit();
            this.gcListRoomEdit.SuspendLayout();
            this.tabNoteRoom.SuspendLayout();
            this.tlpNoteRoom.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteRoom)).BeginInit();
            this.gcNoteRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNoteRoomDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNoteRoomDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteCustomer)).BeginInit();
            this.gcNoteCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteCustomerData)).BeginInit();
            this.gcNoteCustomerData.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditNoteCustomer)).BeginInit();
            this.gcEditNoteCustomer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabFindRoom.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoomData)).BeginInit();
            this.gcFindRoomData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoom)).BeginInit();
            this.gcFindRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).BeginInit();
            this.gcRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindRoom)).BeginInit();
            this.tabBillRoom.SuspendLayout();
            this.gcBillCreate_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            this.gcBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillRoom)).BeginInit();
            this.gcBillRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillRoomData)).BeginInit();
            this.gcBillRoomData.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddBillRoom)).BeginInit();
            this.gcAddBillRoom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabRevenueRoom.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenueSelect)).BeginInit();
            this.gcRevenueSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenueList)).BeginInit();
            this.gcRevenueList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueList)).BeginInit();
            this.tabRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditRule)).BeginInit();
            this.gcEditRule.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerTypeList)).BeginInit();
            this.gcCustomerTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomTypeList)).BeginInit();
            this.gcRoomTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.panelEditRules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHotelManagement
            // 
            this.tcHotelManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHotelManagement.Location = new System.Drawing.Point(0, 0);
            this.tcHotelManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcHotelManagement.Name = "tcHotelManagement";
            this.tcHotelManagement.SelectedTabPage = this.tabListRoom;
            this.tcHotelManagement.Size = new System.Drawing.Size(961, 693);
            this.tcHotelManagement.TabIndex = 1;
            this.tcHotelManagement.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabListRoom,
            this.tabNoteRoom,
            this.tabFindRoom,
            this.tabBillRoom,
            this.tabRevenueRoom,
            this.tabRules});
            this.tcHotelManagement.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.TcHotelManagement_SelectedPageChanging);
            this.tcHotelManagement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combobox_KeyPress);
            // 
            // tabListRoom
            // 
            this.tabListRoom.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabListRoom.Appearance.PageClient.Options.UseBackColor = true;
            this.tabListRoom.Controls.Add(this.tlpListRoom);
            this.tabListRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabListRoom.ImageOptions.Image")));
            this.tabListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabListRoom.Name = "tabListRoom";
            this.tabListRoom.Size = new System.Drawing.Size(955, 646);
            this.tabListRoom.Text = "DANH MỤC PHÒNG";
            // 
            // tlpListRoom
            // 
            this.tlpListRoom.ColumnCount = 2;
            this.tlpListRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpListRoom.Controls.Add(this.gcRoomData, 0, 0);
            this.tlpListRoom.Controls.Add(this.gcListRoom, 0, 1);
            this.tlpListRoom.Controls.Add(this.panel8, 1, 0);
            this.tlpListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListRoom.Location = new System.Drawing.Point(0, 0);
            this.tlpListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpListRoom.Name = "tlpListRoom";
            this.tlpListRoom.RowCount = 2;
            this.tlpListRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpListRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListRoom.Size = new System.Drawing.Size(955, 646);
            this.tlpListRoom.TabIndex = 0;
            // 
            // gcRoomData
            // 
            this.gcRoomData.Controls.Add(this.tbListRoomStatus);
            this.gcRoomData.Controls.Add(this.lbListRoomStatus);
            this.gcRoomData.Controls.Add(this.tbListRoomType);
            this.gcRoomData.Controls.Add(this.tbListRoomPrice);
            this.gcRoomData.Controls.Add(this.lbListRoomPrice);
            this.gcRoomData.Controls.Add(this.tbListRoomID);
            this.gcRoomData.Controls.Add(this.rtbListRoomNote);
            this.gcRoomData.Controls.Add(this.lbListRoomNote);
            this.gcRoomData.Controls.Add(this.lbListRoomID);
            this.gcRoomData.Controls.Add(this.lbListRoomType);
            this.gcRoomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomData.Location = new System.Drawing.Point(3, 2);
            this.gcRoomData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRoomData.Name = "gcRoomData";
            this.gcRoomData.Size = new System.Drawing.Size(769, 216);
            this.gcRoomData.TabIndex = 0;
            this.gcRoomData.Text = "THÔNG TIN PHÒNG";
            // 
            // tbListRoomStatus
            // 
            this.tbListRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbListRoomStatus.Location = new System.Drawing.Point(230, 74);
            this.tbListRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbListRoomStatus.Name = "tbListRoomStatus";
            this.tbListRoomStatus.ReadOnly = true;
            this.tbListRoomStatus.Size = new System.Drawing.Size(139, 21);
            this.tbListRoomStatus.TabIndex = 15;
            this.tbListRoomStatus.TabStop = false;
            // 
            // lbListRoomStatus
            // 
            this.lbListRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListRoomStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbListRoomStatus.Appearance.Options.UseFont = true;
            this.lbListRoomStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbListRoomStatus.Location = new System.Drawing.Point(159, 77);
            this.lbListRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbListRoomStatus.Name = "lbListRoomStatus";
            this.lbListRoomStatus.Size = new System.Drawing.Size(65, 13);
            this.lbListRoomStatus.TabIndex = 14;
            this.lbListRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // tbListRoomType
            // 
            this.tbListRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbListRoomType.Location = new System.Drawing.Point(474, 42);
            this.tbListRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbListRoomType.Name = "tbListRoomType";
            this.tbListRoomType.ReadOnly = true;
            this.tbListRoomType.Size = new System.Drawing.Size(116, 21);
            this.tbListRoomType.TabIndex = 13;
            this.tbListRoomType.TabStop = false;
            // 
            // tbListRoomPrice
            // 
            this.tbListRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbListRoomPrice.Location = new System.Drawing.Point(474, 74);
            this.tbListRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbListRoomPrice.Name = "tbListRoomPrice";
            this.tbListRoomPrice.ReadOnly = true;
            this.tbListRoomPrice.Size = new System.Drawing.Size(116, 21);
            this.tbListRoomPrice.TabIndex = 7;
            this.tbListRoomPrice.TabStop = false;
            // 
            // lbListRoomPrice
            // 
            this.lbListRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbListRoomPrice.Appearance.Options.UseFont = true;
            this.lbListRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbListRoomPrice.Location = new System.Drawing.Point(420, 77);
            this.lbListRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbListRoomPrice.Name = "lbListRoomPrice";
            this.lbListRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbListRoomPrice.TabIndex = 6;
            this.lbListRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // tbListRoomID
            // 
            this.tbListRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbListRoomID.Location = new System.Drawing.Point(230, 43);
            this.tbListRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbListRoomID.Name = "tbListRoomID";
            this.tbListRoomID.ReadOnly = true;
            this.tbListRoomID.Size = new System.Drawing.Size(139, 21);
            this.tbListRoomID.TabIndex = 1;
            this.tbListRoomID.TabStop = false;
            // 
            // rtbListRoomNote
            // 
            this.rtbListRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbListRoomNote.BackColor = System.Drawing.SystemColors.Control;
            this.rtbListRoomNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbListRoomNote.Location = new System.Drawing.Point(230, 111);
            this.rtbListRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbListRoomNote.Name = "rtbListRoomNote";
            this.rtbListRoomNote.ReadOnly = true;
            this.rtbListRoomNote.Size = new System.Drawing.Size(360, 83);
            this.rtbListRoomNote.TabIndex = 9;
            this.rtbListRoomNote.TabStop = false;
            this.rtbListRoomNote.Text = "";
            // 
            // lbListRoomNote
            // 
            this.lbListRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbListRoomNote.Appearance.Options.UseFont = true;
            this.lbListRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbListRoomNote.Location = new System.Drawing.Point(178, 111);
            this.lbListRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbListRoomNote.Name = "lbListRoomNote";
            this.lbListRoomNote.Size = new System.Drawing.Size(46, 13);
            this.lbListRoomNote.TabIndex = 8;
            this.lbListRoomNote.Text = "GHI CHÚ:";
            // 
            // lbListRoomID
            // 
            this.lbListRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbListRoomID.Appearance.Options.UseFont = true;
            this.lbListRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbListRoomID.Location = new System.Drawing.Point(186, 46);
            this.lbListRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbListRoomID.Name = "lbListRoomID";
            this.lbListRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbListRoomID.TabIndex = 0;
            this.lbListRoomID.Text = "PHÒNG:";
            // 
            // lbListRoomType
            // 
            this.lbListRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbListRoomType.Appearance.Options.UseFont = true;
            this.lbListRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbListRoomType.Location = new System.Drawing.Point(402, 45);
            this.lbListRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbListRoomType.Name = "lbListRoomType";
            this.lbListRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbListRoomType.TabIndex = 2;
            this.lbListRoomType.Text = "LOẠI PHÒNG:";
            // 
            // gcListRoom
            // 
            this.tlpListRoom.SetColumnSpan(this.gcListRoom, 2);
            this.gcListRoom.Controls.Add(this.dgvListRoom);
            this.gcListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListRoom.Location = new System.Drawing.Point(3, 222);
            this.gcListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcListRoom.Name = "gcListRoom";
            this.gcListRoom.Size = new System.Drawing.Size(949, 422);
            this.gcListRoom.TabIndex = 1;
            this.gcListRoom.Text = "DANH MỤC PHÒNG";
            // 
            // dgvListRoom
            // 
            this.dgvListRoom.AllowUserToAddRows = false;
            this.dgvListRoom.AllowUserToDeleteRows = false;
            this.dgvListRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomType,
            this.RoomPrice,
            this.RoomStatus,
            this.RoomNote});
            this.dgvListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListRoom.Location = new System.Drawing.Point(2, 20);
            this.dgvListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListRoom.MultiSelect = false;
            this.dgvListRoom.Name = "dgvListRoom";
            this.dgvListRoom.ReadOnly = true;
            this.dgvListRoom.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListRoom.RowTemplate.Height = 24;
            this.dgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRoom.Size = new System.Drawing.Size(945, 400);
            this.dgvListRoom.TabIndex = 2;
            this.dgvListRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListRoom_CellEnter);
            this.dgvListRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "PHÒNG";
            this.RoomID.MaxInputLength = 10;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomType.DataPropertyName = "MaLoaiPhong";
            this.RoomType.HeaderText = "LOẠI PHÒNG";
            this.RoomType.MaxInputLength = 30;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomPrice.DataPropertyName = "DonGia";
            this.RoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // RoomStatus
            // 
            this.RoomStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomStatus.DataPropertyName = "TenTinhTrang";
            this.RoomStatus.HeaderText = "TÌNH TRẠNG";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.ReadOnly = true;
            // 
            // RoomNote
            // 
            this.RoomNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNote.DataPropertyName = "GhiChu";
            this.RoomNote.HeaderText = "GHI CHÚ";
            this.RoomNote.MaxInputLength = 50;
            this.RoomNote.Name = "RoomNote";
            this.RoomNote.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gcListRoomEdit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(778, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(174, 214);
            this.panel8.TabIndex = 2;
            // 
            // gcListRoomEdit
            // 
            this.gcListRoomEdit.Controls.Add(this.btnAddRoom);
            this.gcListRoomEdit.Controls.Add(this.btnEditRoom);
            this.gcListRoomEdit.Controls.Add(this.btnDelRoom);
            this.gcListRoomEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListRoomEdit.Location = new System.Drawing.Point(0, 0);
            this.gcListRoomEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcListRoomEdit.Name = "gcListRoomEdit";
            this.gcListRoomEdit.Size = new System.Drawing.Size(174, 214);
            this.gcListRoomEdit.TabIndex = 1;
            this.gcListRoomEdit.Text = "HIỆU CHỈNH PHÒNG";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.ImageOptions.Image")));
            this.btnAddRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddRoom.Location = new System.Drawing.Point(27, 42);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 41);
            this.btnAddRoom.TabIndex = 16;
            this.btnAddRoom.Text = "THÊM";
            this.btnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoom.ImageOptions.Image")));
            this.btnEditRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditRoom.Location = new System.Drawing.Point(27, 152);
            this.btnEditRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(120, 41);
            this.btnEditRoom.TabIndex = 15;
            this.btnEditRoom.Text = "SỬA";
            this.btnEditRoom.Click += new System.EventHandler(this.BtnEditRoom_Click);
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoom.ImageOptions.Image")));
            this.btnDelRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelRoom.Location = new System.Drawing.Point(27, 97);
            this.btnDelRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(120, 41);
            this.btnDelRoom.TabIndex = 14;
            this.btnDelRoom.Text = "XÓA";
            this.btnDelRoom.Click += new System.EventHandler(this.BtnDelRoom_Click);
            // 
            // tabNoteRoom
            // 
            this.tabNoteRoom.Controls.Add(this.tlpNoteRoom);
            this.tabNoteRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNoteRoom.ImageOptions.Image")));
            this.tabNoteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNoteRoom.Name = "tabNoteRoom";
            this.tabNoteRoom.Size = new System.Drawing.Size(955, 646);
            this.tabNoteRoom.Text = "LẬP PHIẾU THUÊ PHÒNG";
            // 
            // tlpNoteRoom
            // 
            this.tlpNoteRoom.ColumnCount = 4;
            this.tlpNoteRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tlpNoteRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNoteRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tlpNoteRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpNoteRoom.Controls.Add(this.panel4, 0, 2);
            this.tlpNoteRoom.Controls.Add(this.gcNoteRoom, 0, 0);
            this.tlpNoteRoom.Controls.Add(this.gcNoteCustomer, 0, 1);
            this.tlpNoteRoom.Controls.Add(this.gcNoteCustomerData, 1, 0);
            this.tlpNoteRoom.Controls.Add(this.panel9, 3, 0);
            this.tlpNoteRoom.Controls.Add(this.panel5, 2, 2);
            this.tlpNoteRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNoteRoom.Location = new System.Drawing.Point(0, 0);
            this.tlpNoteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpNoteRoom.Name = "tlpNoteRoom";
            this.tlpNoteRoom.RowCount = 2;
            this.tlpNoteRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpNoteRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNoteRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpNoteRoom.Size = new System.Drawing.Size(955, 646);
            this.tlpNoteRoom.TabIndex = 1;
            // 
            // panel4
            // 
            this.tlpNoteRoom.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.btnCancelNote);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 599);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 44);
            this.panel4.TabIndex = 6;
            // 
            // btnCancelNote
            // 
            this.btnCancelNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelNote.Enabled = false;
            this.btnCancelNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelNote.ImageOptions.Image")));
            this.btnCancelNote.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelNote.Location = new System.Drawing.Point(0, 0);
            this.btnCancelNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelNote.Name = "btnCancelNote";
            this.btnCancelNote.Size = new System.Drawing.Size(477, 44);
            this.btnCancelNote.TabIndex = 16;
            this.btnCancelNote.Text = "HUỶ PHIẾU THUÊ";
            this.btnCancelNote.Click += new System.EventHandler(this.BtnCancelNote_Click);
            // 
            // gcNoteRoom
            // 
            this.gcNoteRoom.Controls.Add(this.tbNoteRoomPrice);
            this.gcNoteRoom.Controls.Add(this.cbNoteRoomID);
            this.gcNoteRoom.Controls.Add(this.lbNoteRoomID);
            this.gcNoteRoom.Controls.Add(this.deNoteRoomDate);
            this.gcNoteRoom.Controls.Add(this.lbNoteRoomPrice);
            this.gcNoteRoom.Controls.Add(this.lbNoteRoomDate);
            this.gcNoteRoom.Controls.Add(this.btnLockNoteRoom);
            this.gcNoteRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoteRoom.Location = new System.Drawing.Point(3, 2);
            this.gcNoteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNoteRoom.Name = "gcNoteRoom";
            this.gcNoteRoom.Size = new System.Drawing.Size(325, 216);
            this.gcNoteRoom.TabIndex = 0;
            this.gcNoteRoom.Text = "CHỌN PHÒNG THUÊ";
            // 
            // tbNoteRoomPrice
            // 
            this.tbNoteRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNoteRoomPrice.Location = new System.Drawing.Point(93, 142);
            this.tbNoteRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoteRoomPrice.Name = "tbNoteRoomPrice";
            this.tbNoteRoomPrice.ReadOnly = true;
            this.tbNoteRoomPrice.Size = new System.Drawing.Size(94, 21);
            this.tbNoteRoomPrice.TabIndex = 17;
            this.tbNoteRoomPrice.TabStop = false;
            // 
            // cbNoteRoomID
            // 
            this.cbNoteRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNoteRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoteRoomID.FormattingEnabled = true;
            this.cbNoteRoomID.Location = new System.Drawing.Point(92, 55);
            this.cbNoteRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNoteRoomID.Name = "cbNoteRoomID";
            this.cbNoteRoomID.Size = new System.Drawing.Size(94, 21);
            this.cbNoteRoomID.Sorted = true;
            this.cbNoteRoomID.TabIndex = 9;
            this.cbNoteRoomID.SelectedIndexChanged += new System.EventHandler(this.CbNoteRoomID_SelectedIndexChanged);
            // 
            // lbNoteRoomID
            // 
            this.lbNoteRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteRoomID.Appearance.Options.UseFont = true;
            this.lbNoteRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteRoomID.Location = new System.Drawing.Point(49, 58);
            this.lbNoteRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteRoomID.Name = "lbNoteRoomID";
            this.lbNoteRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbNoteRoomID.TabIndex = 8;
            this.lbNoteRoomID.Text = "PHÒNG:";
            // 
            // deNoteRoomDate
            // 
            this.deNoteRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deNoteRoomDate.EditValue = null;
            this.deNoteRoomDate.Location = new System.Drawing.Point(93, 97);
            this.deNoteRoomDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deNoteRoomDate.Name = "deNoteRoomDate";
            this.deNoteRoomDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNoteRoomDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNoteRoomDate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deNoteRoomDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deNoteRoomDate.Size = new System.Drawing.Size(93, 20);
            this.deNoteRoomDate.TabIndex = 7;
            this.deNoteRoomDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combobox_KeyPress);
            // 
            // lbNoteRoomPrice
            // 
            this.lbNoteRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteRoomPrice.Appearance.Options.UseFont = true;
            this.lbNoteRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteRoomPrice.Location = new System.Drawing.Point(41, 145);
            this.lbNoteRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteRoomPrice.Name = "lbNoteRoomPrice";
            this.lbNoteRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbNoteRoomPrice.TabIndex = 6;
            this.lbNoteRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbNoteRoomDate
            // 
            this.lbNoteRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteRoomDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteRoomDate.Appearance.Options.UseFont = true;
            this.lbNoteRoomDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteRoomDate.Location = new System.Drawing.Point(27, 100);
            this.lbNoteRoomDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteRoomDate.Name = "lbNoteRoomDate";
            this.lbNoteRoomDate.Size = new System.Drawing.Size(60, 13);
            this.lbNoteRoomDate.TabIndex = 6;
            this.lbNoteRoomDate.Text = "NGÀY THUÊ:";
            // 
            // btnLockNoteRoom
            // 
            this.btnLockNoteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLockNoteRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLockNoteRoom.ImageOptions.Image")));
            this.btnLockNoteRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLockNoteRoom.Location = new System.Drawing.Point(203, 53);
            this.btnLockNoteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockNoteRoom.Name = "btnLockNoteRoom";
            this.btnLockNoteRoom.Size = new System.Drawing.Size(94, 110);
            this.btnLockNoteRoom.TabIndex = 14;
            this.btnLockNoteRoom.Text = "\r\nCHỌN PHÒNG";
            this.btnLockNoteRoom.EnabledChanged += new System.EventHandler(this.BtnLockNoteRoom_EnabledChanged);
            this.btnLockNoteRoom.Click += new System.EventHandler(this.BtnLockNoteRoom_Click);
            // 
            // gcNoteCustomer
            // 
            this.tlpNoteRoom.SetColumnSpan(this.gcNoteCustomer, 4);
            this.gcNoteCustomer.Controls.Add(this.dgvNoteCustomer);
            this.gcNoteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoteCustomer.Location = new System.Drawing.Point(3, 222);
            this.gcNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNoteCustomer.Name = "gcNoteCustomer";
            this.gcNoteCustomer.Size = new System.Drawing.Size(949, 372);
            this.gcNoteCustomer.TabIndex = 1;
            this.gcNoteCustomer.Text = "DANH SÁCH KHÁCH";
            // 
            // dgvNoteCustomer
            // 
            this.dgvNoteCustomer.AllowUserToAddRows = false;
            this.dgvNoteCustomer.AllowUserToDeleteRows = false;
            this.dgvNoteCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvNoteCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerTypeID,
            this.CustomerType,
            this.CustomerPassportID,
            this.CustomerAddress});
            this.dgvNoteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoteCustomer.Location = new System.Drawing.Point(2, 20);
            this.dgvNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNoteCustomer.MultiSelect = false;
            this.dgvNoteCustomer.Name = "dgvNoteCustomer";
            this.dgvNoteCustomer.ReadOnly = true;
            this.dgvNoteCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNoteCustomer.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNoteCustomer.RowTemplate.Height = 24;
            this.dgvNoteCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoteCustomer.Size = new System.Drawing.Size(945, 350);
            this.dgvNoteCustomer.TabIndex = 3;
            this.dgvNoteCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNoteCustomer_CellEnter);
            this.dgvNoteCustomer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNoteCustomer_CellValueChanged);
            this.dgvNoteCustomer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            this.dgvNoteCustomer.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvNoteCustomer_RowsAdded);
            this.dgvNoteCustomer.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvNoteCustomer_RowsRemoved);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "TÊN KHÁCH";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerTypeID
            // 
            this.CustomerTypeID.HeaderText = "MÃ LOẠI KHÁCH";
            this.CustomerTypeID.Name = "CustomerTypeID";
            this.CustomerTypeID.ReadOnly = true;
            this.CustomerTypeID.Visible = false;
            // 
            // CustomerType
            // 
            this.CustomerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerType.HeaderText = "LOẠI KHÁCH";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            // 
            // CustomerPassportID
            // 
            this.CustomerPassportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerPassportID.HeaderText = "SỐ CMND";
            this.CustomerPassportID.Name = "CustomerPassportID";
            this.CustomerPassportID.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerAddress.HeaderText = "ĐỊA CHỈ";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // gcNoteCustomerData
            // 
            this.tlpNoteRoom.SetColumnSpan(this.gcNoteCustomerData, 2);
            this.gcNoteCustomerData.Controls.Add(this.tbNoteCustomerType);
            this.gcNoteCustomerData.Controls.Add(this.tbNoteCustomerPassport);
            this.gcNoteCustomerData.Controls.Add(this.lbNoteCustomerAddress);
            this.gcNoteCustomerData.Controls.Add(this.tbNoteCustomerName);
            this.gcNoteCustomerData.Controls.Add(this.rtbNoteCustomerAddress);
            this.gcNoteCustomerData.Controls.Add(this.lbNoteCustomerPassport);
            this.gcNoteCustomerData.Controls.Add(this.lbNoteCustomerName);
            this.gcNoteCustomerData.Controls.Add(this.lbNoteCustomerType);
            this.gcNoteCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoteCustomerData.Location = new System.Drawing.Point(334, 2);
            this.gcNoteCustomerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNoteCustomerData.Name = "gcNoteCustomerData";
            this.gcNoteCustomerData.Size = new System.Drawing.Size(438, 216);
            this.gcNoteCustomerData.TabIndex = 2;
            this.gcNoteCustomerData.Text = "THÔNG TIN KHÁCH";
            // 
            // tbNoteCustomerType
            // 
            this.tbNoteCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNoteCustomerType.Location = new System.Drawing.Point(94, 79);
            this.tbNoteCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoteCustomerType.Name = "tbNoteCustomerType";
            this.tbNoteCustomerType.ReadOnly = true;
            this.tbNoteCustomerType.Size = new System.Drawing.Size(106, 21);
            this.tbNoteCustomerType.TabIndex = 30;
            this.tbNoteCustomerType.TabStop = false;
            // 
            // tbNoteCustomerPassport
            // 
            this.tbNoteCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNoteCustomerPassport.Location = new System.Drawing.Point(279, 79);
            this.tbNoteCustomerPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoteCustomerPassport.Name = "tbNoteCustomerPassport";
            this.tbNoteCustomerPassport.ReadOnly = true;
            this.tbNoteCustomerPassport.Size = new System.Drawing.Size(136, 21);
            this.tbNoteCustomerPassport.TabIndex = 22;
            this.tbNoteCustomerPassport.TabStop = false;
            // 
            // lbNoteCustomerAddress
            // 
            this.lbNoteCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteCustomerAddress.Appearance.Options.UseFont = true;
            this.lbNoteCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteCustomerAddress.Location = new System.Drawing.Point(44, 115);
            this.lbNoteCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteCustomerAddress.Name = "lbNoteCustomerAddress";
            this.lbNoteCustomerAddress.Size = new System.Drawing.Size(44, 13);
            this.lbNoteCustomerAddress.TabIndex = 23;
            this.lbNoteCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // tbNoteCustomerName
            // 
            this.tbNoteCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNoteCustomerName.Location = new System.Drawing.Point(94, 46);
            this.tbNoteCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoteCustomerName.Name = "tbNoteCustomerName";
            this.tbNoteCustomerName.ReadOnly = true;
            this.tbNoteCustomerName.Size = new System.Drawing.Size(321, 21);
            this.tbNoteCustomerName.TabIndex = 18;
            this.tbNoteCustomerName.TabStop = false;
            // 
            // rtbNoteCustomerAddress
            // 
            this.rtbNoteCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbNoteCustomerAddress.BackColor = System.Drawing.SystemColors.Control;
            this.rtbNoteCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNoteCustomerAddress.Location = new System.Drawing.Point(94, 113);
            this.rtbNoteCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNoteCustomerAddress.Name = "rtbNoteCustomerAddress";
            this.rtbNoteCustomerAddress.ReadOnly = true;
            this.rtbNoteCustomerAddress.Size = new System.Drawing.Size(321, 82);
            this.rtbNoteCustomerAddress.TabIndex = 24;
            this.rtbNoteCustomerAddress.TabStop = false;
            this.rtbNoteCustomerAddress.Text = "";
            // 
            // lbNoteCustomerPassport
            // 
            this.lbNoteCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteCustomerPassport.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteCustomerPassport.Appearance.Options.UseFont = true;
            this.lbNoteCustomerPassport.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteCustomerPassport.Location = new System.Drawing.Point(223, 82);
            this.lbNoteCustomerPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteCustomerPassport.Name = "lbNoteCustomerPassport";
            this.lbNoteCustomerPassport.Size = new System.Drawing.Size(50, 13);
            this.lbNoteCustomerPassport.TabIndex = 21;
            this.lbNoteCustomerPassport.Text = "SỐ CMND:";
            // 
            // lbNoteCustomerName
            // 
            this.lbNoteCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteCustomerName.Appearance.Options.UseFont = true;
            this.lbNoteCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteCustomerName.Location = new System.Drawing.Point(28, 49);
            this.lbNoteCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteCustomerName.Name = "lbNoteCustomerName";
            this.lbNoteCustomerName.Size = new System.Drawing.Size(60, 13);
            this.lbNoteCustomerName.TabIndex = 17;
            this.lbNoteCustomerName.Text = "TÊN KHÁCH:";
            // 
            // lbNoteCustomerType
            // 
            this.lbNoteCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoteCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNoteCustomerType.Appearance.Options.UseFont = true;
            this.lbNoteCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNoteCustomerType.Location = new System.Drawing.Point(23, 82);
            this.lbNoteCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoteCustomerType.Name = "lbNoteCustomerType";
            this.lbNoteCustomerType.Size = new System.Drawing.Size(65, 13);
            this.lbNoteCustomerType.TabIndex = 19;
            this.lbNoteCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.gcEditNoteCustomer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(778, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(174, 214);
            this.panel9.TabIndex = 5;
            // 
            // gcEditNoteCustomer
            // 
            this.gcEditNoteCustomer.Controls.Add(this.btnEditNoteCustomer);
            this.gcEditNoteCustomer.Controls.Add(this.btnDelNoteCustomer);
            this.gcEditNoteCustomer.Controls.Add(this.btnAddNoteCustomer);
            this.gcEditNoteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEditNoteCustomer.Location = new System.Drawing.Point(0, 0);
            this.gcEditNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcEditNoteCustomer.Name = "gcEditNoteCustomer";
            this.gcEditNoteCustomer.Size = new System.Drawing.Size(174, 214);
            this.gcEditNoteCustomer.TabIndex = 2;
            this.gcEditNoteCustomer.Text = "HIỆU CHỈNH KHÁCH";
            // 
            // btnEditNoteCustomer
            // 
            this.btnEditNoteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditNoteCustomer.Enabled = false;
            this.btnEditNoteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNoteCustomer.ImageOptions.Image")));
            this.btnEditNoteCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditNoteCustomer.Location = new System.Drawing.Point(27, 152);
            this.btnEditNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditNoteCustomer.Name = "btnEditNoteCustomer";
            this.btnEditNoteCustomer.Size = new System.Drawing.Size(120, 41);
            this.btnEditNoteCustomer.TabIndex = 15;
            this.btnEditNoteCustomer.Text = "SỬA";
            this.btnEditNoteCustomer.Click += new System.EventHandler(this.BtnEditNoteCustomer_Click);
            // 
            // btnDelNoteCustomer
            // 
            this.btnDelNoteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelNoteCustomer.Enabled = false;
            this.btnDelNoteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelNoteCustomer.ImageOptions.Image")));
            this.btnDelNoteCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelNoteCustomer.Location = new System.Drawing.Point(27, 97);
            this.btnDelNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelNoteCustomer.Name = "btnDelNoteCustomer";
            this.btnDelNoteCustomer.Size = new System.Drawing.Size(120, 41);
            this.btnDelNoteCustomer.TabIndex = 14;
            this.btnDelNoteCustomer.Text = "XÓA";
            this.btnDelNoteCustomer.Click += new System.EventHandler(this.BtnDelNoteCustomer_Click);
            // 
            // btnAddNoteCustomer
            // 
            this.btnAddNoteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNoteCustomer.Enabled = false;
            this.btnAddNoteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNoteCustomer.ImageOptions.Image")));
            this.btnAddNoteCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddNoteCustomer.Location = new System.Drawing.Point(27, 42);
            this.btnAddNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNoteCustomer.Name = "btnAddNoteCustomer";
            this.btnAddNoteCustomer.Size = new System.Drawing.Size(120, 41);
            this.btnAddNoteCustomer.TabIndex = 13;
            this.btnAddNoteCustomer.Text = "THÊM";
            this.btnAddNoteCustomer.Click += new System.EventHandler(this.BtnAddNoteCustomer_Click);
            // 
            // panel5
            // 
            this.tlpNoteRoom.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.btnCreateNote);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(486, 599);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 44);
            this.panel5.TabIndex = 7;
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateNote.Enabled = false;
            this.btnCreateNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNote.ImageOptions.Image")));
            this.btnCreateNote.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateNote.Location = new System.Drawing.Point(0, 0);
            this.btnCreateNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(466, 44);
            this.btnCreateNote.TabIndex = 28;
            this.btnCreateNote.Text = "LẬP PHIẾU THUÊ";
            this.btnCreateNote.Click += new System.EventHandler(this.BtnCreateNote_Click);
            // 
            // tabFindRoom
            // 
            this.tabFindRoom.Controls.Add(this.tableLayoutPanel3);
            this.tabFindRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabFindRoom.ImageOptions.Image")));
            this.tabFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFindRoom.Name = "tabFindRoom";
            this.tabFindRoom.Size = new System.Drawing.Size(955, 646);
            this.tabFindRoom.Text = "TRA CỨU PHÒNG";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.77487F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.22513F));
            this.tableLayoutPanel3.Controls.Add(this.gcFindRoomData, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.gcFindRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gcRoomList, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(955, 646);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // gcFindRoomData
            // 
            this.gcFindRoomData.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gcFindRoomData.Appearance.Image")));
            this.gcFindRoomData.Appearance.Options.UseImage = true;
            this.gcFindRoomData.Controls.Add(this.rtbFindRoomNote);
            this.gcFindRoomData.Controls.Add(this.lbFindRoomNote);
            this.gcFindRoomData.Controls.Add(this.tbFindRoomStatus);
            this.gcFindRoomData.Controls.Add(this.tbFindRoomPrice);
            this.gcFindRoomData.Controls.Add(this.tbFindRoomType);
            this.gcFindRoomData.Controls.Add(this.tbFindRoomID);
            this.gcFindRoomData.Controls.Add(this.lbFindRoomID2);
            this.gcFindRoomData.Controls.Add(this.lbFindRoomStatus2);
            this.gcFindRoomData.Controls.Add(this.lbFindRoomPrice2);
            this.gcFindRoomData.Controls.Add(this.lbFindRoomType2);
            this.gcFindRoomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFindRoomData.Location = new System.Drawing.Point(507, 2);
            this.gcFindRoomData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFindRoomData.Name = "gcFindRoomData";
            this.gcFindRoomData.Size = new System.Drawing.Size(445, 216);
            this.gcFindRoomData.TabIndex = 15;
            this.gcFindRoomData.Text = "THÔNG TIN PHÒNG";
            // 
            // rtbFindRoomNote
            // 
            this.rtbFindRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFindRoomNote.BackColor = System.Drawing.SystemColors.Control;
            this.rtbFindRoomNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFindRoomNote.Location = new System.Drawing.Point(71, 127);
            this.rtbFindRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFindRoomNote.Name = "rtbFindRoomNote";
            this.rtbFindRoomNote.ReadOnly = true;
            this.rtbFindRoomNote.Size = new System.Drawing.Size(323, 61);
            this.rtbFindRoomNote.TabIndex = 16;
            this.rtbFindRoomNote.TabStop = false;
            this.rtbFindRoomNote.Text = "";
            // 
            // lbFindRoomNote
            // 
            this.lbFindRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomNote.Appearance.Options.UseFont = true;
            this.lbFindRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomNote.Location = new System.Drawing.Point(19, 130);
            this.lbFindRoomNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomNote.Name = "lbFindRoomNote";
            this.lbFindRoomNote.Size = new System.Drawing.Size(46, 13);
            this.lbFindRoomNote.TabIndex = 15;
            this.lbFindRoomNote.Text = "GHI CHÚ:";
            // 
            // tbFindRoomStatus
            // 
            this.tbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomStatus.Location = new System.Drawing.Point(277, 85);
            this.tbFindRoomStatus.Name = "tbFindRoomStatus";
            this.tbFindRoomStatus.ReadOnly = true;
            this.tbFindRoomStatus.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomStatus.TabIndex = 14;
            this.tbFindRoomStatus.TabStop = false;
            // 
            // tbFindRoomPrice
            // 
            this.tbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomPrice.Location = new System.Drawing.Point(71, 85);
            this.tbFindRoomPrice.Name = "tbFindRoomPrice";
            this.tbFindRoomPrice.ReadOnly = true;
            this.tbFindRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomPrice.TabIndex = 14;
            this.tbFindRoomPrice.TabStop = false;
            // 
            // tbFindRoomType
            // 
            this.tbFindRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomType.Location = new System.Drawing.Point(277, 50);
            this.tbFindRoomType.Name = "tbFindRoomType";
            this.tbFindRoomType.ReadOnly = true;
            this.tbFindRoomType.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomType.TabIndex = 14;
            this.tbFindRoomType.TabStop = false;
            // 
            // tbFindRoomID
            // 
            this.tbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFindRoomID.Location = new System.Drawing.Point(71, 45);
            this.tbFindRoomID.Name = "tbFindRoomID";
            this.tbFindRoomID.ReadOnly = true;
            this.tbFindRoomID.Size = new System.Drawing.Size(117, 21);
            this.tbFindRoomID.TabIndex = 14;
            this.tbFindRoomID.TabStop = false;
            // 
            // lbFindRoomID2
            // 
            this.lbFindRoomID2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomID2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomID2.Appearance.Options.UseFont = true;
            this.lbFindRoomID2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomID2.Location = new System.Drawing.Point(26, 48);
            this.lbFindRoomID2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomID2.Name = "lbFindRoomID2";
            this.lbFindRoomID2.Size = new System.Drawing.Size(39, 13);
            this.lbFindRoomID2.TabIndex = 0;
            this.lbFindRoomID2.Text = "PHÒNG:";
            // 
            // lbFindRoomStatus2
            // 
            this.lbFindRoomStatus2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomStatus2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomStatus2.Appearance.Options.UseFont = true;
            this.lbFindRoomStatus2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomStatus2.Location = new System.Drawing.Point(206, 88);
            this.lbFindRoomStatus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomStatus2.Name = "lbFindRoomStatus2";
            this.lbFindRoomStatus2.Size = new System.Drawing.Size(65, 13);
            this.lbFindRoomStatus2.TabIndex = 8;
            this.lbFindRoomStatus2.Text = "TÌNH TRẠNG:";
            // 
            // lbFindRoomPrice2
            // 
            this.lbFindRoomPrice2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomPrice2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomPrice2.Appearance.Options.UseFont = true;
            this.lbFindRoomPrice2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomPrice2.Location = new System.Drawing.Point(17, 88);
            this.lbFindRoomPrice2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomPrice2.Name = "lbFindRoomPrice2";
            this.lbFindRoomPrice2.Size = new System.Drawing.Size(48, 13);
            this.lbFindRoomPrice2.TabIndex = 6;
            this.lbFindRoomPrice2.Text = "ĐƠN GIÁ:";
            // 
            // lbFindRoomType2
            // 
            this.lbFindRoomType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomType2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomType2.Appearance.Options.UseFont = true;
            this.lbFindRoomType2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomType2.Location = new System.Drawing.Point(205, 53);
            this.lbFindRoomType2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomType2.Name = "lbFindRoomType2";
            this.lbFindRoomType2.Size = new System.Drawing.Size(66, 13);
            this.lbFindRoomType2.TabIndex = 4;
            this.lbFindRoomType2.Text = "LOẠI PHÒNG:";
            // 
            // gcFindRoom
            // 
            this.gcFindRoom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gcFindRoom.Appearance.Image")));
            this.gcFindRoom.Appearance.Options.UseImage = true;
            this.gcFindRoom.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gcFindRoom.Controls.Add(this.cbFindRoomPrice);
            this.gcFindRoom.Controls.Add(this.cbFindRoomStatus);
            this.gcFindRoom.Controls.Add(this.cbFindRoomID);
            this.gcFindRoom.Controls.Add(this.lbFindRoomID);
            this.gcFindRoom.Controls.Add(this.lbFindRoomStatus);
            this.gcFindRoom.Controls.Add(this.lbFindRoomPrice);
            this.gcFindRoom.Controls.Add(this.btnFindRoom);
            this.gcFindRoom.Controls.Add(this.lbFindRoomType);
            this.gcFindRoom.Controls.Add(this.cbFindRoomType);
            this.gcFindRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFindRoom.Location = new System.Drawing.Point(3, 2);
            this.gcFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFindRoom.Name = "gcFindRoom";
            this.gcFindRoom.Size = new System.Drawing.Size(498, 216);
            this.gcFindRoom.TabIndex = 2;
            this.gcFindRoom.Text = "TÌM KIẾM PHÒNG";
            // 
            // cbFindRoomPrice
            // 
            this.cbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomPrice.FormattingEnabled = true;
            this.cbFindRoomPrice.Location = new System.Drawing.Point(162, 127);
            this.cbFindRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomPrice.Name = "cbFindRoomPrice";
            this.cbFindRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomPrice.TabIndex = 7;
            // 
            // cbFindRoomStatus
            // 
            this.cbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomStatus.FormattingEnabled = true;
            this.cbFindRoomStatus.Location = new System.Drawing.Point(163, 167);
            this.cbFindRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomStatus.Name = "cbFindRoomStatus";
            this.cbFindRoomStatus.Size = new System.Drawing.Size(116, 21);
            this.cbFindRoomStatus.TabIndex = 9;
            // 
            // cbFindRoomID
            // 
            this.cbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomID.FormattingEnabled = true;
            this.cbFindRoomID.Location = new System.Drawing.Point(162, 45);
            this.cbFindRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomID.Name = "cbFindRoomID";
            this.cbFindRoomID.Size = new System.Drawing.Size(117, 21);
            this.cbFindRoomID.TabIndex = 1;
            // 
            // lbFindRoomID
            // 
            this.lbFindRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomID.Appearance.Options.UseFont = true;
            this.lbFindRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomID.Location = new System.Drawing.Point(113, 48);
            this.lbFindRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomID.Name = "lbFindRoomID";
            this.lbFindRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbFindRoomID.TabIndex = 0;
            this.lbFindRoomID.Text = "PHÒNG:";
            // 
            // lbFindRoomStatus
            // 
            this.lbFindRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomStatus.Appearance.Options.UseFont = true;
            this.lbFindRoomStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomStatus.Location = new System.Drawing.Point(87, 170);
            this.lbFindRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomStatus.Name = "lbFindRoomStatus";
            this.lbFindRoomStatus.Size = new System.Drawing.Size(65, 13);
            this.lbFindRoomStatus.TabIndex = 8;
            this.lbFindRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // lbFindRoomPrice
            // 
            this.lbFindRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomPrice.Appearance.Options.UseFont = true;
            this.lbFindRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomPrice.Location = new System.Drawing.Point(104, 130);
            this.lbFindRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomPrice.Name = "lbFindRoomPrice";
            this.lbFindRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbFindRoomPrice.TabIndex = 6;
            this.lbFindRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFindRoom.ImageOptions.Image")));
            this.btnFindRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.btnFindRoom.Location = new System.Drawing.Point(307, 45);
            this.btnFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(106, 143);
            this.btnFindRoom.TabIndex = 10;
            this.btnFindRoom.Text = "\r\nTÌM KIẾM";
            this.btnFindRoom.Click += new System.EventHandler(this.BtnFindRoom_Click);
            // 
            // lbFindRoomType
            // 
            this.lbFindRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFindRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFindRoomType.Appearance.Options.UseFont = true;
            this.lbFindRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbFindRoomType.Location = new System.Drawing.Point(86, 88);
            this.lbFindRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFindRoomType.Name = "lbFindRoomType";
            this.lbFindRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbFindRoomType.TabIndex = 4;
            this.lbFindRoomType.Text = "LOẠI PHÒNG:";
            // 
            // cbFindRoomType
            // 
            this.cbFindRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFindRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindRoomType.FormattingEnabled = true;
            this.cbFindRoomType.Location = new System.Drawing.Point(163, 85);
            this.cbFindRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindRoomType.Name = "cbFindRoomType";
            this.cbFindRoomType.Size = new System.Drawing.Size(116, 21);
            this.cbFindRoomType.TabIndex = 5;
            this.cbFindRoomType.SelectedIndexChanged += new System.EventHandler(this.CbFindRoomType_SelectedIndexChanged);
            // 
            // gcRoomList
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.gcRoomList, 2);
            this.gcRoomList.Controls.Add(this.dgvFindRoom);
            this.gcRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomList.Location = new System.Drawing.Point(3, 222);
            this.gcRoomList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRoomList.Name = "gcRoomList";
            this.gcRoomList.Size = new System.Drawing.Size(949, 422);
            this.gcRoomList.TabIndex = 14;
            this.gcRoomList.Text = "DANH MỤC PHÒNG TRA CỨU";
            // 
            // dgvFindRoom
            // 
            this.dgvFindRoom.AllowUserToAddRows = false;
            this.dgvFindRoom.AllowUserToDeleteRows = false;
            this.dgvFindRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FindRoomID,
            this.FindRoomType,
            this.FindRoomPrice,
            this.FindRoomStatus,
            this.FindRoomNote});
            this.dgvFindRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFindRoom.Location = new System.Drawing.Point(2, 20);
            this.dgvFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFindRoom.MultiSelect = false;
            this.dgvFindRoom.Name = "dgvFindRoom";
            this.dgvFindRoom.ReadOnly = true;
            this.dgvFindRoom.RowTemplate.Height = 24;
            this.dgvFindRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindRoom.Size = new System.Drawing.Size(945, 400);
            this.dgvFindRoom.TabIndex = 15;
            this.dgvFindRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFoundRoom_CellEnter);
            this.dgvFindRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // FindRoomID
            // 
            this.FindRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomID.DataPropertyName = "MaPhong";
            this.FindRoomID.HeaderText = "PHÒNG";
            this.FindRoomID.Name = "FindRoomID";
            this.FindRoomID.ReadOnly = true;
            // 
            // FindRoomType
            // 
            this.FindRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomType.DataPropertyName = "MaLoaiPhong";
            this.FindRoomType.HeaderText = "LOẠI PHÒNG";
            this.FindRoomType.Name = "FindRoomType";
            this.FindRoomType.ReadOnly = true;
            // 
            // FindRoomPrice
            // 
            this.FindRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomPrice.DataPropertyName = "DonGia";
            this.FindRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.FindRoomPrice.Name = "FindRoomPrice";
            this.FindRoomPrice.ReadOnly = true;
            // 
            // FindRoomStatus
            // 
            this.FindRoomStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomStatus.DataPropertyName = "TenTinhTrang";
            this.FindRoomStatus.HeaderText = "TÌNH TRẠNG";
            this.FindRoomStatus.Name = "FindRoomStatus";
            this.FindRoomStatus.ReadOnly = true;
            // 
            // FindRoomNote
            // 
            this.FindRoomNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FindRoomNote.DataPropertyName = "GhiChu";
            this.FindRoomNote.HeaderText = "GHI CHÚ";
            this.FindRoomNote.Name = "FindRoomNote";
            this.FindRoomNote.ReadOnly = true;
            // 
            // tabBillRoom
            // 
            this.tabBillRoom.Controls.Add(this.gcBillCreate_4);
            this.tabBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabBillRoom.ImageOptions.Image")));
            this.tabBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBillRoom.Name = "tabBillRoom";
            this.tabBillRoom.Size = new System.Drawing.Size(955, 646);
            this.tabBillRoom.Text = "THANH TOÁN HOÁ ĐƠN";
            // 
            // gcBillCreate_4
            // 
            this.gcBillCreate_4.ColumnCount = 4;
            this.gcBillCreate_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gcBillCreate_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gcBillCreate_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.gcBillCreate_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.gcBillCreate_4.Controls.Add(this.gcBill, 0, 0);
            this.gcBillCreate_4.Controls.Add(this.gcBillRoom, 0, 1);
            this.gcBillCreate_4.Controls.Add(this.panel2, 0, 2);
            this.gcBillCreate_4.Controls.Add(this.panel7, 1, 0);
            this.gcBillCreate_4.Controls.Add(this.panel6, 3, 0);
            this.gcBillCreate_4.Controls.Add(this.panel3, 2, 2);
            this.gcBillCreate_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillCreate_4.Location = new System.Drawing.Point(0, 0);
            this.gcBillCreate_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBillCreate_4.Name = "gcBillCreate_4";
            this.gcBillCreate_4.RowCount = 3;
            this.gcBillCreate_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.gcBillCreate_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gcBillCreate_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.gcBillCreate_4.Size = new System.Drawing.Size(955, 646);
            this.gcBillCreate_4.TabIndex = 2;
            // 
            // gcBill
            // 
            this.gcBill.Controls.Add(this.btnLockBill);
            this.gcBill.Controls.Add(this.deBillDate);
            this.gcBill.Controls.Add(this.lbBillDate);
            this.gcBill.Controls.Add(this.lbBillCustomerAddress);
            this.gcBill.Controls.Add(this.tbBillCustomerName);
            this.gcBill.Controls.Add(this.rtbBillCustomerAddress);
            this.gcBill.Controls.Add(this.lbBillCustomerName);
            this.gcBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBill.Location = new System.Drawing.Point(3, 2);
            this.gcBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(378, 216);
            this.gcBill.TabIndex = 0;
            this.gcBill.Text = "THÔNG TIN THANH TOÁN";
            // 
            // btnLockBill
            // 
            this.btnLockBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLockBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLockBill.ImageOptions.Image")));
            this.btnLockBill.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLockBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLockBill.Location = new System.Drawing.Point(258, 45);
            this.btnLockBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockBill.Name = "btnLockBill";
            this.btnLockBill.Size = new System.Drawing.Size(106, 143);
            this.btnLockBill.TabIndex = 17;
            this.btnLockBill.Text = "\r\nXÁC NHẬN";
            this.btnLockBill.EnabledChanged += new System.EventHandler(this.BtnLockBill_EnabledChanged);
            this.btnLockBill.Click += new System.EventHandler(this.BtnLockBill_Click);
            // 
            // deBillDate
            // 
            this.deBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deBillDate.EditValue = null;
            this.deBillDate.Location = new System.Drawing.Point(79, 93);
            this.deBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deBillDate.Name = "deBillDate";
            this.deBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBillDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBillDate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deBillDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deBillDate.Size = new System.Drawing.Size(158, 20);
            this.deBillDate.TabIndex = 5;
            this.deBillDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combobox_KeyPress);
            // 
            // lbBillDate
            // 
            this.lbBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillDate.Appearance.Options.UseFont = true;
            this.lbBillDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillDate.Location = new System.Drawing.Point(19, 96);
            this.lbBillDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(54, 13);
            this.lbBillDate.TabIndex = 4;
            this.lbBillDate.Text = "NGÀY TRẢ:";
            // 
            // lbBillCustomerAddress
            // 
            this.lbBillCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomerAddress.Appearance.Options.UseFont = true;
            this.lbBillCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomerAddress.Location = new System.Drawing.Point(30, 137);
            this.lbBillCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomerAddress.Name = "lbBillCustomerAddress";
            this.lbBillCustomerAddress.Size = new System.Drawing.Size(44, 13);
            this.lbBillCustomerAddress.TabIndex = 6;
            this.lbBillCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // tbBillCustomerName
            // 
            this.tbBillCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillCustomerName.Location = new System.Drawing.Point(80, 45);
            this.tbBillCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBillCustomerName.Name = "tbBillCustomerName";
            this.tbBillCustomerName.Size = new System.Drawing.Size(157, 21);
            this.tbBillCustomerName.TabIndex = 1;
            this.tbBillCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbName_KeyPress);
            // 
            // rtbBillCustomerAddress
            // 
            this.rtbBillCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbBillCustomerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbBillCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBillCustomerAddress.Location = new System.Drawing.Point(80, 135);
            this.rtbBillCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbBillCustomerAddress.Name = "rtbBillCustomerAddress";
            this.rtbBillCustomerAddress.Size = new System.Drawing.Size(157, 53);
            this.rtbBillCustomerAddress.TabIndex = 7;
            this.rtbBillCustomerAddress.Text = "";
            this.rtbBillCustomerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rtb_KeyDown);
            // 
            // lbBillCustomerName
            // 
            this.lbBillCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomerName.Appearance.Options.UseFont = true;
            this.lbBillCustomerName.Appearance.Options.UseTextOptions = true;
            this.lbBillCustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbBillCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomerName.Location = new System.Drawing.Point(14, 40);
            this.lbBillCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomerName.Name = "lbBillCustomerName";
            this.lbBillCustomerName.Size = new System.Drawing.Size(60, 26);
            this.lbBillCustomerName.TabIndex = 0;
            this.lbBillCustomerName.Text = "TÊN KHÁCH/\r\nCƠ QUAN:";
            // 
            // gcBillRoom
            // 
            this.gcBillCreate_4.SetColumnSpan(this.gcBillRoom, 4);
            this.gcBillRoom.Controls.Add(this.dgvBillRoom);
            this.gcBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillRoom.Location = new System.Drawing.Point(3, 222);
            this.gcBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBillRoom.Name = "gcBillRoom";
            this.gcBillRoom.Size = new System.Drawing.Size(949, 372);
            this.gcBillRoom.TabIndex = 1;
            this.gcBillRoom.Text = "DANH MỤC THANH TOÁN";
            // 
            // dgvBillRoom
            // 
            this.dgvBillRoom.AllowUserToAddRows = false;
            this.dgvBillRoom.AllowUserToDeleteRows = false;
            this.dgvBillRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaidRoomID,
            this.PaidRoomRentDays,
            this.PaidRoomPrice,
            this.OverCustomerTax,
            this.ForeignCustomerTax,
            this.PaidRoomTotalPrice});
            this.dgvBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillRoom.Location = new System.Drawing.Point(2, 20);
            this.dgvBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillRoom.MultiSelect = false;
            this.dgvBillRoom.Name = "dgvBillRoom";
            this.dgvBillRoom.ReadOnly = true;
            this.dgvBillRoom.RowTemplate.Height = 24;
            this.dgvBillRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillRoom.Size = new System.Drawing.Size(945, 350);
            this.dgvBillRoom.TabIndex = 2;
            this.dgvBillRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBillRoom_CellEnter);
            this.dgvBillRoom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            this.dgvBillRoom.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvBillRoom_RowsAdded);
            this.dgvBillRoom.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvBillRoom_RowsRemoved);
            // 
            // PaidRoomID
            // 
            this.PaidRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomID.DataPropertyName = "MaPhong";
            this.PaidRoomID.HeaderText = "PHÒNG";
            this.PaidRoomID.Name = "PaidRoomID";
            this.PaidRoomID.ReadOnly = true;
            // 
            // PaidRoomRentDays
            // 
            this.PaidRoomRentDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomRentDays.DataPropertyName = "SoNgayThue";
            this.PaidRoomRentDays.HeaderText = "SỐ NGÀY THUÊ";
            this.PaidRoomRentDays.Name = "PaidRoomRentDays";
            this.PaidRoomRentDays.ReadOnly = true;
            // 
            // PaidRoomPrice
            // 
            this.PaidRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomPrice.DataPropertyName = "DonGia";
            this.PaidRoomPrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.PaidRoomPrice.Name = "PaidRoomPrice";
            this.PaidRoomPrice.ReadOnly = true;
            // 
            // OverCustomerTax
            // 
            this.OverCustomerTax.HeaderText = "PHỤ THU KHÁCH THÊM (VND)";
            this.OverCustomerTax.Name = "OverCustomerTax";
            this.OverCustomerTax.ReadOnly = true;
            this.OverCustomerTax.Visible = false;
            // 
            // ForeignCustomerTax
            // 
            this.ForeignCustomerTax.HeaderText = "PHỤ THU KHÁCH NƯỚC NGOÀI (VND)";
            this.ForeignCustomerTax.Name = "ForeignCustomerTax";
            this.ForeignCustomerTax.ReadOnly = true;
            this.ForeignCustomerTax.Visible = false;
            // 
            // PaidRoomTotalPrice
            // 
            this.PaidRoomTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidRoomTotalPrice.DataPropertyName = "ThanhTien";
            this.PaidRoomTotalPrice.HeaderText = "THÀNH TIỀN (VND)";
            this.PaidRoomTotalPrice.Name = "PaidRoomTotalPrice";
            this.PaidRoomTotalPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.gcBillCreate_4.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.btnCancelBillRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 44);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelBillRoom
            // 
            this.btnCancelBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelBillRoom.Enabled = false;
            this.btnCancelBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelBillRoom.ImageOptions.Image")));
            this.btnCancelBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelBillRoom.Location = new System.Drawing.Point(0, 0);
            this.btnCancelBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBillRoom.Name = "btnCancelBillRoom";
            this.btnCancelBillRoom.Size = new System.Drawing.Size(474, 44);
            this.btnCancelBillRoom.TabIndex = 15;
            this.btnCancelBillRoom.Text = "HUỶ HOÁ ĐƠN";
            this.btnCancelBillRoom.Click += new System.EventHandler(this.BtnCancelBillRoom_Click);
            // 
            // panel7
            // 
            this.gcBillCreate_4.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.gcBillRoomData);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(387, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 214);
            this.panel7.TabIndex = 7;
            // 
            // gcBillRoomData
            // 
            this.gcBillRoomData.Controls.Add(this.btnDelBillRoom);
            this.gcBillRoomData.Controls.Add(this.tbBillRoomCost);
            this.gcBillRoomData.Controls.Add(this.tbBillRoomPrice);
            this.gcBillRoomData.Controls.Add(this.tbBillRoomDay);
            this.gcBillRoomData.Controls.Add(this.tbBillRoomID);
            this.gcBillRoomData.Controls.Add(this.lbBillRoomID);
            this.gcBillRoomData.Controls.Add(this.lbBillRoomCost);
            this.gcBillRoomData.Controls.Add(this.lbBillRoomPrice);
            this.gcBillRoomData.Controls.Add(this.lbBillRoomDay);
            this.gcBillRoomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillRoomData.Location = new System.Drawing.Point(0, 0);
            this.gcBillRoomData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBillRoomData.Name = "gcBillRoomData";
            this.gcBillRoomData.Size = new System.Drawing.Size(378, 214);
            this.gcBillRoomData.TabIndex = 6;
            this.gcBillRoomData.Text = "THÔNG TIN PHÒNG";
            // 
            // btnDelBillRoom
            // 
            this.btnDelBillRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelBillRoom.Enabled = false;
            this.btnDelBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelBillRoom.ImageOptions.Image")));
            this.btnDelBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDelBillRoom.Location = new System.Drawing.Point(254, 44);
            this.btnDelBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelBillRoom.Name = "btnDelBillRoom";
            this.btnDelBillRoom.Size = new System.Drawing.Size(106, 143);
            this.btnDelBillRoom.TabIndex = 23;
            this.btnDelBillRoom.Text = "\r\nXÓA";
            this.btnDelBillRoom.Click += new System.EventHandler(this.BtnDelBillRoom_Click);
            // 
            // tbBillRoomCost
            // 
            this.tbBillRoomCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomCost.Location = new System.Drawing.Point(114, 166);
            this.tbBillRoomCost.Name = "tbBillRoomCost";
            this.tbBillRoomCost.ReadOnly = true;
            this.tbBillRoomCost.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomCost.TabIndex = 19;
            this.tbBillRoomCost.TabStop = false;
            // 
            // tbBillRoomPrice
            // 
            this.tbBillRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomPrice.Location = new System.Drawing.Point(114, 126);
            this.tbBillRoomPrice.Name = "tbBillRoomPrice";
            this.tbBillRoomPrice.ReadOnly = true;
            this.tbBillRoomPrice.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomPrice.TabIndex = 20;
            this.tbBillRoomPrice.TabStop = false;
            // 
            // tbBillRoomDay
            // 
            this.tbBillRoomDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomDay.Location = new System.Drawing.Point(114, 84);
            this.tbBillRoomDay.Name = "tbBillRoomDay";
            this.tbBillRoomDay.ReadOnly = true;
            this.tbBillRoomDay.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomDay.TabIndex = 21;
            this.tbBillRoomDay.TabStop = false;
            // 
            // tbBillRoomID
            // 
            this.tbBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBillRoomID.Location = new System.Drawing.Point(114, 44);
            this.tbBillRoomID.Name = "tbBillRoomID";
            this.tbBillRoomID.ReadOnly = true;
            this.tbBillRoomID.Size = new System.Drawing.Size(117, 21);
            this.tbBillRoomID.TabIndex = 22;
            this.tbBillRoomID.TabStop = false;
            // 
            // lbBillRoomID
            // 
            this.lbBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomID.Appearance.Options.UseFont = true;
            this.lbBillRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomID.Location = new System.Drawing.Point(57, 47);
            this.lbBillRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomID.Name = "lbBillRoomID";
            this.lbBillRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbBillRoomID.TabIndex = 15;
            this.lbBillRoomID.Text = "PHÒNG:";
            // 
            // lbBillRoomCost
            // 
            this.lbBillRoomCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomCost.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomCost.Appearance.Options.UseFont = true;
            this.lbBillRoomCost.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomCost.Location = new System.Drawing.Point(31, 169);
            this.lbBillRoomCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomCost.Name = "lbBillRoomCost";
            this.lbBillRoomCost.Size = new System.Drawing.Size(64, 13);
            this.lbBillRoomCost.TabIndex = 18;
            this.lbBillRoomCost.Text = "THÀNH TIỀN:";
            // 
            // lbBillRoomPrice
            // 
            this.lbBillRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomPrice.Appearance.Options.UseFont = true;
            this.lbBillRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomPrice.Location = new System.Drawing.Point(48, 129);
            this.lbBillRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomPrice.Name = "lbBillRoomPrice";
            this.lbBillRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbBillRoomPrice.TabIndex = 17;
            this.lbBillRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbBillRoomDay
            // 
            this.lbBillRoomDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillRoomDay.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillRoomDay.Appearance.Options.UseFont = true;
            this.lbBillRoomDay.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillRoomDay.Location = new System.Drawing.Point(19, 87);
            this.lbBillRoomDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillRoomDay.Name = "lbBillRoomDay";
            this.lbBillRoomDay.Size = new System.Drawing.Size(77, 13);
            this.lbBillRoomDay.TabIndex = 16;
            this.lbBillRoomDay.Text = "SỐ NGÀY THUÊ:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gcAddBillRoom);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(771, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 214);
            this.panel6.TabIndex = 9;
            // 
            // gcAddBillRoom
            // 
            this.gcAddBillRoom.Controls.Add(this.lbAddBillRoomID);
            this.gcAddBillRoom.Controls.Add(this.cbAddBillRoomID);
            this.gcAddBillRoom.Controls.Add(this.btnAddBillRoom);
            this.gcAddBillRoom.Controls.Add(this.labelControl10);
            this.gcAddBillRoom.Controls.Add(this.labelControl12);
            this.gcAddBillRoom.Controls.Add(this.labelControl14);
            this.gcAddBillRoom.Controls.Add(this.labelControl13);
            this.gcAddBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAddBillRoom.Location = new System.Drawing.Point(0, 0);
            this.gcAddBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcAddBillRoom.Name = "gcAddBillRoom";
            this.gcAddBillRoom.Size = new System.Drawing.Size(181, 214);
            this.gcAddBillRoom.TabIndex = 7;
            this.gcAddBillRoom.Text = "THÊM PHÒNG THANH TOÁN";
            // 
            // lbAddBillRoomID
            // 
            this.lbAddBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAddBillRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAddBillRoomID.Appearance.Options.UseFont = true;
            this.lbAddBillRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAddBillRoomID.Location = new System.Drawing.Point(55, 47);
            this.lbAddBillRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAddBillRoomID.Name = "lbAddBillRoomID";
            this.lbAddBillRoomID.Size = new System.Drawing.Size(71, 13);
            this.lbAddBillRoomID.TabIndex = 21;
            this.lbAddBillRoomID.Text = "CHỌN PHÒNG:";
            // 
            // cbAddBillRoomID
            // 
            this.cbAddBillRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAddBillRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddBillRoomID.Enabled = false;
            this.cbAddBillRoomID.FormattingEnabled = true;
            this.cbAddBillRoomID.Location = new System.Drawing.Point(27, 84);
            this.cbAddBillRoomID.Name = "cbAddBillRoomID";
            this.cbAddBillRoomID.Size = new System.Drawing.Size(120, 21);
            this.cbAddBillRoomID.Sorted = true;
            this.cbAddBillRoomID.TabIndex = 20;
            // 
            // btnAddBillRoom
            // 
            this.btnAddBillRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBillRoom.Enabled = false;
            this.btnAddBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBillRoom.ImageOptions.Image")));
            this.btnAddBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddBillRoom.Location = new System.Drawing.Point(27, 123);
            this.btnAddBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBillRoom.Name = "btnAddBillRoom";
            this.btnAddBillRoom.Size = new System.Drawing.Size(120, 64);
            this.btnAddBillRoom.TabIndex = 19;
            this.btnAddBillRoom.Text = "THÊM";
            this.btnAddBillRoom.Click += new System.EventHandler(this.BtnAddBillRoom_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl10.Location = new System.Drawing.Point(-242, -89);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 13);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "PHÒNG:";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl12.Location = new System.Drawing.Point(-251, -7);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "ĐƠN GIÁ:";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl14.Location = new System.Drawing.Point(-155, -89);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(107, 13);
            this.labelControl14.TabIndex = 15;
            this.labelControl14.Text = "PHÒNG THANH TOÁN:";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl13.Location = new System.Drawing.Point(-280, -49);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(77, 13);
            this.labelControl13.TabIndex = 16;
            this.labelControl13.Text = "SỐ NGÀY THUÊ:";
            // 
            // panel3
            // 
            this.gcBillCreate_4.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.btnCreateBillRoom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(483, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 44);
            this.panel3.TabIndex = 10;
            // 
            // btnCreateBillRoom
            // 
            this.btnCreateBillRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateBillRoom.Enabled = false;
            this.btnCreateBillRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBillRoom.ImageOptions.Image")));
            this.btnCreateBillRoom.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateBillRoom.Location = new System.Drawing.Point(0, 0);
            this.btnCreateBillRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBillRoom.Name = "btnCreateBillRoom";
            this.btnCreateBillRoom.Size = new System.Drawing.Size(469, 44);
            this.btnCreateBillRoom.TabIndex = 27;
            this.btnCreateBillRoom.Text = "LẬP HOÁ ĐƠN";
            this.btnCreateBillRoom.Click += new System.EventHandler(this.BtnCreateBillRoom_Click);
            // 
            // tabRevenueRoom
            // 
            this.tabRevenueRoom.Controls.Add(this.tableLayoutPanel5);
            this.tabRevenueRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRevenueRoom.ImageOptions.Image")));
            this.tabRevenueRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRevenueRoom.Name = "tabRevenueRoom";
            this.tabRevenueRoom.Size = new System.Drawing.Size(955, 646);
            this.tabRevenueRoom.Text = "BÁO CÁO DOANH THU";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gcRevenueSelect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gcRevenueList, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(955, 646);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // gcRevenueSelect
            // 
            this.gcRevenueSelect.Controls.Add(this.nudRevenue);
            this.gcRevenueSelect.Controls.Add(this.btnCreateMonthRevenue);
            this.gcRevenueSelect.Controls.Add(this.lbMonthRevenue);
            this.gcRevenueSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRevenueSelect.Location = new System.Drawing.Point(3, 2);
            this.gcRevenueSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRevenueSelect.Name = "gcRevenueSelect";
            this.gcRevenueSelect.Size = new System.Drawing.Size(949, 216);
            this.gcRevenueSelect.TabIndex = 0;
            this.gcRevenueSelect.Text = "TRA CỨU DOANH THU";
            // 
            // nudRevenue
            // 
            this.nudRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudRevenue.Location = new System.Drawing.Point(364, 100);
            this.nudRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRevenue.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudRevenue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRevenue.Name = "nudRevenue";
            this.nudRevenue.Size = new System.Drawing.Size(184, 21);
            this.nudRevenue.TabIndex = 1;
            this.nudRevenue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreateMonthRevenue
            // 
            this.btnCreateMonthRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateMonthRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMonthRevenue.ImageOptions.Image")));
            this.btnCreateMonthRevenue.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateMonthRevenue.Location = new System.Drawing.Point(570, 87);
            this.btnCreateMonthRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateMonthRevenue.Name = "btnCreateMonthRevenue";
            this.btnCreateMonthRevenue.Size = new System.Drawing.Size(120, 41);
            this.btnCreateMonthRevenue.TabIndex = 2;
            this.btnCreateMonthRevenue.Text = "XUẤT";
            this.btnCreateMonthRevenue.Click += new System.EventHandler(this.BtnCreateMonthRevenue_Click);
            // 
            // lbMonthRevenue
            // 
            this.lbMonthRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMonthRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMonthRevenue.Appearance.Options.UseFont = true;
            this.lbMonthRevenue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMonthRevenue.Location = new System.Drawing.Point(258, 101);
            this.lbMonthRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMonthRevenue.Name = "lbMonthRevenue";
            this.lbMonthRevenue.Size = new System.Drawing.Size(100, 13);
            this.lbMonthRevenue.TabIndex = 0;
            this.lbMonthRevenue.Text = "DOANH THU THÁNG:";
            // 
            // gcRevenueList
            // 
            this.gcRevenueList.Controls.Add(this.dgvRevenueList);
            this.gcRevenueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRevenueList.Location = new System.Drawing.Point(3, 222);
            this.gcRevenueList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRevenueList.Name = "gcRevenueList";
            this.gcRevenueList.Size = new System.Drawing.Size(949, 422);
            this.gcRevenueList.TabIndex = 1;
            this.gcRevenueList.Text = "DANH MỤC DOANH THU";
            // 
            // dgvRevenueList
            // 
            this.dgvRevenueList.AllowUserToAddRows = false;
            this.dgvRevenueList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevenueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportedRoomType,
            this.ReportedRoomRevenue,
            this.ReportedRoomPercentage});
            this.dgvRevenueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenueList.Location = new System.Drawing.Point(2, 20);
            this.dgvRevenueList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRevenueList.Name = "dgvRevenueList";
            this.dgvRevenueList.ReadOnly = true;
            this.dgvRevenueList.RowTemplate.Height = 24;
            this.dgvRevenueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenueList.Size = new System.Drawing.Size(945, 400);
            this.dgvRevenueList.TabIndex = 2;
            this.dgvRevenueList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // tabRules
            // 
            this.tabRules.Controls.Add(this.gcEditRule);
            this.tabRules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabRules.ImageOptions.Image")));
            this.tabRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRules.Name = "tabRules";
            this.tabRules.Size = new System.Drawing.Size(955, 646);
            this.tabRules.Text = "TÙY CHỈNH";
            // 
            // gcEditRule
            // 
            this.gcEditRule.Controls.Add(this.tableLayoutPanel6);
            this.gcEditRule.Controls.Add(this.simpleButton19);
            this.gcEditRule.Controls.Add(this.simpleButton18);
            this.gcEditRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEditRule.Location = new System.Drawing.Point(0, 0);
            this.gcEditRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcEditRule.Name = "gcEditRule";
            this.gcEditRule.Size = new System.Drawing.Size(955, 646);
            this.gcEditRule.TabIndex = 1;
            this.gcEditRule.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.gcCustomerTypeList, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.gcRoomTypeList, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panelEditRules, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.65664F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.34336F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(951, 624);
            this.tableLayoutPanel6.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnEditCustomerType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelCustomerType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddCustomerType, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(478, 576);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 45);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // btnEditCustomerType
            // 
            this.btnEditCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerType.Appearance.Image")));
            this.btnEditCustomerType.Appearance.Options.UseImage = true;
            this.btnEditCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerType.ImageOptions.Image")));
            this.btnEditCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditCustomerType.Location = new System.Drawing.Point(315, 2);
            this.btnEditCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCustomerType.Name = "btnEditCustomerType";
            this.btnEditCustomerType.Size = new System.Drawing.Size(152, 41);
            this.btnEditCustomerType.TabIndex = 5;
            this.btnEditCustomerType.Text = "SỬA LOẠI KHÁCH";
            this.btnEditCustomerType.Click += new System.EventHandler(this.BtnEditCustomerType_Click);
            // 
            // btnDelCustomerType
            // 
            this.btnDelCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCustomerType.Appearance.Image")));
            this.btnDelCustomerType.Appearance.Options.UseImage = true;
            this.btnDelCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCustomerType.ImageOptions.Image")));
            this.btnDelCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelCustomerType.Location = new System.Drawing.Point(159, 2);
            this.btnDelCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCustomerType.Name = "btnDelCustomerType";
            this.btnDelCustomerType.Size = new System.Drawing.Size(150, 41);
            this.btnDelCustomerType.TabIndex = 4;
            this.btnDelCustomerType.Text = "XOÁ LOẠI KHÁCH";
            this.btnDelCustomerType.Click += new System.EventHandler(this.BtnDelCustomerType_Click);
            // 
            // btnAddCustomerType
            // 
            this.btnAddCustomerType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerType.Appearance.Image")));
            this.btnAddCustomerType.Appearance.Options.UseImage = true;
            this.btnAddCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomerType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerType.ImageOptions.Image")));
            this.btnAddCustomerType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCustomerType.Location = new System.Drawing.Point(3, 2);
            this.btnAddCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomerType.Name = "btnAddCustomerType";
            this.btnAddCustomerType.Size = new System.Drawing.Size(150, 41);
            this.btnAddCustomerType.TabIndex = 3;
            this.btnAddCustomerType.Text = "THÊM LOẠI KHÁCH";
            this.btnAddCustomerType.Click += new System.EventHandler(this.BtnAddCustomerType_Click);
            // 
            // gcCustomerTypeList
            // 
            this.gcCustomerTypeList.Controls.Add(this.dgvCustomerType);
            this.gcCustomerTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerTypeList.Location = new System.Drawing.Point(478, 120);
            this.gcCustomerTypeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCustomerTypeList.Name = "gcCustomerTypeList";
            this.gcCustomerTypeList.Size = new System.Drawing.Size(470, 451);
            this.gcCustomerTypeList.TabIndex = 30;
            this.gcCustomerTypeList.Text = "DANH MỤC CÁC LOẠI KHÁCH";
            // 
            // dgvCustomerType
            // 
            this.dgvCustomerType.AllowUserToAddRows = false;
            this.dgvCustomerType.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCustomerTypeID,
            this.EditCustomerType});
            this.dgvCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerType.Location = new System.Drawing.Point(2, 20);
            this.dgvCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomerType.Name = "dgvCustomerType";
            this.dgvCustomerType.RowTemplate.Height = 24;
            this.dgvCustomerType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerType.Size = new System.Drawing.Size(466, 429);
            this.dgvCustomerType.TabIndex = 0;
            this.dgvCustomerType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // gcRoomTypeList
            // 
            this.gcRoomTypeList.Controls.Add(this.dgvRoomType);
            this.gcRoomTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomTypeList.Location = new System.Drawing.Point(3, 120);
            this.gcRoomTypeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRoomTypeList.Name = "gcRoomTypeList";
            this.gcRoomTypeList.Size = new System.Drawing.Size(469, 451);
            this.gcRoomTypeList.TabIndex = 17;
            this.gcRoomTypeList.Text = "ĐƠN GIÁ CÁC LOẠI PHÒNG";
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.AllowUserToAddRows = false;
            this.dgvRoomType.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditRoomTypeID,
            this.EditRoomTypePrice});
            this.dgvRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomType.Location = new System.Drawing.Point(2, 20);
            this.dgvRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            this.dgvRoomType.RowTemplate.Height = 24;
            this.dgvRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomType.Size = new System.Drawing.Size(465, 429);
            this.dgvRoomType.TabIndex = 0;
            this.dgvRoomType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // panelEditRules
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.panelEditRules, 2);
            this.panelEditRules.Controls.Add(this.lbMaxCustomerRule);
            this.panelEditRules.Controls.Add(this.lbMaxCustomerValue);
            this.panelEditRules.Controls.Add(this.lbForeignCustomerTaxValue);
            this.panelEditRules.Controls.Add(this.lbOverCustomerTaxValue);
            this.panelEditRules.Controls.Add(this.btnEditMaxCustomerRule);
            this.panelEditRules.Controls.Add(this.btnEditForeignCustomerTax);
            this.panelEditRules.Controls.Add(this.lbForeignCustomerTax);
            this.panelEditRules.Controls.Add(this.btnEditThirdCustomerTax);
            this.panelEditRules.Controls.Add(this.lbOverCustumerRuleTax);
            this.panelEditRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditRules.Location = new System.Drawing.Point(3, 2);
            this.panelEditRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEditRules.Name = "panelEditRules";
            this.panelEditRules.Size = new System.Drawing.Size(945, 114);
            this.panelEditRules.TabIndex = 0;
            // 
            // lbMaxCustomerRule
            // 
            this.lbMaxCustomerRule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomerRule.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomerRule.Appearance.Options.UseFont = true;
            this.lbMaxCustomerRule.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomerRule.Location = new System.Drawing.Point(322, 21);
            this.lbMaxCustomerRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaxCustomerRule.Name = "lbMaxCustomerRule";
            this.lbMaxCustomerRule.Size = new System.Drawing.Size(155, 13);
            this.lbMaxCustomerRule.TabIndex = 29;
            this.lbMaxCustomerRule.Text = "SỐ KHÁCH TỐI ĐA MỖI PHÒNG:";
            // 
            // lbMaxCustomerValue
            // 
            this.lbMaxCustomerValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomerValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomerValue.Appearance.Options.UseFont = true;
            this.lbMaxCustomerValue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomerValue.Location = new System.Drawing.Point(481, 21);
            this.lbMaxCustomerValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaxCustomerValue.Name = "lbMaxCustomerValue";
            this.lbMaxCustomerValue.Size = new System.Drawing.Size(5, 13);
            this.lbMaxCustomerValue.TabIndex = 30;
            this.lbMaxCustomerValue.Text = "?";
            // 
            // lbForeignCustomerTaxValue
            // 
            this.lbForeignCustomerTaxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbForeignCustomerTaxValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbForeignCustomerTaxValue.Appearance.Options.UseFont = true;
            this.lbForeignCustomerTaxValue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbForeignCustomerTaxValue.Location = new System.Drawing.Point(481, 81);
            this.lbForeignCustomerTaxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbForeignCustomerTaxValue.Name = "lbForeignCustomerTaxValue";
            this.lbForeignCustomerTaxValue.Size = new System.Drawing.Size(5, 13);
            this.lbForeignCustomerTaxValue.TabIndex = 32;
            this.lbForeignCustomerTaxValue.Text = "?";
            // 
            // lbOverCustomerTaxValue
            // 
            this.lbOverCustomerTaxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOverCustomerTaxValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOverCustomerTaxValue.Appearance.Options.UseFont = true;
            this.lbOverCustomerTaxValue.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbOverCustomerTaxValue.Location = new System.Drawing.Point(443, 51);
            this.lbOverCustomerTaxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOverCustomerTaxValue.Name = "lbOverCustomerTaxValue";
            this.lbOverCustomerTaxValue.Size = new System.Drawing.Size(5, 13);
            this.lbOverCustomerTaxValue.TabIndex = 32;
            this.lbOverCustomerTaxValue.Text = "?";
            // 
            // btnEditMaxCustomerRule
            // 
            this.btnEditMaxCustomerRule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditMaxCustomerRule.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMaxCustomerRule.Appearance.Image")));
            this.btnEditMaxCustomerRule.Appearance.Options.UseImage = true;
            this.btnEditMaxCustomerRule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMaxCustomerRule.ImageOptions.Image")));
            this.btnEditMaxCustomerRule.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditMaxCustomerRule.Location = new System.Drawing.Point(526, 14);
            this.btnEditMaxCustomerRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMaxCustomerRule.Name = "btnEditMaxCustomerRule";
            this.btnEditMaxCustomerRule.Size = new System.Drawing.Size(96, 24);
            this.btnEditMaxCustomerRule.TabIndex = 1;
            this.btnEditMaxCustomerRule.Text = "THAY ĐỔI";
            this.btnEditMaxCustomerRule.Click += new System.EventHandler(this.BtnEditMaxCustomerRule_Click);
            // 
            // btnEditForeignCustomerTax
            // 
            this.btnEditForeignCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditForeignCustomerTax.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditForeignCustomerTax.Appearance.Image")));
            this.btnEditForeignCustomerTax.Appearance.Options.UseImage = true;
            this.btnEditForeignCustomerTax.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditForeignCustomerTax.ImageOptions.Image")));
            this.btnEditForeignCustomerTax.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditForeignCustomerTax.Location = new System.Drawing.Point(526, 74);
            this.btnEditForeignCustomerTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditForeignCustomerTax.Name = "btnEditForeignCustomerTax";
            this.btnEditForeignCustomerTax.Size = new System.Drawing.Size(96, 24);
            this.btnEditForeignCustomerTax.TabIndex = 2;
            this.btnEditForeignCustomerTax.Text = "THAY ĐỔI";
            this.btnEditForeignCustomerTax.Click += new System.EventHandler(this.BtnEditForeignCustomerTax_Click);
            // 
            // lbForeignCustomerTax
            // 
            this.lbForeignCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbForeignCustomerTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbForeignCustomerTax.Appearance.Options.UseFont = true;
            this.lbForeignCustomerTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbForeignCustomerTax.Location = new System.Drawing.Point(322, 81);
            this.lbForeignCustomerTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbForeignCustomerTax.Name = "lbForeignCustomerTax";
            this.lbForeignCustomerTax.Size = new System.Drawing.Size(153, 13);
            this.lbForeignCustomerTax.TabIndex = 31;
            this.lbForeignCustomerTax.Text = "PHỤ THU KHÁCH NƯỚC NGOÀI:";
            // 
            // btnEditThirdCustomerTax
            // 
            this.btnEditThirdCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditThirdCustomerTax.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditThirdCustomerTax.Appearance.Image")));
            this.btnEditThirdCustomerTax.Appearance.Options.UseImage = true;
            this.btnEditThirdCustomerTax.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditThirdCustomerTax.ImageOptions.Image")));
            this.btnEditThirdCustomerTax.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditThirdCustomerTax.Location = new System.Drawing.Point(526, 44);
            this.btnEditThirdCustomerTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditThirdCustomerTax.Name = "btnEditThirdCustomerTax";
            this.btnEditThirdCustomerTax.Size = new System.Drawing.Size(96, 24);
            this.btnEditThirdCustomerTax.TabIndex = 2;
            this.btnEditThirdCustomerTax.Text = "THAY ĐỔI";
            this.btnEditThirdCustomerTax.Click += new System.EventHandler(this.BtnEditThirdCustomerTax_Click);
            // 
            // lbOverCustumerRuleTax
            // 
            this.lbOverCustumerRuleTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOverCustumerRuleTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOverCustumerRuleTax.Appearance.Options.UseFont = true;
            this.lbOverCustumerRuleTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbOverCustumerRuleTax.Location = new System.Drawing.Point(322, 51);
            this.lbOverCustumerRuleTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOverCustumerRuleTax.Name = "lbOverCustumerRuleTax";
            this.lbOverCustumerRuleTax.Size = new System.Drawing.Size(120, 13);
            this.lbOverCustumerRuleTax.TabIndex = 31;
            this.lbOverCustumerRuleTax.Text = "PHỤ THU KHÁCH THỨ 3: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditRoomType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelRoomType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRoomType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 576);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 45);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // btnEditRoomType
            // 
            this.btnEditRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoomType.Appearance.Image")));
            this.btnEditRoomType.Appearance.Options.UseImage = true;
            this.btnEditRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoomType.ImageOptions.Image")));
            this.btnEditRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditRoomType.Location = new System.Drawing.Point(315, 2);
            this.btnEditRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRoomType.Name = "btnEditRoomType";
            this.btnEditRoomType.Size = new System.Drawing.Size(151, 41);
            this.btnEditRoomType.TabIndex = 4;
            this.btnEditRoomType.Text = "SỬA LOẠI PHÒNG";
            this.btnEditRoomType.Click += new System.EventHandler(this.BtnEditRoomType_Click);
            // 
            // btnDelRoomType
            // 
            this.btnDelRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoomType.Appearance.Image")));
            this.btnDelRoomType.Appearance.Options.UseImage = true;
            this.btnDelRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoomType.ImageOptions.Image")));
            this.btnDelRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelRoomType.Location = new System.Drawing.Point(159, 2);
            this.btnDelRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelRoomType.Name = "btnDelRoomType";
            this.btnDelRoomType.Size = new System.Drawing.Size(150, 41);
            this.btnDelRoomType.TabIndex = 3;
            this.btnDelRoomType.Text = "XOÁ LOẠI PHÒNG";
            this.btnDelRoomType.Click += new System.EventHandler(this.BtnDelRoomType_Click);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoomType.Appearance.Image")));
            this.btnAddRoomType.Appearance.Options.UseImage = true;
            this.btnAddRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoomType.ImageOptions.Image")));
            this.btnAddRoomType.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddRoomType.Location = new System.Drawing.Point(3, 2);
            this.btnAddRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(150, 41);
            this.btnAddRoomType.TabIndex = 2;
            this.btnAddRoomType.Text = "THÊM LOẠI PHÒNG";
            this.btnAddRoomType.Click += new System.EventHandler(this.BtnAddRoomType_Click);
            // 
            // simpleButton19
            // 
            this.simpleButton19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton19.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton19.ImageOptions.Image")));
            this.simpleButton19.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton19.Location = new System.Drawing.Point(515, 609);
            this.simpleButton19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton19.Name = "simpleButton19";
            this.simpleButton19.Size = new System.Drawing.Size(433, 28);
            this.simpleButton19.TabIndex = 25;
            this.simpleButton19.Text = "TÙY CHỈNH KHÁCH";
            // 
            // simpleButton18
            // 
            this.simpleButton18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton18.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton18.ImageOptions.Image")));
            this.simpleButton18.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton18.Location = new System.Drawing.Point(6, 609);
            this.simpleButton18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(502, 28);
            this.simpleButton18.TabIndex = 24;
            this.simpleButton18.Text = "TÙY CHỈNH LOẠI PHÒNG";
            // 
            // ReportedRoomType
            // 
            this.ReportedRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomType.DataPropertyName = "LoaiPhong";
            this.ReportedRoomType.HeaderText = "LOẠI PHÒNG";
            this.ReportedRoomType.Name = "ReportedRoomType";
            this.ReportedRoomType.ReadOnly = true;
            // 
            // ReportedRoomRevenue
            // 
            this.ReportedRoomRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomRevenue.DataPropertyName = "DoanhThu";
            this.ReportedRoomRevenue.HeaderText = "DOANH THU (VND)";
            this.ReportedRoomRevenue.Name = "ReportedRoomRevenue";
            this.ReportedRoomRevenue.ReadOnly = true;
            // 
            // ReportedRoomPercentage
            // 
            this.ReportedRoomPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportedRoomPercentage.DataPropertyName = "TiLe";
            this.ReportedRoomPercentage.HeaderText = "TỈ LỆ (%)";
            this.ReportedRoomPercentage.Name = "ReportedRoomPercentage";
            this.ReportedRoomPercentage.ReadOnly = true;
            // 
            // EditRoomTypeID
            // 
            this.EditRoomTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditRoomTypeID.DataPropertyName = "MaLoaiPhong";
            this.EditRoomTypeID.HeaderText = "LOẠI PHÒNG";
            this.EditRoomTypeID.Name = "EditRoomTypeID";
            this.EditRoomTypeID.ReadOnly = true;
            // 
            // EditRoomTypePrice
            // 
            this.EditRoomTypePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditRoomTypePrice.DataPropertyName = "DonGia";
            this.EditRoomTypePrice.HeaderText = "ĐƠN GIÁ (VND)";
            this.EditRoomTypePrice.Name = "EditRoomTypePrice";
            this.EditRoomTypePrice.ReadOnly = true;
            // 
            // EditCustomerTypeID
            // 
            this.EditCustomerTypeID.DataPropertyName = "MaLoaiKhach";
            this.EditCustomerTypeID.HeaderText = "MÃ LOẠI KHÁCH";
            this.EditCustomerTypeID.Name = "EditCustomerTypeID";
            this.EditCustomerTypeID.Visible = false;
            // 
            // EditCustomerType
            // 
            this.EditCustomerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditCustomerType.DataPropertyName = "TenLoaiKhach";
            this.EditCustomerType.HeaderText = "LOẠI KHÁCH";
            this.EditCustomerType.Name = "EditCustomerType";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(961, 693);
            this.Controls.Add(this.tcHotelManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ KHÁCH SẠN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcHotelManagement)).EndInit();
            this.tcHotelManagement.ResumeLayout(false);
            this.tabListRoom.ResumeLayout(false);
            this.tlpListRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomData)).EndInit();
            this.gcRoomData.ResumeLayout(false);
            this.gcRoomData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoom)).EndInit();
            this.gcListRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListRoomEdit)).EndInit();
            this.gcListRoomEdit.ResumeLayout(false);
            this.tabNoteRoom.ResumeLayout(false);
            this.tlpNoteRoom.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteRoom)).EndInit();
            this.gcNoteRoom.ResumeLayout(false);
            this.gcNoteRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNoteRoomDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNoteRoomDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteCustomer)).EndInit();
            this.gcNoteCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoteCustomerData)).EndInit();
            this.gcNoteCustomerData.ResumeLayout(false);
            this.gcNoteCustomerData.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEditNoteCustomer)).EndInit();
            this.gcEditNoteCustomer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabFindRoom.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoomData)).EndInit();
            this.gcFindRoomData.ResumeLayout(false);
            this.gcFindRoomData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindRoom)).EndInit();
            this.gcFindRoom.ResumeLayout(false);
            this.gcFindRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).EndInit();
            this.gcRoomList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindRoom)).EndInit();
            this.tabBillRoom.ResumeLayout(false);
            this.gcBillCreate_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            this.gcBill.ResumeLayout(false);
            this.gcBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillRoom)).EndInit();
            this.gcBillRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBillRoomData)).EndInit();
            this.gcBillRoomData.ResumeLayout(false);
            this.gcBillRoomData.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAddBillRoom)).EndInit();
            this.gcAddBillRoom.ResumeLayout(false);
            this.gcAddBillRoom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabRevenueRoom.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenueSelect)).EndInit();
            this.gcRevenueSelect.ResumeLayout(false);
            this.gcRevenueSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenueList)).EndInit();
            this.gcRevenueList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueList)).EndInit();
            this.tabRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEditRule)).EndInit();
            this.gcEditRule.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerTypeList)).EndInit();
            this.gcCustomerTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomTypeList)).EndInit();
            this.gcRoomTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.panelEditRules.ResumeLayout(false);
            this.panelEditRules.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcHotelManagement;
        private DevExpress.XtraTab.XtraTabPage tabListRoom;
        private DevExpress.XtraTab.XtraTabPage tabFindRoom;
        private DevExpress.XtraTab.XtraTabPage tabBillRoom;
        private DevExpress.XtraTab.XtraTabPage tabRevenueRoom;
        private System.Windows.Forms.TableLayoutPanel tlpListRoom;
        private DevExpress.XtraEditors.GroupControl gcRoomData;
        private DevExpress.XtraEditors.GroupControl gcListRoom;
        private System.Windows.Forms.DataGridView dgvListRoom;
        private System.Windows.Forms.TextBox tbListRoomID;
        private DevExpress.XtraEditors.LabelControl lbListRoomType;
        private DevExpress.XtraEditors.LabelControl lbListRoomID;
        private System.Windows.Forms.RichTextBox rtbListRoomNote;
        private DevExpress.XtraEditors.LabelControl lbListRoomNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.GroupControl gcRoomList;
        private System.Windows.Forms.DataGridView dgvFindRoom;
        private System.Windows.Forms.TableLayoutPanel gcBillCreate_4;
        private DevExpress.XtraEditors.GroupControl gcBill;
        private DevExpress.XtraEditors.DateEdit deBillDate;
        private DevExpress.XtraEditors.LabelControl lbBillCustomerAddress;
        private System.Windows.Forms.TextBox tbBillCustomerName;
        private System.Windows.Forms.RichTextBox rtbBillCustomerAddress;
        private DevExpress.XtraEditors.LabelControl lbBillCustomerName;
        private DevExpress.XtraEditors.GroupControl gcBillRoom;
        private System.Windows.Forms.DataGridView dgvBillRoom;
        private DevExpress.XtraEditors.LabelControl lbBillDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.GroupControl gcRevenueSelect;
        private DevExpress.XtraEditors.SimpleButton btnCreateMonthRevenue;
        private DevExpress.XtraEditors.LabelControl lbMonthRevenue;
        private DevExpress.XtraEditors.GroupControl gcRevenueList;
        private System.Windows.Forms.DataGridView dgvRevenueList;
        private System.Windows.Forms.NumericUpDown nudRevenue;
        private DevExpress.XtraTab.XtraTabPage tabRules;
        private DevExpress.XtraEditors.GroupControl gcEditRule;
        private DevExpress.XtraEditors.SimpleButton simpleButton19;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.GroupControl gcCustomerTypeList;
        private System.Windows.Forms.DataGridView dgvCustomerType;
        private DevExpress.XtraEditors.GroupControl gcRoomTypeList;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.TextBox tbListRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbListRoomPrice;
        private System.Windows.Forms.TextBox tbListRoomType;
        private DevExpress.XtraEditors.GroupControl gcFindRoomData;
        private DevExpress.XtraEditors.LabelControl lbFindRoomID2;
        private DevExpress.XtraEditors.LabelControl lbFindRoomStatus2;
        private DevExpress.XtraEditors.LabelControl lbFindRoomPrice2;
        private DevExpress.XtraEditors.LabelControl lbFindRoomType2;
        private DevExpress.XtraEditors.GroupControl gcFindRoom;
        private System.Windows.Forms.ComboBox cbFindRoomPrice;
        private System.Windows.Forms.ComboBox cbFindRoomStatus;
        private System.Windows.Forms.ComboBox cbFindRoomID;
        private DevExpress.XtraEditors.LabelControl lbFindRoomID;
        private DevExpress.XtraEditors.LabelControl lbFindRoomStatus;
        private DevExpress.XtraEditors.LabelControl lbFindRoomPrice;
        private DevExpress.XtraEditors.SimpleButton btnFindRoom;
        private DevExpress.XtraEditors.LabelControl lbFindRoomType;
        private System.Windows.Forms.ComboBox cbFindRoomType;
        private System.Windows.Forms.TextBox tbFindRoomStatus;
        private System.Windows.Forms.TextBox tbFindRoomPrice;
        private System.Windows.Forms.TextBox tbFindRoomType;
        private System.Windows.Forms.TextBox tbFindRoomID;
        private DevExpress.XtraEditors.SimpleButton btnLockBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnCancelBillRoom;
        private DevExpress.XtraEditors.GroupControl gcBillRoomData;
        private DevExpress.XtraEditors.SimpleButton btnDelBillRoom;
        private System.Windows.Forms.TextBox tbBillRoomCost;
        private System.Windows.Forms.TextBox tbBillRoomPrice;
        private System.Windows.Forms.TextBox tbBillRoomDay;
        private System.Windows.Forms.TextBox tbBillRoomID;
        private DevExpress.XtraEditors.LabelControl lbBillRoomID;
        private DevExpress.XtraEditors.LabelControl lbBillRoomCost;
        private DevExpress.XtraEditors.LabelControl lbBillRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbBillRoomDay;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.GroupControl gcAddBillRoom;
        private DevExpress.XtraEditors.LabelControl lbAddBillRoomID;
        private System.Windows.Forms.ComboBox cbAddBillRoomID;
        private DevExpress.XtraEditors.SimpleButton btnAddBillRoom;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnCreateBillRoom;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.GroupControl gcListRoomEdit;
        private DevExpress.XtraEditors.SimpleButton btnEditRoom;
        private DevExpress.XtraEditors.SimpleButton btnDelRoom;
        private DevExpress.XtraTab.XtraTabPage tabNoteRoom;
        private System.Windows.Forms.TableLayoutPanel tlpNoteRoom;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnCancelNote;
        private DevExpress.XtraEditors.GroupControl gcNoteRoom;
        private System.Windows.Forms.TextBox tbNoteRoomPrice;
        private System.Windows.Forms.ComboBox cbNoteRoomID;
        private DevExpress.XtraEditors.LabelControl lbNoteRoomID;
        private DevExpress.XtraEditors.DateEdit deNoteRoomDate;
        private DevExpress.XtraEditors.LabelControl lbNoteRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbNoteRoomDate;
        private DevExpress.XtraEditors.SimpleButton btnLockNoteRoom;
        private DevExpress.XtraEditors.GroupControl gcNoteCustomer;
        private System.Windows.Forms.DataGridView dgvNoteCustomer;
        private DevExpress.XtraEditors.GroupControl gcNoteCustomerData;
        private System.Windows.Forms.TextBox tbNoteCustomerType;
        private System.Windows.Forms.TextBox tbNoteCustomerPassport;
        private DevExpress.XtraEditors.LabelControl lbNoteCustomerAddress;
        private System.Windows.Forms.TextBox tbNoteCustomerName;
        private System.Windows.Forms.RichTextBox rtbNoteCustomerAddress;
        private DevExpress.XtraEditors.LabelControl lbNoteCustomerPassport;
        private DevExpress.XtraEditors.LabelControl lbNoteCustomerName;
        private DevExpress.XtraEditors.LabelControl lbNoteCustomerType;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.GroupControl gcEditNoteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnEditNoteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnDelNoteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAddNoteCustomer;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnCreateNote;
        private System.Windows.Forms.Panel panelEditRules;
        private DevExpress.XtraEditors.LabelControl lbMaxCustomerRule;
        private DevExpress.XtraEditors.LabelControl lbMaxCustomerValue;
        private DevExpress.XtraEditors.LabelControl lbForeignCustomerTaxValue;
        private DevExpress.XtraEditors.LabelControl lbOverCustomerTaxValue;
        private DevExpress.XtraEditors.SimpleButton btnEditMaxCustomerRule;
        private DevExpress.XtraEditors.SimpleButton btnEditForeignCustomerTax;
        private DevExpress.XtraEditors.LabelControl lbForeignCustomerTax;
        private DevExpress.XtraEditors.SimpleButton btnEditThirdCustomerTax;
        private DevExpress.XtraEditors.LabelControl lbOverCustumerRuleTax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnDelCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomerType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnEditRoomType;
        private DevExpress.XtraEditors.SimpleButton btnDelRoomType;
        private DevExpress.XtraEditors.SimpleButton btnAddRoomType;
        private DevExpress.XtraEditors.SimpleButton btnAddRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNote;
        private System.Windows.Forms.TextBox tbListRoomStatus;
        private DevExpress.XtraEditors.LabelControl lbListRoomStatus;
        private System.Windows.Forms.RichTextBox rtbFindRoomNote;
        private DevExpress.XtraEditors.LabelControl lbFindRoomNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FindRoomNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomRentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidRoomTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPassportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedRoomPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditRoomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditRoomTypePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCustomerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCustomerType;
    }
}

