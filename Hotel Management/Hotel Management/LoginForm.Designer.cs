namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            this.lbBillCustomer = new DevExpress.XtraEditors.LabelControl();
            this.imgLoginHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbLoginHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Location = new System.Drawing.Point(139, 73);
            this.tbUsername.MaxLength = 30;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(221, 20);
            this.tbUsername.TabIndex = 48;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(139, 106);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(221, 20);
            this.tbPassword.TabIndex = 49;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbUsername.Appearance.Options.UseFont = true;
            this.lbUsername.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbUsername.Location = new System.Drawing.Point(48, 76);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(85, 13);
            this.lbUsername.TabIndex = 47;
            this.lbUsername.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // lbBillCustomer
            // 
            this.lbBillCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBillCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbBillCustomer.Appearance.Options.UseFont = true;
            this.lbBillCustomer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbBillCustomer.Location = new System.Drawing.Point(78, 109);
            this.lbBillCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBillCustomer.Name = "lbBillCustomer";
            this.lbBillCustomer.Size = new System.Drawing.Size(55, 13);
            this.lbBillCustomer.TabIndex = 46;
            this.lbBillCustomer.Text = "MẬT KHẨU:";
            // 
            // imgLoginHeader
            // 
            this.imgLoginHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLoginHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.imgLoginHeader.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("imgLoginHeader.Appearance.Image")));
            this.imgLoginHeader.Appearance.Options.UseFont = true;
            this.imgLoginHeader.Appearance.Options.UseImage = true;
            this.imgLoginHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgLoginHeader.ImageOptions.Image")));
            this.imgLoginHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.imgLoginHeader.Location = new System.Drawing.Point(116, 19);
            this.imgLoginHeader.Margin = new System.Windows.Forms.Padding(2);
            this.imgLoginHeader.Name = "imgLoginHeader";
            this.imgLoginHeader.Size = new System.Drawing.Size(32, 32);
            this.imgLoginHeader.TabIndex = 45;
            // 
            // lbLoginHeader
            // 
            this.lbLoginHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLoginHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbLoginHeader.Appearance.Options.UseFont = true;
            this.lbLoginHeader.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbLoginHeader.Location = new System.Drawing.Point(162, 27);
            this.lbLoginHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbLoginHeader.Name = "lbLoginHeader";
            this.lbLoginHeader.Size = new System.Drawing.Size(122, 24);
            this.lbLoginHeader.TabIndex = 44;
            this.lbLoginHeader.Text = "ĐĂNG NHẬP";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(213, 144);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 41);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "THOÁT";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirm.Location = new System.Drawing.Point(91, 144);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 41);
            this.btnConfirm.TabIndex = 50;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 206);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbBillCustomer);
            this.Controls.Add(this.imgLoginHeader);
            this.Controls.Add(this.lbLoginHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 245);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private DevExpress.XtraEditors.LabelControl lbUsername;
        private DevExpress.XtraEditors.LabelControl lbBillCustomer;
        private DevExpress.XtraEditors.LabelControl imgLoginHeader;
        private DevExpress.XtraEditors.LabelControl lbLoginHeader;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
    }
}