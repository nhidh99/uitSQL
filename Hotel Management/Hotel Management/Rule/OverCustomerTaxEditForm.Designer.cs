namespace GUI
{
    partial class OverCustomerTaxEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverCustomerTaxEditForm));
            this.lbThirdCustomerTax = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.nudTaxPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThirdCustomerTax
            // 
            this.lbThirdCustomerTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbThirdCustomerTax.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbThirdCustomerTax.Appearance.Options.UseFont = true;
            this.lbThirdCustomerTax.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbThirdCustomerTax.Location = new System.Drawing.Point(52, 21);
            this.lbThirdCustomerTax.Margin = new System.Windows.Forms.Padding(2);
            this.lbThirdCustomerTax.Name = "lbThirdCustomerTax";
            this.lbThirdCustomerTax.Size = new System.Drawing.Size(144, 13);
            this.lbThirdCustomerTax.TabIndex = 35;
            this.lbThirdCustomerTax.Text = "TỈ LỆ PHỤ THU KHÁCH THỨ 3:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Appearance.Image")));
            this.btnCancel.Appearance.Options.UseImage = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(187, 52);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Appearance.Image")));
            this.btnConfirm.Appearance.Options.UseImage = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(88, 52);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 40);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(281, 21);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(21, 13);
            this.lbPercentage.TabIndex = 37;
            this.lbPercentage.Text = "(%)";
            // 
            // nudTaxPercent
            // 
            this.nudTaxPercent.Location = new System.Drawing.Point(201, 19);
            this.nudTaxPercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTaxPercent.Name = "nudTaxPercent";
            this.nudTaxPercent.Size = new System.Drawing.Size(74, 20);
            this.nudTaxPercent.TabIndex = 37;
            this.nudTaxPercent.Enter += new System.EventHandler(this.NudTaxPercent_Enter);
            this.nudTaxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudTaxPercent_KeyPress);
            // 
            // OverCustomerTaxEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.nudTaxPercent);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbThirdCustomerTax);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 150);
            this.MinimumSize = new System.Drawing.Size(370, 150);
            this.Name = "OverCustomerTaxEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHỤ THU KHÁCH THỨ 3";
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbThirdCustomerTax;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.NumericUpDown nudTaxPercent;
    }
}