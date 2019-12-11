namespace GUI
{
    partial class frm_userMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_userMain));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartCongViec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimatior = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timeClose = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).BeginInit();
            this.slidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panelQuanLy.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCongViec)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.cirPicUser);
            this.panel1.Controls.Add(this.dtmToday);
            this.PanelAnimatior.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 42);
            this.panel1.TabIndex = 1;
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
            this.btnHelp.TabIndex = 12;
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
            this.dtmToday.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
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
            this.slidemenu.Size = new System.Drawing.Size(55, 726);
            this.slidemenu.TabIndex = 4;
            this.slidemenu.MouseHover += new System.EventHandler(this.Slidemenu_MouseHover);
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
            this.btnQuanLyCongViec.Click += new System.EventHandler(this.BtnQuanLyCongViec_Click);
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
            this.btnQuanLyDuAn.Click += new System.EventHandler(this.BtnQuanLyDuAn_Click);
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
            this.picMenu.Click += new System.EventHandler(this.PicMenu_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.Controls.Add(this.panel2);
            this.panelQuanLy.Controls.Add(this.panel4);
            this.panelQuanLy.Controls.Add(this.panel5);
            this.PanelAnimatior.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Location = new System.Drawing.Point(55, 42);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(1311, 726);
            this.panelQuanLy.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvCongViec);
            this.PanelAnimatior.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(6, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 298);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Công việc cần hoàn thành(0-7 ngày)";
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.AllowUserToAddRows = false;
            this.dgvCongViec.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvCongViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCongViec.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PanelAnimatior.SetDecoration(this.dgvCongViec, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dgvCongViec, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongViec.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCongViec.EnableHeadersVisualStyles = false;
            this.dgvCongViec.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCongViec.Location = new System.Drawing.Point(14, 32);
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.ReadOnly = true;
            this.dgvCongViec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCongViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCongViec.RowHeadersVisible = false;
            this.dgvCongViec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvCongViec.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongViec.Size = new System.Drawing.Size(1260, 249);
            this.dgvCongViec.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chartCongViec);
            this.PanelAnimatior.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 404);
            this.panel4.TabIndex = 7;
            // 
            // chartCongViec
            // 
            this.chartCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCongViec.BackColor = System.Drawing.SystemColors.Window;
            chartArea2.Name = "ChartArea1";
            this.chartCongViec.ChartAreas.Add(chartArea2);
            this.PanelAnimatior.SetDecoration(this.chartCongViec, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.chartCongViec, BunifuAnimatorNS.DecorationType.None);
            legend2.Name = "Legend1";
            this.chartCongViec.Legends.Add(legend2);
            this.chartCongViec.Location = new System.Drawing.Point(13, 14);
            this.chartCongViec.Name = "chartCongViec";
            this.chartCongViec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(111)))));
            series2.Legend = "Legend1";
            series2.Name = "Công việc (30-30 ngày)";
            this.chartCongViec.Series.Add(series2);
            this.chartCongViec.Size = new System.Drawing.Size(542, 359);
            this.chartCongViec.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dgvDuAn);
            this.PanelAnimatior.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(585, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 404);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dự án chậm tiến độ";
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.AllowUserToAddRows = false;
            this.dgvDuAn.AllowUserToDeleteRows = false;
            this.dgvDuAn.AllowUserToResizeColumns = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDuAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDuAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDuAn.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDuAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PanelAnimatior.SetDecoration(this.dgvDuAn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dgvDuAn, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDuAn.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDuAn.EnableHeadersVisualStyles = false;
            this.dgvDuAn.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDuAn.Location = new System.Drawing.Point(17, 29);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.ReadOnly = true;
            this.dgvDuAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDuAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDuAn.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDuAn.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDuAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuAn.Size = new System.Drawing.Size(678, 361);
            this.dgvDuAn.TabIndex = 1;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.LogoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation4;
            // 
            // PanelAnimatior
            // 
            this.PanelAnimatior.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimatior.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimatior.DefaultAnimation = animation3;
            // 
            // timeClose
            // 
            this.timeClose.Interval = 1000;
            this.timeClose.Tick += new System.EventHandler(this.timeClose_Tick);
            // 
            // frm_userMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.panel1);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_userMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_userMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_userMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).EndInit();
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panelQuanLy.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCongViec)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slidemenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyHopDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyCongViec;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyDuAn;
        private Bunifu.Framework.UI.BunifuImageButton picMenu;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCongViec;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatior;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private Bunifu.Framework.UI.BunifuDatepicker dtmToday;
        private CirclePictureBox cirPicUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.Timer timeClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
    }
}