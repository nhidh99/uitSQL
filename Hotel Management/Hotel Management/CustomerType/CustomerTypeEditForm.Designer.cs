namespace GUI.CustomerType
{
    partial class CustomerTypeEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTypeEditForm));
            this.lbCurrencyUnit = new System.Windows.Forms.Label();
            this.imgAddRoomType = new DevExpress.XtraEditors.LabelControl();
            this.tbNewCustomerType = new System.Windows.Forms.TextBox();
            this.tbOldCustomerType = new System.Windows.Forms.TextBox();
            this.lbOldCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.lbEditCustomerTypeHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.lbNewCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbCurrencyUnit
            // 
            this.lbCurrencyUnit.AutoSize = true;
            this.lbCurrencyUnit.Location = new System.Drawing.Point(507, 228);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit.TabIndex = 70;
            this.lbCurrencyUnit.Text = "(VND)";
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
            this.imgAddRoomType.Location = new System.Drawing.Point(23, 28);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(32, 32);
            this.imgAddRoomType.TabIndex = 69;
            // 
            // tbNewCustomerType
            // 
            this.tbNewCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewCustomerType.Location = new System.Drawing.Point(201, 110);
            this.tbNewCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewCustomerType.Name = "tbNewCustomerType";
            this.tbNewCustomerType.Size = new System.Drawing.Size(134, 20);
            this.tbNewCustomerType.TabIndex = 63;
            // 
            // tbOldCustomerType
            // 
            this.tbOldCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOldCustomerType.Location = new System.Drawing.Point(201, 80);
            this.tbOldCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.tbOldCustomerType.Name = "tbOldCustomerType";
            this.tbOldCustomerType.ReadOnly = true;
            this.tbOldCustomerType.Size = new System.Drawing.Size(134, 20);
            this.tbOldCustomerType.TabIndex = 62;
            this.tbOldCustomerType.TabStop = false;
            // 
            // lbOldCustomerType
            // 
            this.lbOldCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOldCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOldCustomerType.Appearance.Options.UseFont = true;
            this.lbOldCustomerType.Appearance.Options.UseTextOptions = true;
            this.lbOldCustomerType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbOldCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbOldCustomerType.Location = new System.Drawing.Point(115, 83);
            this.lbOldCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.lbOldCustomerType.Name = "lbOldCustomerType";
            this.lbOldCustomerType.Size = new System.Drawing.Size(82, 13);
            this.lbOldCustomerType.TabIndex = 68;
            this.lbOldCustomerType.Text = "LOẠI KHÁCH CŨ:";
            // 
            // lbEditCustomerTypeHeader
            // 
            this.lbEditCustomerTypeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditCustomerTypeHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditCustomerTypeHeader.Appearance.Options.UseFont = true;
            this.lbEditCustomerTypeHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditCustomerTypeHeader.Location = new System.Drawing.Point(68, 36);
            this.lbEditCustomerTypeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbEditCustomerTypeHeader.Name = "lbEditCustomerTypeHeader";
            this.lbEditCustomerTypeHeader.Size = new System.Drawing.Size(354, 24);
            this.lbEditCustomerTypeHeader.TabIndex = 67;
            this.lbEditCustomerTypeHeader.Text = "THAY ĐỔI THÔNG TIN LOẠI KHÁCH";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(231, 152);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(109, 152);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbNewCustomerType
            // 
            this.lbNewCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNewCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbNewCustomerType.Appearance.Options.UseFont = true;
            this.lbNewCustomerType.Appearance.Options.UseTextOptions = true;
            this.lbNewCustomerType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbNewCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbNewCustomerType.Location = new System.Drawing.Point(109, 113);
            this.lbNewCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.lbNewCustomerType.Name = "lbNewCustomerType";
            this.lbNewCustomerType.Size = new System.Drawing.Size(88, 13);
            this.lbNewCustomerType.TabIndex = 66;
            this.lbNewCustomerType.Text = "LOẠI KHÁCH MỚI:";
            // 
            // CustomerTypeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.lbCurrencyUnit);
            this.Controls.Add(this.imgAddRoomType);
            this.Controls.Add(this.tbNewCustomerType);
            this.Controls.Add(this.tbOldCustomerType);
            this.Controls.Add(this.lbOldCustomerType);
            this.Controls.Add(this.lbEditCustomerTypeHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbNewCustomerType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 260);
            this.MinimumSize = new System.Drawing.Size(460, 260);
            this.Name = "CustomerTypeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THAY ĐỔI THÔNG TIN LOẠI KHÁCH";
            this.Load += new System.EventHandler(this.CustomerTypeEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrencyUnit;
        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private System.Windows.Forms.TextBox tbNewCustomerType;
        private System.Windows.Forms.TextBox tbOldCustomerType;
        private DevExpress.XtraEditors.LabelControl lbOldCustomerType;
        private DevExpress.XtraEditors.LabelControl lbEditCustomerTypeHeader;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl lbNewCustomerType;
    }
}