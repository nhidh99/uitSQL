namespace GUI.Rule
{
    partial class ForeignCustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForeignCustomerEditForm));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.lbAddtionPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.nudTaxPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Appearance.Image")));
            this.btnCancel.Appearance.Options.UseImage = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(184, 52);
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
            this.btnConfirm.Location = new System.Drawing.Point(85, 52);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 40);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbAddtionPrice
            // 
            this.lbAddtionPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAddtionPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAddtionPrice.Appearance.Options.UseFont = true;
            this.lbAddtionPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAddtionPrice.Location = new System.Drawing.Point(47, 21);
            this.lbAddtionPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbAddtionPrice.Name = "lbAddtionPrice";
            this.lbAddtionPrice.Size = new System.Drawing.Size(153, 13);
            this.lbAddtionPrice.TabIndex = 39;
            this.lbAddtionPrice.Text = "PHỤ THU KHÁCH NƯỚC NGOÀI:";
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(285, 21);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(21, 13);
            this.lbPercentage.TabIndex = 40;
            this.lbPercentage.Text = "(%)";
            // 
            // nudTaxPercent
            // 
            this.nudTaxPercent.Location = new System.Drawing.Point(205, 19);
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
            // ForeignCustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.nudTaxPercent);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbAddtionPrice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 150);
            this.MinimumSize = new System.Drawing.Size(370, 150);
            this.Name = "ForeignCustomerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHỤ THU KHÁCH NƯỚC NGOÀI";
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl lbAddtionPrice;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.NumericUpDown nudTaxPercent;
    }
}