namespace GUI
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pic_thoat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.panelTenDangNhap = new System.Windows.Forms.Panel();
            this.picLogoPass = new System.Windows.Forms.PictureBox();
            this.picLogoName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thoat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_thoat
            // 
            this.pic_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_thoat.Image = global::GUI.Properties.Resources.multiply_26px;
            this.pic_thoat.Location = new System.Drawing.Point(1340, 0);
            this.pic_thoat.Name = "pic_thoat";
            this.pic_thoat.Size = new System.Drawing.Size(26, 26);
            this.pic_thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_thoat.TabIndex = 0;
            this.pic_thoat.TabStop = false;
            this.pic_thoat.Click += new System.EventHandler(this.Pic_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblThongBao);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.panelMatKhau);
            this.panel1.Controls.Add(this.panelTenDangNhap);
            this.panel1.Controls.Add(this.picLogoPass);
            this.panel1.Controls.Add(this.picLogoName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(559, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 470);
            this.panel1.TabIndex = 1;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(17, 366);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 16);
            this.lblThongBao.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(65, 313);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(220, 17);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Click += new System.EventHandler(this.TxtMatKhau_Click);
            this.txtMatKhau.MouseHover += new System.EventHandler(this.txtMatKhau_MouseHover);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenDangNhap.Location = new System.Drawing.Point(65, 241);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(220, 17);
            this.txtTenDangNhap.TabIndex = 4;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Click += new System.EventHandler(this.TxtTenDangNhap_Click);
            this.txtTenDangNhap.MouseHover += new System.EventHandler(this.txtTenDangNhap_MouseHover);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.BorderRadius = 0;
            this.btnDangNhap.ButtonText = "Đăng nhập";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Iconimage")));
            this.btnDangNhap.Iconimage_right = null;
            this.btnDangNhap.Iconimage_right_Selected = null;
            this.btnDangNhap.Iconimage_Selected = null;
            this.btnDangNhap.IconMarginLeft = 0;
            this.btnDangNhap.IconMarginRight = 0;
            this.btnDangNhap.IconRightVisible = true;
            this.btnDangNhap.IconRightZoom = 0D;
            this.btnDangNhap.IconVisible = true;
            this.btnDangNhap.IconZoom = 90D;
            this.btnDangNhap.IsTab = false;
            this.btnDangNhap.Location = new System.Drawing.Point(86, 398);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnDangNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnDangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangNhap.selected = false;
            this.btnDangNhap.Size = new System.Drawing.Size(150, 42);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Textcolor = System.Drawing.Color.White;
            this.btnDangNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelMatKhau.Location = new System.Drawing.Point(65, 337);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(220, 1);
            this.panelMatKhau.TabIndex = 2;
            // 
            // panelTenDangNhap
            // 
            this.panelTenDangNhap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelTenDangNhap.Location = new System.Drawing.Point(65, 265);
            this.panelTenDangNhap.Name = "panelTenDangNhap";
            this.panelTenDangNhap.Size = new System.Drawing.Size(220, 1);
            this.panelTenDangNhap.TabIndex = 2;
            // 
            // picLogoPass
            // 
            this.picLogoPass.Image = global::GUI.Properties.Resources.lock_2_26px;
            this.picLogoPass.Location = new System.Drawing.Point(34, 313);
            this.picLogoPass.Name = "picLogoPass";
            this.picLogoPass.Size = new System.Drawing.Size(25, 25);
            this.picLogoPass.TabIndex = 1;
            this.picLogoPass.TabStop = false;
            // 
            // picLogoName
            // 
            this.picLogoName.Image = global::GUI.Properties.Resources.user_24px;
            this.picLogoName.Location = new System.Drawing.Point(34, 241);
            this.picLogoName.Name = "picLogoName";
            this.picLogoName.Size = new System.Drawing.Size(25, 25);
            this.picLogoName.TabIndex = 1;
            this.picLogoName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GUI.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 5000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thoat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_thoat;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangNhap;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.Panel panelTenDangNhap;
        private System.Windows.Forms.PictureBox picLogoPass;
        private System.Windows.Forms.PictureBox picLogoName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Label lblThongBao;
    }
}

