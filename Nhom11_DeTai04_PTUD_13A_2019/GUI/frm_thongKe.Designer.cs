namespace GUI
{
    partial class frm_thongKe
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongKe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cirPicUser = new GUI.CirclePictureBox();
            this.dtmToday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.slidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyHopDong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyCongViec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyDuAn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboTienDo = new System.Windows.Forms.ComboBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtmNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.cboChonDuAn = new System.Windows.Forms.ComboBox();
            this.dtmNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThongKeDuLieu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cboThongKe = new System.Windows.Forms.ComboBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimatior = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.lblThang = new System.Windows.Forms.Label();
            this.cboTinhTongLuongTheoDuAn = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).BeginInit();
            this.slidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panelQuanLy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.PanelAnimatior.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(18, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 579);
            this.panel1.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.PanelAnimatior.SetDecoration(this.reportViewer1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.reportViewer1, BunifuAnimatorNS.DecorationType.None);
            this.reportViewer1.Location = new System.Drawing.Point(21, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1237, 536);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.cirPicUser);
            this.panel2.Controls.Add(this.dtmToday);
            this.PanelAnimatior.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 42);
            this.panel2.TabIndex = 7;
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Help";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = null;
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 50D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(1238, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(80, 30);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Textcolor = System.Drawing.Color.Black;
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cirPicUser
            // 
            this.cirPicUser.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.cirPicUser, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.cirPicUser, BunifuAnimatorNS.DecorationType.None);
            this.cirPicUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.cirPicUser.Image = global::GUI.Properties.Resources.admin;
            this.cirPicUser.Location = new System.Drawing.Point(1324, 0);
            this.cirPicUser.Name = "cirPicUser";
            this.cirPicUser.Size = new System.Drawing.Size(42, 42);
            this.cirPicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cirPicUser.TabIndex = 6;
            this.cirPicUser.TabStop = false;
            this.cirPicUser.Click += new System.EventHandler(this.cirPicUser_Click);
            // 
            // dtmToday
            // 
            this.dtmToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dtmToday.BorderRadius = 0;
            this.PanelAnimatior.SetDecoration(this.dtmToday, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dtmToday, BunifuAnimatorNS.DecorationType.None);
            this.dtmToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtmToday.ForeColor = System.Drawing.Color.Black;
            this.dtmToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmToday.FormatCustom = null;
            this.dtmToday.Location = new System.Drawing.Point(0, 0);
            this.dtmToday.Name = "dtmToday";
            this.dtmToday.Size = new System.Drawing.Size(200, 42);
            this.dtmToday.TabIndex = 5;
            this.dtmToday.Value = new System.DateTime(2019, 10, 30, 13, 22, 48, 0);
            // 
            // slidemenu
            // 
            this.slidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.slidemenu.Controls.Add(this.logo);
            this.slidemenu.Controls.Add(this.btnThongKe);
            this.slidemenu.Controls.Add(this.btnQuanLyNhanVien);
            this.slidemenu.Controls.Add(this.btnQuanLyHopDong);
            this.slidemenu.Controls.Add(this.btnQuanLyCongViec);
            this.slidemenu.Controls.Add(this.btnQuanLyDuAn);
            this.slidemenu.Controls.Add(this.picMenu);
            this.PanelAnimatior.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.slidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidemenu.Location = new System.Drawing.Point(0, 42);
            this.slidemenu.Name = "slidemenu";
            this.slidemenu.Size = new System.Drawing.Size(55, 684);
            this.slidemenu.TabIndex = 8;
            this.slidemenu.MouseHover += new System.EventHandler(this.slidemenu_MouseHover);
            // 
            // logo
            // 
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Enabled = false;
            this.logo.Image = global::GUI.Properties.Resources.logo2;
            this.logo.Location = new System.Drawing.Point(0, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            this.logo.MouseHover += new System.EventHandler(this.logo_MouseHover);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.ButtonText = "Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.btnThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKe.Iconimage = global::GUI.Properties.Resources.tk;
            this.btnThongKe.Iconimage_right = null;
            this.btnThongKe.Iconimage_right_Selected = null;
            this.btnThongKe.Iconimage_Selected = null;
            this.btnThongKe.IconMarginLeft = 0;
            this.btnThongKe.IconMarginRight = 0;
            this.btnThongKe.IconRightVisible = true;
            this.btnThongKe.IconRightZoom = 0D;
            this.btnThongKe.IconVisible = true;
            this.btnThongKe.IconZoom = 50D;
            this.btnThongKe.IsTab = false;
            this.btnThongKe.Location = new System.Drawing.Point(3, 321);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKe.selected = false;
            this.btnThongKe.Size = new System.Drawing.Size(194, 48);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKe.Textcolor = System.Drawing.Color.White;
            this.btnThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThongKe.MouseHover += new System.EventHandler(this.btnThongKe_MouseHover);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhanVien.BorderRadius = 0;
            this.btnQuanLyNhanVien.ButtonText = "Nhân viên";
            this.btnQuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.Iconimage = global::GUI.Properties.Resources.qlnv;
            this.btnQuanLyNhanVien.Iconimage_right = null;
            this.btnQuanLyNhanVien.Iconimage_right_Selected = null;
            this.btnQuanLyNhanVien.Iconimage_Selected = null;
            this.btnQuanLyNhanVien.IconMarginLeft = 0;
            this.btnQuanLyNhanVien.IconMarginRight = 0;
            this.btnQuanLyNhanVien.IconRightVisible = true;
            this.btnQuanLyNhanVien.IconRightZoom = 0D;
            this.btnQuanLyNhanVien.IconVisible = true;
            this.btnQuanLyNhanVien.IconZoom = 60D;
            this.btnQuanLyNhanVien.IsTab = false;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(4, 267);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnQuanLyNhanVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.selected = false;
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(193, 48);
            this.btnQuanLyNhanVien.TabIndex = 4;
            this.btnQuanLyNhanVien.Text = "Nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyNhanVien.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            this.btnQuanLyNhanVien.MouseHover += new System.EventHandler(this.btnQuanLyNhanVien_MouseHover);
            // 
            // btnQuanLyHopDong
            // 
            this.btnQuanLyHopDong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyHopDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyHopDong.BorderRadius = 0;
            this.btnQuanLyHopDong.ButtonText = "Hợp đồng";
            this.btnQuanLyHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnQuanLyHopDong, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnQuanLyHopDong, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyHopDong.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyHopDong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHopDong.Iconimage = global::GUI.Properties.Resources.qlhd;
            this.btnQuanLyHopDong.Iconimage_right = null;
            this.btnQuanLyHopDong.Iconimage_right_Selected = null;
            this.btnQuanLyHopDong.Iconimage_Selected = null;
            this.btnQuanLyHopDong.IconMarginLeft = 0;
            this.btnQuanLyHopDong.IconMarginRight = 0;
            this.btnQuanLyHopDong.IconRightVisible = true;
            this.btnQuanLyHopDong.IconRightZoom = 0D;
            this.btnQuanLyHopDong.IconVisible = true;
            this.btnQuanLyHopDong.IconZoom = 50D;
            this.btnQuanLyHopDong.IsTab = false;
            this.btnQuanLyHopDong.Location = new System.Drawing.Point(4, 213);
            this.btnQuanLyHopDong.Name = "btnQuanLyHopDong";
            this.btnQuanLyHopDong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyHopDong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnQuanLyHopDong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyHopDong.selected = false;
            this.btnQuanLyHopDong.Size = new System.Drawing.Size(193, 48);
            this.btnQuanLyHopDong.TabIndex = 3;
            this.btnQuanLyHopDong.Text = "Hợp đồng";
            this.btnQuanLyHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyHopDong.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyHopDong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHopDong.Click += new System.EventHandler(this.btnQuanLyHopDong_Click);
            this.btnQuanLyHopDong.MouseHover += new System.EventHandler(this.btnQuanLyHopDong_MouseHover);
            // 
            // btnQuanLyCongViec
            // 
            this.btnQuanLyCongViec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyCongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyCongViec.BorderRadius = 0;
            this.btnQuanLyCongViec.ButtonText = "Công việc";
            this.btnQuanLyCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnQuanLyCongViec, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnQuanLyCongViec, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyCongViec.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyCongViec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyCongViec.Iconimage = global::GUI.Properties.Resources.qlcv;
            this.btnQuanLyCongViec.Iconimage_right = null;
            this.btnQuanLyCongViec.Iconimage_right_Selected = null;
            this.btnQuanLyCongViec.Iconimage_Selected = null;
            this.btnQuanLyCongViec.IconMarginLeft = 0;
            this.btnQuanLyCongViec.IconMarginRight = 0;
            this.btnQuanLyCongViec.IconRightVisible = true;
            this.btnQuanLyCongViec.IconRightZoom = 0D;
            this.btnQuanLyCongViec.IconVisible = true;
            this.btnQuanLyCongViec.IconZoom = 45D;
            this.btnQuanLyCongViec.IsTab = false;
            this.btnQuanLyCongViec.Location = new System.Drawing.Point(4, 158);
            this.btnQuanLyCongViec.Name = "btnQuanLyCongViec";
            this.btnQuanLyCongViec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyCongViec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnQuanLyCongViec.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyCongViec.selected = false;
            this.btnQuanLyCongViec.Size = new System.Drawing.Size(193, 48);
            this.btnQuanLyCongViec.TabIndex = 2;
            this.btnQuanLyCongViec.Text = "Công việc";
            this.btnQuanLyCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyCongViec.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyCongViec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyCongViec.Click += new System.EventHandler(this.btnQuanLyCongViec_Click);
            this.btnQuanLyCongViec.MouseHover += new System.EventHandler(this.btnQuanLyCongViec_MouseHover);
            // 
            // btnQuanLyDuAn
            // 
            this.btnQuanLyDuAn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnQuanLyDuAn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyDuAn.BorderRadius = 0;
            this.btnQuanLyDuAn.ButtonText = "Dự án";
            this.btnQuanLyDuAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnQuanLyDuAn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnQuanLyDuAn, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyDuAn.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyDuAn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyDuAn.Iconimage = global::GUI.Properties.Resources.qlda;
            this.btnQuanLyDuAn.Iconimage_right = null;
            this.btnQuanLyDuAn.Iconimage_right_Selected = null;
            this.btnQuanLyDuAn.Iconimage_Selected = null;
            this.btnQuanLyDuAn.IconMarginLeft = 0;
            this.btnQuanLyDuAn.IconMarginRight = 0;
            this.btnQuanLyDuAn.IconRightVisible = true;
            this.btnQuanLyDuAn.IconRightZoom = 0D;
            this.btnQuanLyDuAn.IconVisible = true;
            this.btnQuanLyDuAn.IconZoom = 60D;
            this.btnQuanLyDuAn.IsTab = false;
            this.btnQuanLyDuAn.Location = new System.Drawing.Point(4, 104);
            this.btnQuanLyDuAn.Name = "btnQuanLyDuAn";
            this.btnQuanLyDuAn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnQuanLyDuAn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnQuanLyDuAn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyDuAn.selected = false;
            this.btnQuanLyDuAn.Size = new System.Drawing.Size(193, 48);
            this.btnQuanLyDuAn.TabIndex = 1;
            this.btnQuanLyDuAn.Text = "Dự án";
            this.btnQuanLyDuAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyDuAn.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyDuAn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDuAn.Click += new System.EventHandler(this.btnQuanLyDuAn_Click);
            this.btnQuanLyDuAn.MouseHover += new System.EventHandler(this.btnQuanLyDuAn_MouseHover);
            // 
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.PanelAnimatior.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
            this.picMenu.Image = global::GUI.Properties.Resources.menu_16;
            this.picMenu.ImageActive = null;
            this.picMenu.Location = new System.Drawing.Point(30, 0);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(25, 25);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Zoom = 10;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackColor = System.Drawing.SystemColors.Window;
            this.panelQuanLy.Controls.Add(this.lblThang);
            this.panelQuanLy.Controls.Add(this.cboNam);
            this.panelQuanLy.Controls.Add(this.cboThang);
            this.panelQuanLy.Controls.Add(this.cboTienDo);
            this.panelQuanLy.Controls.Add(this.lblDenNgay);
            this.panelQuanLy.Controls.Add(this.lblTuNgay);
            this.panelQuanLy.Controls.Add(this.dtmNgayKetThuc);
            this.panelQuanLy.Controls.Add(this.cboTinhTongLuongTheoDuAn);
            this.panelQuanLy.Controls.Add(this.cboChonDuAn);
            this.panelQuanLy.Controls.Add(this.dtmNgayBatDau);
            this.panelQuanLy.Controls.Add(this.panel3);
            this.panelQuanLy.Controls.Add(this.panel1);
            this.PanelAnimatior.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Location = new System.Drawing.Point(55, 42);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(1311, 684);
            this.panelQuanLy.TabIndex = 9;
            // 
            // cboNam
            // 
            this.PanelAnimatior.SetDecoration(this.cboNam, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboNam, BunifuAnimatorNS.DecorationType.None);
            this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(714, 47);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(228, 26);
            this.cboNam.TabIndex = 56;
            this.cboNam.Text = "2019";
            this.cboNam.Visible = false;
            // 
            // cboThang
            // 
            this.PanelAnimatior.SetDecoration(this.cboThang, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboThang, BunifuAnimatorNS.DecorationType.None);
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(465, 47);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(228, 26);
            this.cboThang.TabIndex = 56;
            this.cboThang.Text = "1";
            this.cboThang.Visible = false;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // cboTienDo
            // 
            this.PanelAnimatior.SetDecoration(this.cboTienDo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboTienDo, BunifuAnimatorNS.DecorationType.None);
            this.cboTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTienDo.FormattingEnabled = true;
            this.cboTienDo.Items.AddRange(new object[] {
            "Hoàn thành",
            "Đang thực hiện",
            "Chưa thực hiện",
            "Trễ tiến độ"});
            this.cboTienDo.Location = new System.Drawing.Point(465, 48);
            this.cboTienDo.Name = "cboTienDo";
            this.cboTienDo.Size = new System.Drawing.Size(228, 26);
            this.cboTienDo.TabIndex = 55;
            this.cboTienDo.Text = "Tiến độ";
            this.cboTienDo.Visible = false;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.lblDenNgay, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.lblDenNgay, BunifuAnimatorNS.DecorationType.None);
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lblDenNgay.Location = new System.Drawing.Point(767, 55);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(70, 18);
            this.lblDenNgay.TabIndex = 54;
            this.lblDenNgay.Text = "Đến ngày";
            this.lblDenNgay.Visible = false;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.lblTuNgay, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.lblTuNgay, BunifuAnimatorNS.DecorationType.None);
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lblTuNgay.Location = new System.Drawing.Point(499, 55);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(60, 18);
            this.lblTuNgay.TabIndex = 53;
            this.lblTuNgay.Text = "Từ ngày";
            this.lblTuNgay.Visible = false;
            // 
            // dtmNgayKetThuc
            // 
            this.LogoAnimator.SetDecoration(this.dtmNgayKetThuc, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dtmNgayKetThuc, BunifuAnimatorNS.DecorationType.None);
            this.dtmNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayKetThuc.Location = new System.Drawing.Point(843, 50);
            this.dtmNgayKetThuc.Name = "dtmNgayKetThuc";
            this.dtmNgayKetThuc.Size = new System.Drawing.Size(196, 24);
            this.dtmNgayKetThuc.TabIndex = 52;
            this.dtmNgayKetThuc.Visible = false;
            // 
            // cboChonDuAn
            // 
            this.PanelAnimatior.SetDecoration(this.cboChonDuAn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboChonDuAn, BunifuAnimatorNS.DecorationType.None);
            this.cboChonDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonDuAn.FormattingEnabled = true;
            this.cboChonDuAn.Location = new System.Drawing.Point(6, 48);
            this.cboChonDuAn.Name = "cboChonDuAn";
            this.cboChonDuAn.Size = new System.Drawing.Size(398, 26);
            this.cboChonDuAn.TabIndex = 51;
            this.cboChonDuAn.Text = "Dự án";
            this.cboChonDuAn.Visible = false;
            this.cboChonDuAn.SelectedIndexChanged += new System.EventHandler(this.cboChonDuAn_SelectedIndexChanged);
            // 
            // dtmNgayBatDau
            // 
            this.LogoAnimator.SetDecoration(this.dtmNgayBatDau, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dtmNgayBatDau, BunifuAnimatorNS.DecorationType.None);
            this.dtmNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayBatDau.Location = new System.Drawing.Point(565, 50);
            this.dtmNgayBatDau.Name = "dtmNgayBatDau";
            this.dtmNgayBatDau.Size = new System.Drawing.Size(196, 24);
            this.dtmNgayBatDau.TabIndex = 50;
            this.dtmNgayBatDau.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThongKeDuLieu);
            this.panel3.Controls.Add(this.cboThongKe);
            this.PanelAnimatior.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 42);
            this.panel3.TabIndex = 5;
            // 
            // btnThongKeDuLieu
            // 
            this.btnThongKeDuLieu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThongKeDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThongKeDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKeDuLieu.BorderRadius = 0;
            this.btnThongKeDuLieu.ButtonText = "Thống kê";
            this.btnThongKeDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnThongKeDuLieu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnThongKeDuLieu, BunifuAnimatorNS.DecorationType.None);
            this.btnThongKeDuLieu.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKeDuLieu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKeDuLieu.Iconimage = global::GUI.Properties.Resources.tk;
            this.btnThongKeDuLieu.Iconimage_right = null;
            this.btnThongKeDuLieu.Iconimage_right_Selected = null;
            this.btnThongKeDuLieu.Iconimage_Selected = null;
            this.btnThongKeDuLieu.IconMarginLeft = 0;
            this.btnThongKeDuLieu.IconMarginRight = 0;
            this.btnThongKeDuLieu.IconRightVisible = true;
            this.btnThongKeDuLieu.IconRightZoom = 0D;
            this.btnThongKeDuLieu.IconVisible = true;
            this.btnThongKeDuLieu.IconZoom = 50D;
            this.btnThongKeDuLieu.IsTab = false;
            this.btnThongKeDuLieu.Location = new System.Drawing.Point(465, 0);
            this.btnThongKeDuLieu.Name = "btnThongKeDuLieu";
            this.btnThongKeDuLieu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThongKeDuLieu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnThongKeDuLieu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKeDuLieu.selected = false;
            this.btnThongKeDuLieu.Size = new System.Drawing.Size(150, 42);
            this.btnThongKeDuLieu.TabIndex = 50;
            this.btnThongKeDuLieu.Text = "Thống kê";
            this.btnThongKeDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKeDuLieu.Textcolor = System.Drawing.Color.White;
            this.btnThongKeDuLieu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeDuLieu.Click += new System.EventHandler(this.btnThongKeDuLieu_Click);
            // 
            // cboThongKe
            // 
            this.PanelAnimatior.SetDecoration(this.cboThongKe, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboThongKe, BunifuAnimatorNS.DecorationType.None);
            this.cboThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe.FormattingEnabled = true;
            this.cboThongKe.Location = new System.Drawing.Point(6, 6);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(453, 26);
            this.cboThongKe.TabIndex = 49;
            this.cboThongKe.Text = "Thống kê tổng số nhân viên theo dự án";
            this.cboThongKe.SelectedIndexChanged += new System.EventHandler(this.cboThongKe_SelectedIndexChanged);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.LogoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimatior
            // 
            this.PanelAnimatior.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimatior.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimatior.DefaultAnimation = animation1;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.lblThang, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.lblThang, BunifuAnimatorNS.DecorationType.None);
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lblThang.Location = new System.Drawing.Point(410, 51);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(49, 18);
            this.lblThang.TabIndex = 57;
            this.lblThang.Text = "Tháng";
            this.lblThang.Visible = false;
            // 
            // cboTinhTongLuongTheoDuAn
            // 
            this.PanelAnimatior.SetDecoration(this.cboTinhTongLuongTheoDuAn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cboTinhTongLuongTheoDuAn, BunifuAnimatorNS.DecorationType.None);
            this.cboTinhTongLuongTheoDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTongLuongTheoDuAn.FormattingEnabled = true;
            this.cboTinhTongLuongTheoDuAn.Location = new System.Drawing.Point(465, 48);
            this.cboTinhTongLuongTheoDuAn.Name = "cboTinhTongLuongTheoDuAn";
            this.cboTinhTongLuongTheoDuAn.Size = new System.Drawing.Size(398, 26);
            this.cboTinhTongLuongTheoDuAn.TabIndex = 51;
            this.cboTinhTongLuongTheoDuAn.Text = "Dự án";
            this.cboTinhTongLuongTheoDuAn.Visible = false;
            this.cboTinhTongLuongTheoDuAn.SelectedIndexChanged += new System.EventHandler(this.cboChonDuAn_SelectedIndexChanged);
            // 
            // frm_thongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 726);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.panel2);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_thongKe";
            this.Text = "frm_thongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_thongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).EndInit();
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panelQuanLy.ResumeLayout(false);
            this.panelQuanLy.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CirclePictureBox cirPicUser;
        private Bunifu.Framework.UI.BunifuDatepicker dtmToday;
        private System.Windows.Forms.Panel slidemenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyHopDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyCongViec;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyDuAn;
        private Bunifu.Framework.UI.BunifuImageButton picMenu;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Panel panel3;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatior;
        private System.Windows.Forms.Timer timerClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cboThongKe;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDau;
        private System.Windows.Forms.ComboBox cboChonDuAn;
        private System.Windows.Forms.DateTimePicker dtmNgayKetThuc;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKeDuLieu;
        private System.Windows.Forms.ComboBox cboTienDo;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboTinhTongLuongTheoDuAn;
    }
}