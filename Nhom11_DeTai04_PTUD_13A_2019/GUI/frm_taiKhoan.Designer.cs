namespace GUI
{
    partial class frm_taiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiMatKhau.BorderRadius = 0;
            this.btnDoiMatKhau.ButtonText = "Đổi mật khẩu";
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoiMatKhau.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.Iconimage = null;
            this.btnDoiMatKhau.Iconimage_right = null;
            this.btnDoiMatKhau.Iconimage_right_Selected = null;
            this.btnDoiMatKhau.Iconimage_Selected = null;
            this.btnDoiMatKhau.IconMarginLeft = 0;
            this.btnDoiMatKhau.IconMarginRight = 0;
            this.btnDoiMatKhau.IconRightVisible = true;
            this.btnDoiMatKhau.IconRightZoom = 0D;
            this.btnDoiMatKhau.IconVisible = true;
            this.btnDoiMatKhau.IconZoom = 50D;
            this.btnDoiMatKhau.IsTab = false;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(33, 142);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDoiMatKhau.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnDoiMatKhau.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.selected = false;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(115, 42);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoiMatKhau.Textcolor = System.Drawing.Color.White;
            this.btnDoiMatKhau.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.ButtonText = "Đăng xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Iconimage = null;
            this.btnDangXuat.Iconimage_right = null;
            this.btnDangXuat.Iconimage_right_Selected = null;
            this.btnDangXuat.Iconimage_Selected = null;
            this.btnDangXuat.IconMarginLeft = 0;
            this.btnDangXuat.IconMarginRight = 0;
            this.btnDangXuat.IconRightVisible = true;
            this.btnDangXuat.IconRightZoom = 0D;
            this.btnDangXuat.IconVisible = true;
            this.btnDangXuat.IconZoom = 50D;
            this.btnDangXuat.IsTab = false;
            this.btnDangXuat.Location = new System.Drawing.Point(184, 142);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDangXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnDangXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangXuat.selected = false;
            this.btnDangXuat.Size = new System.Drawing.Size(115, 42);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangXuat.Textcolor = System.Drawing.Color.White;
            this.btnDangXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên";
            // 
            // frm_cirPicUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 209);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cirPicUser";
            this.Text = "frm_cirPicUser";
            this.Load += new System.EventHandler(this.frm_cirPicUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoiMatKhau;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangXuat;
        private System.Windows.Forms.Label label3;
    }
}