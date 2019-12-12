namespace GUI
{
    partial class frm_themCongViec
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboDuAn = new System.Windows.Forms.ComboBox();
            this.nudTienDoCongViec = new System.Windows.Forms.NumericUpDown();
            this.dtmNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboViTriCongViec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDoCongViec)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pic_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1744, 52);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(784, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm công việc mới";
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Image = global::GUI.Properties.Resources.multiply_2_26px;
            this.pic_close.Location = new System.Drawing.Point(1704, 4);
            this.pic_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(26, 26);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(859, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên công việc";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCongViec.Location = new System.Drawing.Point(1067, 235);
            this.txtTenCongViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(500, 29);
            this.txtTenCongViec.TabIndex = 21;
            this.txtTenCongViec.Leave += new System.EventHandler(this.txtTenCongViec_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(83, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(861, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(111, 411);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(827, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tiến độ công việc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(145, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dự án";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(300, 407);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(391, 32);
            this.cboTrangThai.TabIndex = 23;
            // 
            // cboDuAn
            // 
            this.cboDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDuAn.FormattingEnabled = true;
            this.cboDuAn.Location = new System.Drawing.Point(300, 235);
            this.cboDuAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDuAn.Name = "cboDuAn";
            this.cboDuAn.Size = new System.Drawing.Size(391, 32);
            this.cboDuAn.TabIndex = 23;
            this.cboDuAn.Leave += new System.EventHandler(this.cboDuAn_Leave);
            // 
            // nudTienDoCongViec
            // 
            this.nudTienDoCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTienDoCongViec.Location = new System.Drawing.Point(1067, 401);
            this.nudTienDoCongViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudTienDoCongViec.Name = "nudTienDoCongViec";
            this.nudTienDoCongViec.Size = new System.Drawing.Size(501, 29);
            this.nudTienDoCongViec.TabIndex = 24;
            // 
            // dtmNgayKetThuc
            // 
            this.dtmNgayKetThuc.CustomFormat = "dd-MM-yyy";
            this.dtmNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayKetThuc.Location = new System.Drawing.Point(1067, 321);
            this.dtmNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtmNgayKetThuc.Name = "dtmNgayKetThuc";
            this.dtmNgayKetThuc.Size = new System.Drawing.Size(501, 29);
            this.dtmNgayKetThuc.TabIndex = 26;
            // 
            // dtmNgayBatDau
            // 
            this.dtmNgayBatDau.CustomFormat = "dd-MM-yyy";
            this.dtmNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayBatDau.Location = new System.Drawing.Point(300, 326);
            this.dtmNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtmNgayBatDau.Name = "dtmNgayBatDau";
            this.dtmNgayBatDau.Size = new System.Drawing.Size(391, 29);
            this.dtmNgayBatDau.TabIndex = 25;
            this.dtmNgayBatDau.Leave += new System.EventHandler(this.dtmNgayKetThuc_Leave);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 50D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(41, 804);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(153, 52);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDong.BorderRadius = 0;
            this.btnDong.ButtonText = "Đóng";
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.DisabledColor = System.Drawing.Color.Gray;
            this.btnDong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDong.Iconimage = null;
            this.btnDong.Iconimage_right = null;
            this.btnDong.Iconimage_right_Selected = null;
            this.btnDong.Iconimage_Selected = null;
            this.btnDong.IconMarginLeft = 0;
            this.btnDong.IconMarginRight = 0;
            this.btnDong.IconRightVisible = true;
            this.btnDong.IconRightZoom = 0D;
            this.btnDong.IconVisible = true;
            this.btnDong.IconZoom = 50D;
            this.btnDong.IsTab = false;
            this.btnDong.Location = new System.Drawing.Point(236, 804);
            this.btnDong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnDong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDong.selected = false;
            this.btnDong.Size = new System.Drawing.Size(153, 52);
            this.btnDong.TabIndex = 27;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDong.Textcolor = System.Drawing.Color.White;
            this.btnDong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.dtmNgayBatDau);
            this.panel1.Controls.Add(this.dtmNgayKetThuc);
            this.panel1.Controls.Add(this.nudTienDoCongViec);
            this.panel1.Controls.Add(this.cboDuAn);
            this.panel1.Controls.Add(this.cboViTriCongViec);
            this.panel1.Controls.Add(this.cboTrangThai);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenCongViec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 894);
            this.panel1.TabIndex = 0;
            // 
            // cboViTriCongViec
            // 
            this.cboViTriCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViTriCongViec.FormattingEnabled = true;
            this.cboViTriCongViec.Items.AddRange(new object[] {
            "Quản Lý",
            "Khảo Sát",
            "Thiết Kế",
            "Giám Sát",
            "Thi Công"});
            this.cboViTriCongViec.Location = new System.Drawing.Point(300, 494);
            this.cboViTriCongViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboViTriCongViec.Name = "cboViTriCongViec";
            this.cboViTriCongViec.Size = new System.Drawing.Size(391, 32);
            this.cboViTriCongViec.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(111, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vị trí công việc";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_themCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 894);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_themCongViec";
            this.Text = "frm_themCongViec";
            this.Load += new System.EventHandler(this.frm_themCongViec_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDoCongViec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboDuAn;
        private System.Windows.Forms.NumericUpDown nudTienDoCongViec;
        private System.Windows.Forms.DateTimePicker dtmNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDau;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboViTriCongViec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}