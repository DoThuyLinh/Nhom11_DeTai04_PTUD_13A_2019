namespace GUI
{
    partial class frm_suaHopDong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtmNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayKyKet = new System.Windows.Forms.DateTimePicker();
            this.nudGiaTriHopDong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTriHopDong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.dtmNgayHetHan);
            this.panel1.Controls.Add(this.dtmNgayKyKet);
            this.panel1.Controls.Add(this.nudGiaTriHopDong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaHopDong);
            this.panel1.Controls.Add(this.txtTenHopDong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 726);
            this.panel1.TabIndex = 4;
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
            this.btnDong.Location = new System.Drawing.Point(177, 653);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnDong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnDong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDong.selected = false;
            this.btnDong.Size = new System.Drawing.Size(115, 42);
            this.btnDong.TabIndex = 27;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDong.Textcolor = System.Drawing.Color.White;
            this.btnDong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChon
            // 
            this.btnChon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChon.BorderRadius = 0;
            this.btnChon.ButtonText = "Chọn";
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.DisabledColor = System.Drawing.Color.Gray;
            this.btnChon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChon.Iconimage = null;
            this.btnChon.Iconimage_right = null;
            this.btnChon.Iconimage_right_Selected = null;
            this.btnChon.Iconimage_Selected = null;
            this.btnChon.IconMarginLeft = 0;
            this.btnChon.IconMarginRight = 0;
            this.btnChon.IconRightVisible = true;
            this.btnChon.IconRightZoom = 0D;
            this.btnChon.IconVisible = true;
            this.btnChon.IconZoom = 50D;
            this.btnChon.IsTab = false;
            this.btnChon.Location = new System.Drawing.Point(31, 653);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnChon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChon.selected = false;
            this.btnChon.Size = new System.Drawing.Size(115, 42);
            this.btnChon.TabIndex = 28;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChon.Textcolor = System.Drawing.Color.White;
            this.btnChon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dtmNgayHetHan
            // 
            this.dtmNgayHetHan.CustomFormat = "dd-MM-yyy";
            this.dtmNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayHetHan.Location = new System.Drawing.Point(800, 260);
            this.dtmNgayHetHan.Name = "dtmNgayHetHan";
            this.dtmNgayHetHan.Size = new System.Drawing.Size(376, 24);
            this.dtmNgayHetHan.TabIndex = 25;
            this.dtmNgayHetHan.Leave += new System.EventHandler(this.dtmNgayHetHan_Leave);
            // 
            // dtmNgayKyKet
            // 
            this.dtmNgayKyKet.CustomFormat = "dd-MM-yyy";
            this.dtmNgayKyKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayKyKet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayKyKet.Location = new System.Drawing.Point(225, 261);
            this.dtmNgayKyKet.Name = "dtmNgayKyKet";
            this.dtmNgayKyKet.Size = new System.Drawing.Size(295, 24);
            this.dtmNgayKyKet.TabIndex = 26;
            this.dtmNgayKyKet.Leave += new System.EventHandler(this.dtmNgayKyKet_Leave);
            // 
            // nudGiaTriHopDong
            // 
            this.nudGiaTriHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGiaTriHopDong.Location = new System.Drawing.Point(225, 333);
            this.nudGiaTriHopDong.Name = "nudGiaTriHopDong";
            this.nudGiaTriHopDong.Size = new System.Drawing.Size(295, 24);
            this.nudGiaTriHopDong.TabIndex = 24;
            this.nudGiaTriHopDong.Leave += new System.EventHandler(this.nudGiaTriHopDong_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(57, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá trị hợp đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(75, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(639, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(85, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày ký kết";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Enabled = false;
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(225, 191);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(295, 24);
            this.txtMaHopDong.TabIndex = 21;
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHopDong.Location = new System.Drawing.Point(800, 191);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(376, 24);
            this.txtTenHopDong.TabIndex = 21;
            this.txtTenHopDong.Leave += new System.EventHandler(this.txtTenHopDong_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(634, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên hợp đồng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pic_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 42);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(588, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sửa thông tin hợp đồng";
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Image = global::GUI.Properties.Resources.multiply_2_26px;
            this.pic_close.Location = new System.Drawing.Point(1281, 0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(26, 42);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_suaHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 726);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_suaHopDong";
            this.Text = "frm_suaHopDong";
            this.Load += new System.EventHandler(this.frm_suaHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTriHopDong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnChon;
        private System.Windows.Forms.DateTimePicker dtmNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtmNgayKyKet;
        private System.Windows.Forms.NumericUpDown nudGiaTriHopDong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}