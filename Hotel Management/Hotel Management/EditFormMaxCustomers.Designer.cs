namespace Hotel_Management
{
    partial class EditFormMaxCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormMaxCustomers));
            this.lbMaxCustomers = new DevExpress.XtraEditors.LabelControl();
            this.nudMaxCustomers = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaxCustomers
            // 
            this.lbMaxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaxCustomers.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbMaxCustomers.Appearance.Options.UseFont = true;
            this.lbMaxCustomers.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbMaxCustomers.Location = new System.Drawing.Point(54, 24);
            this.lbMaxCustomers.Name = "lbMaxCustomers";
            this.lbMaxCustomers.Size = new System.Drawing.Size(195, 17);
            this.lbMaxCustomers.TabIndex = 30;
            this.lbMaxCustomers.Text = "SỐ KHÁCH TỐI ĐA MỖI PHÒNG:";
            // 
            // nudMaxCustomers
            // 
            this.nudMaxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMaxCustomers.Location = new System.Drawing.Point(271, 22);
            this.nudMaxCustomers.Name = "nudMaxCustomers";
            this.nudMaxCustomers.Size = new System.Drawing.Size(120, 22);
            this.nudMaxCustomers.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Appearance.Image")));
            this.btnConfirm.Appearance.Options.UseImage = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(91, 66);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 31);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "XÁC NHẬN";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Appearance.Image")));
            this.btnCancel.Appearance.Options.UseImage = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(223, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // EditFormMaxCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 118);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudMaxCustomers);
            this.Controls.Add(this.lbMaxCustomers);
            this.Name = "EditFormMaxCustomers";
            this.Text = "THAY ĐỔI SỐ KHÁCH TỐI ĐA";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMaxCustomers;
        private System.Windows.Forms.NumericUpDown nudMaxCustomers;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}