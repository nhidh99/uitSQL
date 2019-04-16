namespace Hotel_Management
{
    partial class EditFormRoomTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormRoomTypes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRoomTypeEdit = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnReverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.imgRoomTypeEdit = new DevExpress.XtraEditors.LabelControl();
            this.lbRoomTypeEdit = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypeEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRoomTypeEdit);
            this.panel1.Location = new System.Drawing.Point(2, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 276);
            this.panel1.TabIndex = 0;
            // 
            // dgvRoomTypeEdit
            // 
            this.dgvRoomTypeEdit.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomTypeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomTypeEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dgvRoomTypeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomTypeEdit.Location = new System.Drawing.Point(0, 0);
            this.dgvRoomTypeEdit.Name = "dgvRoomTypeEdit";
            this.dgvRoomTypeEdit.RowTemplate.Height = 24;
            this.dgvRoomTypeEdit.Size = new System.Drawing.Size(575, 276);
            this.dgvRoomTypeEdit.TabIndex = 3;
            this.dgvRoomTypeEdit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtg_RowPostPaint);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "LOẠI PHÒNG";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "ĐƠN GIÁ";
            this.Column7.Name = "Column7";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(375, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "HỦY BỎ";
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReverse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnReverse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReverse.Location = new System.Drawing.Point(220, 386);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(140, 50);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "KHÔI PHỤC";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(64, 386);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 50);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "XÁC NHẬN";
            // 
            // imgRoomTypeEdit
            // 
            this.imgRoomTypeEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgRoomTypeEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgRoomTypeEdit.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.imgRoomTypeEdit.Appearance.Options.UseFont = true;
            this.imgRoomTypeEdit.Appearance.Options.UseImage = true;
            this.imgRoomTypeEdit.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgRoomTypeEdit.Location = new System.Drawing.Point(25, 26);
            this.imgRoomTypeEdit.Name = "imgRoomTypeEdit";
            this.imgRoomTypeEdit.Size = new System.Drawing.Size(32, 32);
            this.imgRoomTypeEdit.TabIndex = 46;
            // 
            // lbRoomTypeEdit
            // 
            this.lbRoomTypeEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRoomTypeEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbRoomTypeEdit.Appearance.Options.UseFont = true;
            this.lbRoomTypeEdit.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomTypeEdit.Location = new System.Drawing.Point(71, 26);
            this.lbRoomTypeEdit.Name = "lbRoomTypeEdit";
            this.lbRoomTypeEdit.Size = new System.Drawing.Size(444, 30);
            this.lbRoomTypeEdit.TabIndex = 45;
            this.lbRoomTypeEdit.Text = "THAY ĐỔI THÔNG TIN LOẠI PHÒNG";
            // 
            // EditFormRoomTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 459);
            this.Controls.Add(this.imgRoomTypeEdit);
            this.Controls.Add(this.lbRoomTypeEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "EditFormRoomTypes";
            this.Text = "THAY ĐỔI THÔNG TIN LOẠI PHÒNG";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypeEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRoomTypeEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReverse;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl imgRoomTypeEdit;
        private DevExpress.XtraEditors.LabelControl lbRoomTypeEdit;
    }
}