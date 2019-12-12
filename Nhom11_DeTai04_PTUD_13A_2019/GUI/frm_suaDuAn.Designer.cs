namespace GUI
{
    partial class frm_suaDuAn
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
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.txtMaDuAn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoNha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.btnDong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtmNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.nudTienDoHoanThanh = new System.Windows.Forms.NumericUpDown();
            this.cboThanhPho = new System.Windows.Forms.ComboBox();
            this.cboQuanHuyen = new System.Windows.Forms.ComboBox();
            this.cboPhuongXa = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDoHoanThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Image = global::GUI.Properties.Resources.multiply_2_26px;
            this.pic_close.Location = new System.Drawing.Point(1718, 0);
            this.pic_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(26, 52);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(157, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(836, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tiến độ hoàn thành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(131, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(884, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(103, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDuAn.Location = new System.Drawing.Point(1073, 164);
            this.txtTenDuAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(505, 29);
            this.txtTenDuAn.TabIndex = 21;
            this.txtTenDuAn.Leave += new System.EventHandler(this.txtSoNha_Leave);
            // 
            // txtMaDuAn
            // 
            this.txtMaDuAn.Enabled = false;
            this.txtMaDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDuAn.Location = new System.Drawing.Point(309, 165);
            this.txtMaDuAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDuAn.Name = "txtMaDuAn";
            this.txtMaDuAn.Size = new System.Drawing.Size(391, 29);
            this.txtMaDuAn.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label11.Location = new System.Drawing.Point(136, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã dự án";
            // 
            // txtSoNha1
            // 
            this.txtSoNha1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoNha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNha1.Location = new System.Drawing.Point(309, 418);
            this.txtSoNha1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoNha1.Name = "txtSoNha1";
            this.txtSoNha1.Size = new System.Drawing.Size(757, 29);
            this.txtSoNha1.TabIndex = 21;
            this.txtSoNha1.Leave += new System.EventHandler(this.txtTenDuAn_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(917, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên dự án";
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(784, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sửa thông tin dự án";
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackColor = System.Drawing.SystemColors.Window;
            this.panelQuanLy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelQuanLy.Controls.Add(this.btnDong);
            this.panelQuanLy.Controls.Add(this.btnChon);
            this.panelQuanLy.Controls.Add(this.dtmNgayKetThuc);
            this.panelQuanLy.Controls.Add(this.dtmNgayBatDau);
            this.panelQuanLy.Controls.Add(this.nudTienDoHoanThanh);
            this.panelQuanLy.Controls.Add(this.cboThanhPho);
            this.panelQuanLy.Controls.Add(this.cboQuanHuyen);
            this.panelQuanLy.Controls.Add(this.cboPhuongXa);
            this.panelQuanLy.Controls.Add(this.cboTrangThai);
            this.panelQuanLy.Controls.Add(this.label10);
            this.panelQuanLy.Controls.Add(this.label9);
            this.panelQuanLy.Controls.Add(this.label8);
            this.panelQuanLy.Controls.Add(this.label5);
            this.panelQuanLy.Controls.Add(this.label7);
            this.panelQuanLy.Controls.Add(this.label6);
            this.panelQuanLy.Controls.Add(this.label4);
            this.panelQuanLy.Controls.Add(this.label3);
            this.panelQuanLy.Controls.Add(this.txtTenDuAn);
            this.panelQuanLy.Controls.Add(this.txtMaDuAn);
            this.panelQuanLy.Controls.Add(this.label11);
            this.panelQuanLy.Controls.Add(this.txtSoNha1);
            this.panelQuanLy.Controls.Add(this.label2);
            this.panelQuanLy.Controls.Add(this.panel2);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Location = new System.Drawing.Point(0, 0);
            this.panelQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(1748, 894);
            this.panelQuanLy.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnDong.Size = new System.Drawing.Size(153, 53);
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
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnChon.Location = new System.Drawing.Point(41, 804);
            this.btnChon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnChon.Name = "btnChon";
            this.btnChon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnChon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChon.selected = false;
            this.btnChon.Size = new System.Drawing.Size(153, 53);
            this.btnChon.TabIndex = 28;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChon.Textcolor = System.Drawing.Color.White;
            this.btnChon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dtmNgayKetThuc
            // 
            this.dtmNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmNgayKetThuc.CustomFormat = "dd-MM-yyy";
            this.dtmNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayKetThuc.Location = new System.Drawing.Point(1076, 242);
            this.dtmNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtmNgayKetThuc.Name = "dtmNgayKetThuc";
            this.dtmNgayKetThuc.Size = new System.Drawing.Size(502, 29);
            this.dtmNgayKetThuc.TabIndex = 25;
            this.dtmNgayKetThuc.Leave += new System.EventHandler(this.dtmNgayKetThuc_Leave);
            // 
            // dtmNgayBatDau
            // 
            this.dtmNgayBatDau.CustomFormat = "dd-MM-yyy";
            this.dtmNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayBatDau.Location = new System.Drawing.Point(309, 244);
            this.dtmNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtmNgayBatDau.Name = "dtmNgayBatDau";
            this.dtmNgayBatDau.Size = new System.Drawing.Size(392, 29);
            this.dtmNgayBatDau.TabIndex = 26;
            // 
            // nudTienDoHoanThanh
            // 
            this.nudTienDoHoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTienDoHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTienDoHoanThanh.Location = new System.Drawing.Point(1076, 324);
            this.nudTienDoHoanThanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudTienDoHoanThanh.Name = "nudTienDoHoanThanh";
            this.nudTienDoHoanThanh.Size = new System.Drawing.Size(502, 29);
            this.nudTienDoHoanThanh.TabIndex = 24;
            this.nudTienDoHoanThanh.Leave += new System.EventHandler(this.nudTienDoHoanThanh_Leave);
            // 
            // cboThanhPho
            // 
            this.cboThanhPho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThanhPho.FormattingEnabled = true;
            this.cboThanhPho.Location = new System.Drawing.Point(1225, 511);
            this.cboThanhPho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboThanhPho.Name = "cboThanhPho";
            this.cboThanhPho.Size = new System.Drawing.Size(392, 32);
            this.cboThanhPho.TabIndex = 23;
            this.cboThanhPho.SelectedIndexChanged += new System.EventHandler(this.cboThanhPho_SelectedIndexChanged);
            // 
            // cboQuanHuyen
            // 
            this.cboQuanHuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuanHuyen.FormattingEnabled = true;
            this.cboQuanHuyen.Location = new System.Drawing.Point(772, 511);
            this.cboQuanHuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboQuanHuyen.Name = "cboQuanHuyen";
            this.cboQuanHuyen.Size = new System.Drawing.Size(391, 32);
            this.cboQuanHuyen.TabIndex = 23;
            this.cboQuanHuyen.SelectedIndexChanged += new System.EventHandler(this.cboQuanHuyen_SelectedIndexChanged);
            // 
            // cboPhuongXa
            // 
            this.cboPhuongXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongXa.FormattingEnabled = true;
            this.cboPhuongXa.Location = new System.Drawing.Point(309, 511);
            this.cboPhuongXa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPhuongXa.Name = "cboPhuongXa";
            this.cboPhuongXa.Size = new System.Drawing.Size(391, 32);
            this.cboPhuongXa.TabIndex = 23;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(309, 330);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(391, 32);
            this.cboTrangThai.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label10.Location = new System.Drawing.Point(1221, 468);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Thành phố/tỉnh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label9.Location = new System.Drawing.Point(768, 468);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quận/Huyện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(309, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phường/xã";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_suaDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 894);
            this.Controls.Add(this.panelQuanLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_suaDuAn";
            this.Text = "frm_suaDuAn";
            this.Load += new System.EventHandler(this.frm_suaDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelQuanLy.ResumeLayout(false);
            this.panelQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDoHoanThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.TextBox txtMaDuAn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoNha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelQuanLy;
        private Bunifu.Framework.UI.BunifuFlatButton btnDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnChon;
        private System.Windows.Forms.DateTimePicker dtmNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDau;
        private System.Windows.Forms.NumericUpDown nudTienDoHoanThanh;
        private System.Windows.Forms.ComboBox cboThanhPho;
        private System.Windows.Forms.ComboBox cboQuanHuyen;
        private System.Windows.Forms.ComboBox cboPhuongXa;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}