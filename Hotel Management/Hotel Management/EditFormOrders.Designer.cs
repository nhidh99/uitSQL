namespace Hotel_Management
{
    partial class EditFormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormOrders));
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new DevExpress.XtraEditors.LabelControl();
            this.cbRoomName = new System.Windows.Forms.ComboBox();
            this.lbRoomName = new DevExpress.XtraEditors.LabelControl();
            this.cbRoomID = new System.Windows.Forms.ComboBox();
            this.lbRoomID = new DevExpress.XtraEditors.LabelControl();
            this.deRentDate = new DevExpress.XtraEditors.DateEdit();
            this.lbRentDate = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.tbCustomerPassport = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.rtbCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.lbCustomerPassport = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.lbCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lbCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.imgEditRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.lbEditRoomNote = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnReverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deRentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRentDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerID.Location = new System.Drawing.Point(178, 85);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(451, 22);
            this.tbCustomerID.TabIndex = 1;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerID.Appearance.Options.UseFont = true;
            this.lbCustomerID.Appearance.Options.UseTextOptions = true;
            this.lbCustomerID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerID.Location = new System.Drawing.Point(96, 88);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(66, 16);
            this.lbCustomerID.TabIndex = 59;
            this.lbCustomerID.Text = "MÃ KHÁCH:";
            // 
            // cbRoomName
            // 
            this.cbRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoomName.FormattingEnabled = true;
            this.cbRoomName.Location = new System.Drawing.Point(179, 207);
            this.cbRoomName.Name = "cbRoomName";
            this.cbRoomName.Size = new System.Drawing.Size(218, 24);
            this.cbRoomName.TabIndex = 8;
            // 
            // lbRoomName
            // 
            this.lbRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomName.Appearance.Options.UseFont = true;
            this.lbRoomName.Appearance.Options.UseTextOptions = true;
            this.lbRoomName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRoomName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomName.Location = new System.Drawing.Point(117, 210);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(45, 16);
            this.lbRoomName.TabIndex = 56;
            this.lbRoomName.Text = "PHÒNG:";
            // 
            // cbRoomID
            // 
            this.cbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoomID.FormattingEnabled = true;
            this.cbRoomID.Location = new System.Drawing.Point(520, 207);
            this.cbRoomID.Name = "cbRoomID";
            this.cbRoomID.Size = new System.Drawing.Size(109, 24);
            this.cbRoomID.TabIndex = 9;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRoomID.Appearance.Options.UseFont = true;
            this.lbRoomID.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomID.Location = new System.Drawing.Point(431, 210);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(72, 17);
            this.lbRoomID.TabIndex = 54;
            this.lbRoomID.Text = "SỐ PHÒNG:";
            // 
            // deRentDate
            // 
            this.deRentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deRentDate.EditValue = null;
            this.deRentDate.Location = new System.Drawing.Point(520, 164);
            this.deRentDate.Name = "deRentDate";
            this.deRentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRentDate.Size = new System.Drawing.Size(109, 22);
            this.deRentDate.TabIndex = 7;
            // 
            // lbRentDate
            // 
            this.lbRentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRentDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbRentDate.Appearance.Options.UseFont = true;
            this.lbRentDate.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRentDate.Location = new System.Drawing.Point(431, 167);
            this.lbRentDate.Name = "lbRentDate";
            this.lbRentDate.Size = new System.Drawing.Size(71, 16);
            this.lbRentDate.TabIndex = 52;
            this.lbRentDate.Text = "NGÀY THUÊ:";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerAddress.Appearance.Options.UseFont = true;
            this.lbCustomerAddress.Appearance.Options.UseTextOptions = true;
            this.lbCustomerAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerAddress.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerAddress.Location = new System.Drawing.Point(109, 248);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(53, 17);
            this.lbCustomerAddress.TabIndex = 51;
            this.lbCustomerAddress.Text = "ĐỊA CHỈ:";
            // 
            // tbCustomerPassport
            // 
            this.tbCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerPassport.Location = new System.Drawing.Point(179, 164);
            this.tbCustomerPassport.Name = "tbCustomerPassport";
            this.tbCustomerPassport.Size = new System.Drawing.Size(218, 22);
            this.tbCustomerPassport.TabIndex = 6;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerName.Location = new System.Drawing.Point(179, 124);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(218, 22);
            this.tbCustomerName.TabIndex = 4;
            // 
            // rtbCustomerAddress
            // 
            this.rtbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbCustomerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCustomerAddress.Location = new System.Drawing.Point(179, 246);
            this.rtbCustomerAddress.Name = "rtbCustomerAddress";
            this.rtbCustomerAddress.Size = new System.Drawing.Size(450, 61);
            this.rtbCustomerAddress.TabIndex = 10;
            this.rtbCustomerAddress.Text = "";
            // 
            // lbCustomerPassport
            // 
            this.lbCustomerPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerPassport.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerPassport.Appearance.Options.UseFont = true;
            this.lbCustomerPassport.Appearance.Options.UseTextOptions = true;
            this.lbCustomerPassport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerPassport.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerPassport.Location = new System.Drawing.Point(97, 167);
            this.lbCustomerPassport.Name = "lbCustomerPassport";
            this.lbCustomerPassport.Size = new System.Drawing.Size(65, 17);
            this.lbCustomerPassport.TabIndex = 48;
            this.lbCustomerPassport.Text = "SỐ CMND:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(520, 124);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(109, 24);
            this.cbCustomerType.TabIndex = 5;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerName.Appearance.Options.UseFont = true;
            this.lbCustomerName.Appearance.Options.UseTextOptions = true;
            this.lbCustomerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbCustomerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerName.Location = new System.Drawing.Point(55, 127);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(107, 16);
            this.lbCustomerName.TabIndex = 46;
            this.lbCustomerName.Text = "TÊN KHÁCH HÀNG:";
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCustomerType.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCustomerType.Appearance.Options.UseFont = true;
            this.lbCustomerType.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbCustomerType.Location = new System.Drawing.Point(421, 127);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(81, 17);
            this.lbCustomerType.TabIndex = 45;
            this.lbCustomerType.Text = "LOẠI KHÁCH:";
            // 
            // imgEditRoomNote
            // 
            this.imgEditRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgEditRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgEditRoomNote.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.imgEditRoomNote.Appearance.Options.UseFont = true;
            this.imgEditRoomNote.Appearance.Options.UseImage = true;
            this.imgEditRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgEditRoomNote.Location = new System.Drawing.Point(70, 24);
            this.imgEditRoomNote.Name = "imgEditRoomNote";
            this.imgEditRoomNote.Size = new System.Drawing.Size(32, 32);
            this.imgEditRoomNote.TabIndex = 43;
            // 
            // lbEditRoomNote
            // 
            this.lbEditRoomNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditRoomNote.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbEditRoomNote.Appearance.Options.UseFont = true;
            this.lbEditRoomNote.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbEditRoomNote.Location = new System.Drawing.Point(116, 24);
            this.lbEditRoomNote.Name = "lbEditRoomNote";
            this.lbEditRoomNote.Size = new System.Drawing.Size(536, 30);
            this.lbEditRoomNote.TabIndex = 42;
            this.lbEditRoomNote.Text = "THAY ĐỔI THÔNG TIN PHIẾU THUÊ PHÒNG";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(489, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 50);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReverse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnReverse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReverse.Location = new System.Drawing.Point(334, 329);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(140, 50);
            this.btnReverse.TabIndex = 12;
            this.btnReverse.Text = "KHÔI PHỤC";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(178, 329);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 50);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "XÁC NHẬN";
            // 
            // EditFormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 401);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.cbRoomName);
            this.Controls.Add(this.lbRoomName);
            this.Controls.Add(this.cbRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.deRentDate);
            this.Controls.Add(this.lbRentDate);
            this.Controls.Add(this.lbCustomerAddress);
            this.Controls.Add(this.tbCustomerPassport);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.rtbCustomerAddress);
            this.Controls.Add(this.lbCustomerPassport);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.imgEditRoomNote);
            this.Controls.Add(this.lbEditRoomNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditFormOrders";
            this.Text = "THAY ĐỔI THÔNG TIN PHIẾU THUÊ PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.deRentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRentDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomerID;
        private DevExpress.XtraEditors.LabelControl lbCustomerID;
        private System.Windows.Forms.ComboBox cbRoomName;
        private DevExpress.XtraEditors.LabelControl lbRoomName;
        private System.Windows.Forms.ComboBox cbRoomID;
        private DevExpress.XtraEditors.LabelControl lbRoomID;
        private DevExpress.XtraEditors.DateEdit deRentDate;
        private DevExpress.XtraEditors.LabelControl lbRentDate;
        private DevExpress.XtraEditors.LabelControl lbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerPassport;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.RichTextBox rtbCustomerAddress;
        private DevExpress.XtraEditors.LabelControl lbCustomerPassport;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private DevExpress.XtraEditors.LabelControl lbCustomerName;
        private DevExpress.XtraEditors.LabelControl lbCustomerType;
        private DevExpress.XtraEditors.LabelControl imgEditRoomNote;
        private DevExpress.XtraEditors.LabelControl lbEditRoomNote;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReverse;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
    }
}