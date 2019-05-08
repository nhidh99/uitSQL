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
            this.lbCurrencyUnit1 = new System.Windows.Forms.Label();
            this.imgAddRoomType = new DevExpress.XtraEditors.LabelControl();
            this.tbThirdCustomerTax = new System.Windows.Forms.TextBox();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbEditRoomType = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lbThirdCustomerTax = new DevExpress.XtraEditors.LabelControl();
            this.lbForeignCustomerTax = new DevExpress.XtraEditors.LabelControl();
            this.tbForeignCustomerTax = new System.Windows.Forms.TextBox();
            this.lbCurrencyUnit = new System.Windows.Forms.Label();
            this.lbTotalTax = new DevExpress.XtraEditors.LabelControl();
            this.tbTotalTax = new System.Windows.Forms.TextBox();
            this.lbCurrencyUnit2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCurrencyUnit1
            // 
            this.lbCurrencyUnit1.AutoSize = true;
            this.lbCurrencyUnit1.Location = new System.Drawing.Point(381, 148);
            this.lbCurrencyUnit1.Name = "lbCurrencyUnit1";
            this.lbCurrencyUnit1.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit1.TabIndex = 70;
            this.lbCurrencyUnit1.Text = "(VND)";
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
            this.imgAddRoomType.Location = new System.Drawing.Point(123, 23);
            this.imgAddRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.imgAddRoomType.Name = "imgAddRoomType";
            this.imgAddRoomType.Size = new System.Drawing.Size(32, 32);
            this.imgAddRoomType.TabIndex = 69;
            // 
            // tbThirdCustomerTax
            // 
            this.tbThirdCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbThirdCustomerTax.Location = new System.Drawing.Point(231, 108);
            this.tbThirdCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.tbThirdCustomerTax.Name = "tbThirdCustomerTax";
            this.tbThirdCustomerTax.ReadOnly = true;
            this.tbThirdCustomerTax.Size = new System.Drawing.Size(134, 20);
            this.tbThirdCustomerTax.TabIndex = 63;
            // 
            // tbRoomID
            // 
            this.tbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomID.Location = new System.Drawing.Point(231, 74);
            this.tbRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.ReadOnly = true;
            this.tbRoomID.Size = new System.Drawing.Size(134, 20);
            this.tbRoomID.TabIndex = 62;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.Appearance.Options.UseTextOptions = true;
            this.lbRoomID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(179, 77);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(39, 13);
            this.lbRoomID.TabIndex = 68;
            this.lbRoomID.Text = "PHÒNG:";
            // 
            // lbEditRoomType
            // 
            this.lbEditRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditRoomType.Appearance.Options.UseFont = true;
            this.lbEditRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditRoomType.Location = new System.Drawing.Point(169, 31);
            this.lbEditRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.lbEditRoomType.Name = "lbEditRoomType";
            this.lbEditRoomType.Size = new System.Drawing.Size(187, 24);
            this.lbEditRoomType.TabIndex = 67;
            this.lbEditRoomType.Text = "CHI TIẾT PHỤ THU";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnClose.Location = new System.Drawing.Point(149, 219);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 41);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbThirdCustomerTax
            // 
            this.lbThirdCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbThirdCustomerTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbThirdCustomerTax.Appearance.Options.UseFont = true;
            this.lbThirdCustomerTax.Appearance.Options.UseTextOptions = true;
            this.lbThirdCustomerTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbThirdCustomerTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbThirdCustomerTax.Location = new System.Drawing.Point(101, 111);
            this.lbThirdCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.lbThirdCustomerTax.Name = "lbThirdCustomerTax";
            this.lbThirdCustomerTax.Size = new System.Drawing.Size(117, 13);
            this.lbThirdCustomerTax.TabIndex = 66;
            this.lbThirdCustomerTax.Text = "PHỤ THU KHÁCH THỨ 3:";
            // 
            // lbForeignCustomerTax
            // 
            this.lbForeignCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbForeignCustomerTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbForeignCustomerTax.Appearance.Options.UseFont = true;
            this.lbForeignCustomerTax.Appearance.Options.UseTextOptions = true;
            this.lbForeignCustomerTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbForeignCustomerTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbForeignCustomerTax.Location = new System.Drawing.Point(65, 146);
            this.lbForeignCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.lbForeignCustomerTax.Name = "lbForeignCustomerTax";
            this.lbForeignCustomerTax.Size = new System.Drawing.Size(153, 13);
            this.lbForeignCustomerTax.TabIndex = 71;
            this.lbForeignCustomerTax.Text = "PHỤ THU KHÁCH NƯỚC NGOÀI:";
            // 
            // tbForeignCustomerTax
            // 
            this.tbForeignCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbForeignCustomerTax.Location = new System.Drawing.Point(231, 143);
            this.tbForeignCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.tbForeignCustomerTax.Name = "tbForeignCustomerTax";
            this.tbForeignCustomerTax.ReadOnly = true;
            this.tbForeignCustomerTax.Size = new System.Drawing.Size(134, 20);
            this.tbForeignCustomerTax.TabIndex = 63;
            // 
            // lbCurrencyUnit
            // 
            this.lbCurrencyUnit.AutoSize = true;
            this.lbCurrencyUnit.Location = new System.Drawing.Point(381, 113);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit.TabIndex = 70;
            this.lbCurrencyUnit.Text = "(VND)";
            // 
            // lbTotalTax
            // 
            this.lbTotalTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotalTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbTotalTax.Appearance.Options.UseFont = true;
            this.lbTotalTax.Appearance.Options.UseTextOptions = true;
            this.lbTotalTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbTotalTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbTotalTax.Location = new System.Drawing.Point(140, 179);
            this.lbTotalTax.Margin = new System.Windows.Forms.Padding(2);
            this.lbTotalTax.Name = "lbTotalTax";
            this.lbTotalTax.Size = new System.Drawing.Size(78, 13);
            this.lbTotalTax.TabIndex = 71;
            this.lbTotalTax.Text = "TỔNG PHỤ THU:";
            // 
            // tbTotalTax
            // 
            this.tbTotalTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalTax.Location = new System.Drawing.Point(231, 176);
            this.tbTotalTax.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalTax.Name = "tbTotalTax";
            this.tbTotalTax.ReadOnly = true;
            this.tbTotalTax.Size = new System.Drawing.Size(134, 20);
            this.tbTotalTax.TabIndex = 63;
            // 
            // lbCurrencyUnit2
            // 
            this.lbCurrencyUnit2.AutoSize = true;
            this.lbCurrencyUnit2.Location = new System.Drawing.Point(381, 181);
            this.lbCurrencyUnit2.Name = "lbCurrencyUnit2";
            this.lbCurrencyUnit2.Size = new System.Drawing.Size(36, 13);
            this.lbCurrencyUnit2.TabIndex = 70;
            this.lbCurrencyUnit2.Text = "(VND)";
            // 
            // BillTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.lbTotalTax);
            this.Controls.Add(this.lbForeignCustomerTax);
            this.Controls.Add(this.lbCurrencyUnit);
            this.Controls.Add(this.lbCurrencyUnit2);
            this.Controls.Add(this.lbCurrencyUnit1);
            this.Controls.Add(this.imgAddRoomType);
            this.Controls.Add(this.tbTotalTax);
            this.Controls.Add(this.tbForeignCustomerTax);
            this.Controls.Add(this.tbThirdCustomerTax);
            this.Controls.Add(this.tbRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbEditRoomType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbThirdCustomerTax);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 320);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "BillTaxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT PHỤ THU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrencyUnit1;
        private DevExpress.XtraEditors.LabelControl imgAddRoomType;
        private System.Windows.Forms.TextBox tbThirdCustomerTax;
        private System.Windows.Forms.TextBox tbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private DevExpress.XtraEditors.LabelControl lbEditRoomType;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl lbThirdCustomerTax;
        private DevExpress.XtraEditors.LabelControl lbForeignCustomerTax;
        private System.Windows.Forms.TextBox tbForeignCustomerTax;
        private System.Windows.Forms.Label lbCurrencyUnit;
        private DevExpress.XtraEditors.LabelControl lbTotalTax;
        private System.Windows.Forms.TextBox tbTotalTax;
        private System.Windows.Forms.Label lbCurrencyUnit2;
    }
}