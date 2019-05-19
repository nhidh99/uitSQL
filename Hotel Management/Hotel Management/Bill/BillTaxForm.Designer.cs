namespace Hotel_Management.Bill
{
    partial class BillTaxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillTaxForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgAddRoomType = new DevExpress.XtraEditors.LabelControl();
            this.lbEditRoomType = new DevExpress.XtraEditors.LabelControl();
            this.dgvTaxDetail = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignCustomerTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTaxDetail, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.30612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.69388F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnClose.Location = new System.Drawing.Point(2, 262);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(680, 47);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgAddRoomType);
            this.panel1.Controls.Add(this.lbEditRoomType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 60);
            this.panel1.TabIndex = 0;
            // 
            // imgAddRoomType
            // 
            this.imgAddRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgAddRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgAddRoomType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgAddRoomType.Appearance.Image")));
            this.imgAddRoomType.Appearance.Options.UseFont = true;
            this.imgAddRoomType.Appearance.Options.UseImage = true;
            this.imgAddRoomType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgAddRoomType.ImageOptions.Image")));
            this.imgAddRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgAddRoomType.Location = new System.Drawing.Point(223, 14);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(32, 32);
            this.imgAddRoomType.TabIndex = 71;
            // 
            // lbEditRoomType
            // 
            this.lbEditRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditRoomType.Appearance.Options.UseFont = true;
            this.lbEditRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditRoomType.Location = new System.Drawing.Point(269, 22);
            this.lbEditRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.lbEditRoomType.Name = "lbEditRoomType";
            this.lbEditRoomType.Size = new System.Drawing.Size(187, 24);
            this.lbEditRoomType.TabIndex = 70;
            this.lbEditRoomType.Text = "CHI TIẾT PHỤ THU";
            // 
            // dgvTaxDetail
            // 
            this.dgvTaxDetail.AllowUserToAddRows = false;
            this.dgvTaxDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaxDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.OverCustomerTax,
            this.ForeignCustomerTax,
            this.TotalTax});
            this.dgvTaxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaxDetail.Location = new System.Drawing.Point(3, 69);
            this.dgvTaxDetail.Name = "dgvTaxDetail";
            this.dgvTaxDetail.Size = new System.Drawing.Size(678, 188);
            this.dgvTaxDetail.TabIndex = 1;
            this.dgvTaxDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvTaxDetail_RowPostPaint);
            this.dgvTaxDetail.SelectionChanged += new System.EventHandler(this.DgvTaxDetail_SelectionChanged);
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "PHÒNG";
            this.RoomID.Name = "RoomID";
            this.RoomID.Width = 71;
            // 
            // OverCustomerTax
            // 
            this.OverCustomerTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OverCustomerTax.DataPropertyName = "PhuThuKhachThem";
            this.OverCustomerTax.HeaderText = "PHỤ THU KHÁCH THÊM (VND)";
            this.OverCustomerTax.Name = "OverCustomerTax";
            // 
            // ForeignCustomerTax
            // 
            this.ForeignCustomerTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ForeignCustomerTax.DataPropertyName = "PhuThuKhachNuocNgoai";
            this.ForeignCustomerTax.HeaderText = "KHÁCH NƯỚC NGOÀI (VND)";
            this.ForeignCustomerTax.Name = "ForeignCustomerTax";
            // 
            // TotalTax
            // 
            this.TotalTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalTax.DataPropertyName = "TongPhuThu";
            this.TotalTax.HeaderText = "TỔNG PHỤ THU (VND)";
            this.TotalTax.Name = "TotalTax";
            // 
            // BillTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 350);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "BillTaxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT PHỤ THU";
            this.Load += new System.EventHandler(this.BillTaxForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private DevExpress.XtraEditors.LabelControl lbEditRoomType;
        private System.Windows.Forms.DataGridView dgvTaxDetail;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignCustomerTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
    }
}