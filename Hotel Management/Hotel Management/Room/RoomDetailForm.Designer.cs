namespace GUI.Room
{
    partial class RoomDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetailForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcCustomerList = new DevExpress.XtraEditors.GroupControl();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPassportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbRoomDate = new System.Windows.Forms.TextBox();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomDate = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.imgEditRoom = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomDetailHeader = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).BeginInit();
            this.gcCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 45);
            this.panel4.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(386, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "HUỶ BỎ";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.gcCustomerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 253);
            this.panel1.TabIndex = 0;
            // 
            // gcCustomerList
            // 
            this.gcCustomerList.Controls.Add(this.dgvCustomerData);
            this.gcCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerList.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCustomerList.Name = "gcCustomerList";
            this.gcCustomerList.Size = new System.Drawing.Size(778, 253);
            this.gcCustomerList.TabIndex = 2;
            this.gcCustomerList.Text = "DANH MỤC KHÁCH THUÊ PHÒNG";
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AllowUserToAddRows = false;
            this.dgvCustomerData.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerType,
            this.CustomerPassportID,
            this.CustomerAddress});
            this.dgvCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerData.Enabled = false;
            this.dgvCustomerData.Location = new System.Drawing.Point(2, 20);
            this.dgvCustomerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomerData.MultiSelect = false;
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.ReadOnly = true;
            this.dgvCustomerData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCustomerData.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerData.RowTemplate.Height = 24;
            this.dgvCustomerData.Size = new System.Drawing.Size(774, 231);
            this.dgvCustomerData.TabIndex = 3;
            this.dgvCustomerData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCustomerData_RowPostPaint);
            this.dgvCustomerData.SelectionChanged += new System.EventHandler(this.DgvCustomerData_SelectionChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "TÊN KHÁCH";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
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
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.tbRoomDate);
            this.panel2.Controls.Add(this.tbRoomPrice);
            this.panel2.Controls.Add(this.tbRoomType);
            this.panel2.Controls.Add(this.tbRoomID);
            this.panel2.Controls.Add(this.lbRoomType);
            this.panel2.Controls.Add(this.lbRoomDate);
            this.panel2.Controls.Add(this.lbRoomPrice);
            this.panel2.Controls.Add(this.lbRoomID);
            this.panel2.Controls.Add(this.imgEditRoom);
            this.panel2.Controls.Add(this.lbRoomDetailHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 145);
            this.panel2.TabIndex = 1;
            // 
            // tbRoomDate
            // 
            this.tbRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomDate.Location = new System.Drawing.Point(470, 103);
            this.tbRoomDate.Name = "tbRoomDate";
            this.tbRoomDate.ReadOnly = true;
            this.tbRoomDate.Size = new System.Drawing.Size(117, 20);
            this.tbRoomDate.TabIndex = 41;
            this.tbRoomDate.TabStop = false;
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomPrice.Location = new System.Drawing.Point(253, 103);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(117, 20);
            this.tbRoomPrice.TabIndex = 42;
            this.tbRoomPrice.TabStop = false;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomType.Location = new System.Drawing.Point(470, 68);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.ReadOnly = true;
            this.tbRoomType.Size = new System.Drawing.Size(117, 20);
            this.tbRoomType.TabIndex = 43;
            this.tbRoomType.TabStop = false;
            // 
            // tbRoomID
            // 
            this.tbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomID.Location = new System.Drawing.Point(253, 68);
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.ReadOnly = true;
            this.tbRoomID.Size = new System.Drawing.Size(117, 20);
            this.tbRoomID.TabIndex = 44;
            this.tbRoomID.TabStop = false;
            // 
            // lbRoomType
            // 
            this.lbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomType.Appearance.Options.UseFont = true;
            this.lbRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomType.Location = new System.Drawing.Point(390, 71);
            this.lbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(66, 13);
            this.lbRoomType.TabIndex = 37;
            this.lbRoomType.Text = "LOẠI PHÒNG:";
            // 
            // lbRoomDate
            // 
            this.lbRoomDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomDate.Appearance.Options.UseFont = true;
            this.lbRoomDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomDate.Location = new System.Drawing.Point(396, 106);
            this.lbRoomDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomDate.Name = "lbRoomDate";
            this.lbRoomDate.Size = new System.Drawing.Size(60, 13);
            this.lbRoomDate.TabIndex = 40;
            this.lbRoomDate.Text = "NGÀY THUÊ:";
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomPrice.Appearance.Options.UseFont = true;
            this.lbRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomPrice.Location = new System.Drawing.Point(191, 106);
            this.lbRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(48, 13);
            this.lbRoomPrice.TabIndex = 39;
            this.lbRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(200, 71);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbRoomID.TabIndex = 38;
            this.lbRoomID.Text = "PHÒNG:";
            // 
            // imgEditRoom
            // 
            this.imgEditRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgEditRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgEditRoom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgEditRoom.Appearance.Image")));
            this.imgEditRoom.Appearance.Options.UseFont = true;
            this.imgEditRoom.Appearance.Options.UseImage = true;
            this.imgEditRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgEditRoom.ImageOptions.Image")));
            this.imgEditRoom.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgEditRoom.Location = new System.Drawing.Point(217, 19);
            this.imgEditRoom.Margin = new System.Windows.Forms.Padding(2);
            this.imgEditRoom.Name = "imgEditRoom";
            this.imgEditRoom.Size = new System.Drawing.Size(32, 32);
            this.imgEditRoom.TabIndex = 36;
            // 
            // lbRoomDetailHeader
            // 
            this.lbRoomDetailHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomDetailHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomDetailHeader.Appearance.Options.UseFont = true;
            this.lbRoomDetailHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomDetailHeader.Location = new System.Drawing.Point(263, 20);
            this.lbRoomDetailHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomDetailHeader.Name = "lbRoomDetailHeader";
            this.lbRoomDetailHeader.Size = new System.Drawing.Size(300, 24);
            this.lbRoomDetailHeader.TabIndex = 35;
            this.lbRoomDetailHeader.Text = "CHI TIẾT PHIẾU THUÊ PHÒNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(395, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 45);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCreate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 45);
            this.panel5.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(386, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "XÁC NHẬN";
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // RoomDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RoomDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT PHIẾU THUÊ PHÒNG";
            this.Load += new System.EventHandler(this.RoomDetailForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).EndInit();
            this.gcCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl imgEditRoom;
        private DevExpress.XtraEditors.LabelControl lbRoomDetailHeader;
        private System.Windows.Forms.TextBox tbRoomDate;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomType;
        private DevExpress.XtraEditors.LabelControl lbRoomDate;
        private DevExpress.XtraEditors.LabelControl lbRoomPrice;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private DevExpress.XtraEditors.GroupControl gcCustomerList;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPassportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}