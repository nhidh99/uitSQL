namespace Hotel_Management
{
    partial class EditFormAdditionPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormAdditionPrice));
            this.nudAdditionPrice = new System.Windows.Forms.NumericUpDown();
            this.lbAddtionPrice = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAdditionPrice
            // 
            this.nudAdditionPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudAdditionPrice.Location = new System.Drawing.Point(207, 18);
            this.nudAdditionPrice.Name = "nudAdditionPrice";
            this.nudAdditionPrice.Size = new System.Drawing.Size(120, 22);
            this.nudAdditionPrice.TabIndex = 36;
            // 
            // lbAddtionPrice
            // 
            this.lbAddtionPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAddtionPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbAddtionPrice.Appearance.Options.UseFont = true;
            this.lbAddtionPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbAddtionPrice.Location = new System.Drawing.Point(105, 20);
            this.lbAddtionPrice.Name = "lbAddtionPrice";
            this.lbAddtionPrice.Size = new System.Drawing.Size(96, 17);
            this.lbAddtionPrice.TabIndex = 35;
            this.lbAddtionPrice.Text = "TỈ LỆ PHỤ THU:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Appearance.Image")));
            this.btnCancel.Appearance.Options.UseImage = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(228, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Appearance.Image")));
            this.btnConfirm.Appearance.Options.UseImage = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(96, 59);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 31);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "XÁC NHẬN";
            // 
            // EditFormAdditionPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 106);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudAdditionPrice);
            this.Controls.Add(this.lbAddtionPrice);
            this.Name = "EditFormAdditionPrice";
            this.Text = "THAY ĐỔI TỈ LỆ PHỤ THU";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAdditionPrice;
        private DevExpress.XtraEditors.LabelControl lbAddtionPrice;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
    }
}