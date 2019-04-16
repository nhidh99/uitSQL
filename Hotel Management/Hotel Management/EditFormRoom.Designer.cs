namespace Hotel_Management
{
    partial class EditFormRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormRoom));
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomType = new DevExpress.XtraEditors.LabelControl();
            this.imgEditRoom = new DevExpress.XtraEditors.LabelControl();
            this.lbEditRoom = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnReverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.lbRoomStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomPrice = new DevExpress.XtraEditors.LabelControl();
            this.tbRoomStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomPrice.Location = new System.Drawing.Point(442, 120);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.Size = new System.Drawing.Size(149, 22);
            this.tbRoomPrice.TabIndex = 5;
            // 
            // tbRoomID
            // 
            this.tbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomID.Location = new System.Drawing.Point(140, 83);
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.Size = new System.Drawing.Size(451, 22);
            this.tbRoomID.TabIndex = 1;
            // 
            // cbRoomType
            // 
            this.cbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(140, 120);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(223, 24);
            this.cbRoomType.TabIndex = 3;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.Appearance.Options.UseTextOptions = true;
            this.lbRoomID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(78, 86);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(45, 16);
            this.lbRoomID.TabIndex = 37;
            this.lbRoomID.Text = "PHÒNG:";
            // 
            // lbRoomType
            // 
            this.lbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomType.Appearance.Options.UseFont = true;
            this.lbRoomType.Appearance.Options.UseTextOptions = true;
            this.lbRoomType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomType.Location = new System.Drawing.Point(40, 123);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(83, 17);
            this.lbRoomType.TabIndex = 36;
            this.lbRoomType.Text = "LOẠI PHÒNG:";
            // 
            // imgEditRoom
            // 
            this.imgEditRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgEditRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgEditRoom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgEditRoom.Appearance.Image")));
            this.imgEditRoom.Appearance.Options.UseFont = true;
            this.imgEditRoom.Appearance.Options.UseImage = true;
            this.imgEditRoom.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgEditRoom.Location = new System.Drawing.Point(90, 24);
            this.imgEditRoom.Name = "imgEditRoom";
            this.imgEditRoom.Size = new System.Drawing.Size(32, 32);
            this.imgEditRoom.TabIndex = 34;
            // 
            // lbEditRoom
            // 
            this.lbEditRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditRoom.Appearance.Options.UseFont = true;
            this.lbEditRoom.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditRoom.Location = new System.Drawing.Point(152, 26);
            this.lbEditRoom.Name = "lbEditRoom";
            this.lbEditRoom.Size = new System.Drawing.Size(375, 30);
            this.lbEditRoom.TabIndex = 33;
            this.lbEditRoom.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(451, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 50);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReverse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReverse.ImageOptions.Image")));
            this.btnReverse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReverse.Location = new System.Drawing.Point(296, 213);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(140, 50);
            this.btnReverse.TabIndex = 7;
            this.btnReverse.Text = "KHÔI PHỤC";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(140, 213);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 50);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "XÁC NHẬN";
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomStatus.Appearance.Options.UseFont = true;
            this.lbRoomStatus.Appearance.Options.UseTextOptions = true;
            this.lbRoomStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomStatus.Location = new System.Drawing.Point(40, 170);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(82, 17);
            this.lbRoomStatus.TabIndex = 28;
            this.lbRoomStatus.Text = "TÌNH TRẠNG:";
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomPrice.Appearance.Options.UseFont = true;
            this.lbRoomPrice.Appearance.Options.UseTextOptions = true;
            this.lbRoomPrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomPrice.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomPrice.Location = new System.Drawing.Point(381, 123);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(55, 16);
            this.lbRoomPrice.TabIndex = 26;
            this.lbRoomPrice.Text = "ĐƠN GIÁ:";
            // 
            // tbRoomStatus
            // 
            this.tbRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomStatus.Location = new System.Drawing.Point(140, 167);
            this.tbRoomStatus.Name = "tbRoomStatus";
            this.tbRoomStatus.Size = new System.Drawing.Size(451, 22);
            this.tbRoomStatus.TabIndex = 4;
            // 
            // EditFormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.tbRoomStatus);
            this.Controls.Add(this.tbRoomPrice);
            this.Controls.Add(this.tbRoomID);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.imgEditRoom);
            this.Controls.Add(this.lbEditRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbRoomStatus);
            this.Controls.Add(this.lbRoomPrice);
            this.Name = "EditFormRoom";
            this.Text = "THAY ĐỔI THÔNG TIN PHÒNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomID;
        private System.Windows.Forms.ComboBox cbRoomType;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomType;
        private DevExpress.XtraEditors.LabelControl imgEditRoom;
        private DevExpress.XtraEditors.LabelControl lbEditRoom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReverse;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl lbRoomStatus;
        private DevExpress.XtraEditors.LabelControl lbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomStatus;
    }
}