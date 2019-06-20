namespace GUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.lbCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.tbCustomerPassport = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.rtbCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.lbCustomerPassport = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.lbCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.imgCustomer = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerAddress.Appearance.Options.UseFont = true;
            this.lbCustomerAddress.Appearance.Options.UseTextOptions = true;
            this.lbCustomerAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerAddress.Location = new System.Drawing.Point(57, 136);
            this.lbCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(44, 13);
            this.lbCustomerAddress.TabIndex = 51;
            this.lbCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // tbCustomerPassport
            // 
            this.tbCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerPassport.Location = new System.Drawing.Point(280, 101);
            this.tbCustomerPassport.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerPassport.MaxLength = 20;
            this.tbCustomerPassport.Name = "tbCustomerPassport";
            this.tbCustomerPassport.Size = new System.Drawing.Size(168, 20);
            this.tbCustomerPassport.TabIndex = 6;
            this.tbCustomerPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCustomerPassport_KeyPress);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerName.Location = new System.Drawing.Point(109, 69);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerName.MaxLength = 30;
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(339, 20);
            this.tbCustomerName.TabIndex = 4;
            this.tbCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCustomerName_KeyPress);
            // 
            // rtbCustomerAddress
            // 
            this.rtbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbCustomerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCustomerAddress.Location = new System.Drawing.Point(109, 135);
            this.rtbCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCustomerAddress.MaxLength = 50;
            this.rtbCustomerAddress.Name = "rtbCustomerAddress";
            this.rtbCustomerAddress.Size = new System.Drawing.Size(338, 114);
            this.rtbCustomerAddress.TabIndex = 10;
            this.rtbCustomerAddress.Text = "";
            this.rtbCustomerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rtb_KeyDown);
            // 
            // lbCustomerPassport
            // 
            this.lbCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerPassport.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerPassport.Appearance.Options.UseFont = true;
            this.lbCustomerPassport.Appearance.Options.UseTextOptions = true;
            this.lbCustomerPassport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerPassport.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerPassport.Location = new System.Drawing.Point(226, 104);
            this.lbCustomerPassport.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerPassport.Name = "lbCustomerPassport";
            this.lbCustomerPassport.Size = new System.Drawing.Size(50, 13);
            this.lbCustomerPassport.TabIndex = 48;
            this.lbCustomerPassport.Text = "SỐ CMND:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(109, 100);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(104, 21);
            this.cbCustomerType.TabIndex = 5;
            this.cbCustomerType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbCustomerType_KeyPress);
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerName.Appearance.Options.UseFont = true;
            this.lbCustomerName.Appearance.Options.UseTextOptions = true;
            this.lbCustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerName.Location = new System.Drawing.Point(43, 71);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(60, 13);
            this.lbCustomerName.TabIndex = 46;
            this.lbCustomerName.Text = "TÊN KHÁCH:";
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerType.Appearance.Options.UseFont = true;
            this.lbCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerType.Location = new System.Drawing.Point(36, 103);
            this.lbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(65, 13);
            this.lbCustomerType.TabIndex = 45;
            this.lbCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // lbCustomerHeader
            // 
            this.lbCustomerHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbCustomerHeader.Appearance.Options.UseFont = true;
            this.lbCustomerHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCustomerHeader.LineColor = System.Drawing.Color.Transparent;
            this.lbCustomerHeader.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbCustomerHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerHeader.Location = new System.Drawing.Point(118, 30);
            this.lbCustomerHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbCustomerHeader.Name = "lbCustomerHeader";
            this.lbCustomerHeader.Size = new System.Drawing.Size(298, 24);
            this.lbCustomerHeader.TabIndex = 42;
            this.lbCustomerHeader.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(258, 266);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(130, 266);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // imgCustomer
            // 
            this.imgCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgCustomer.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgCustomer.Appearance.Image")));
            this.imgCustomer.Appearance.Options.UseFont = true;
            this.imgCustomer.Appearance.Options.UseImage = true;
            this.imgCustomer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.imgCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgCustomer.ImageOptions.Image")));
            this.imgCustomer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgCustomer.Location = new System.Drawing.Point(68, 22);
            this.imgCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.imgCustomer.Name = "imgCustomer";
            this.imgCustomer.Size = new System.Drawing.Size(32, 32);
            this.imgCustomer.TabIndex = 70;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.imgCustomer);
            this.Controls.Add(this.lbCustomerAddress);
            this.Controls.Add(this.tbCustomerPassport);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.rtbCustomerAddress);
            this.Controls.Add(this.lbCustomerPassport);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.lbCustomerHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 360);
            this.MinimumSize = new System.Drawing.Size(500, 360);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerPassport;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.RichTextBox rtbCustomerAddress;
        private DevExpress.XtraEditors.LabelControl lbCustomerPassport;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private DevExpress.XtraEditors.LabelControl lbCustomerName;
        private DevExpress.XtraEditors.LabelControl lbCustomerType;
        private DevExpress.XtraEditors.LabelControl lbCustomerHeader;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl imgCustomer;
    }
}