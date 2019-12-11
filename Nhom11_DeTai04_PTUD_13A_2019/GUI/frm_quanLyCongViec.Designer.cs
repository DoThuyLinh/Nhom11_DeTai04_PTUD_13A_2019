namespace GUI
{
    partial class frm_quanLyCongViec
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_quanLyCongViec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_tienDoHoanThanh = new System.Windows.Forms.Label();
            this.pro_tienDoHoanThanh = new Bunifu.Framework.UI.BunifuProgressBar();
            this.txt_trangThai = new System.Windows.Forms.TextBox();
            this.dtm_ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtm_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tenCongViec = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_congViec = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtmToday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.slidemenu = new System.Windows.Forms.Panel();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelAnimatior = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuaCongViec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyHopDong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyCongViec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyDuAn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.cirPicUser = new GUI.CirclePictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_congViec)).BeginInit();
            this.panel1.SuspendLayout();
            this.slidemenu.SuspendLayout();
            this.panelQuanLy.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_tienDoHoanThanh);
            this.panel3.Controls.Add(this.pro_tienDoHoanThanh);
            this.panel3.Controls.Add(this.txt_trangThai);
            this.panel3.Controls.Add(this.dtm_ngayKetThuc);
            this.panel3.Controls.Add(this.dtm_ngayBatDau);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_tenCongViec);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.PanelAnimatior.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(15, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 255);
            this.panel3.TabIndex = 1;
            // 
            // lbl_tienDoHoanThanh
            // 
            this.lbl_tienDoHoanThanh.AutoSize = true;
            this.lbl_tienDoHoanThanh.BackColor = System.Drawing.Color.Teal;
            this.LogoAnimator.SetDecoration(this.lbl_tienDoHoanThanh, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.lbl_tienDoHoanThanh, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tienDoHoanThanh.Location = new System.Drawing.Point(99, 105);
            this.lbl_tienDoHoanThanh.Name = "lbl_tienDoHoanThanh";
            this.lbl_tienDoHoanThanh.Size = new System.Drawing.Size(27, 13);
            this.lbl_tienDoHoanThanh.TabIndex = 6;
            this.lbl_tienDoHoanThanh.Text = "30%";
            // 
            // pro_tienDoHoanThanh
            // 
            this.pro_tienDoHoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pro_tienDoHoanThanh.BorderRadius = 5;
            this.LogoAnimator.SetDecoration(this.pro_tienDoHoanThanh, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.pro_tienDoHoanThanh, BunifuAnimatorNS.DecorationType.None);
            this.pro_tienDoHoanThanh.Location = new System.Drawing.Point(56, 104);
            this.pro_tienDoHoanThanh.MaximumValue = 100;
            this.pro_tienDoHoanThanh.Name = "pro_tienDoHoanThanh";
            this.pro_tienDoHoanThanh.ProgressColor = System.Drawing.Color.Teal;
            this.pro_tienDoHoanThanh.Size = new System.Drawing.Size(321, 15);
            this.pro_tienDoHoanThanh.TabIndex = 5;
            this.pro_tienDoHoanThanh.Value = 30;
            // 
            // txt_trangThai
            // 
            this.LogoAnimator.SetDecoration(this.txt_trangThai, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.txt_trangThai, BunifuAnimatorNS.DecorationType.None);
            this.txt_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangThai.Location = new System.Drawing.Point(177, 209);
            this.txt_trangThai.Name = "txt_trangThai";
            this.txt_trangThai.ReadOnly = true;
            this.txt_trangThai.Size = new System.Drawing.Size(200, 24);
            this.txt_trangThai.TabIndex = 4;
            // 
            // dtm_ngayKetThuc
            // 
            this.LogoAnimator.SetDecoration(this.dtm_ngayKetThuc, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dtm_ngayKetThuc, BunifuAnimatorNS.DecorationType.None);
            this.dtm_ngayKetThuc.Enabled = false;
            this.dtm_ngayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_ngayKetThuc.Location = new System.Drawing.Point(177, 171);
            this.dtm_ngayKetThuc.Name = "dtm_ngayKetThuc";
            this.dtm_ngayKetThuc.Size = new System.Drawing.Size(200, 24);
            this.dtm_ngayKetThuc.TabIndex = 3;
            // 
            // dtm_ngayBatDau
            // 
            this.LogoAnimator.SetDecoration(this.dtm_ngayBatDau, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dtm_ngayBatDau, BunifuAnimatorNS.DecorationType.None);
            this.dtm_ngayBatDau.Enabled = false;
            this.dtm_ngayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_ngayBatDau.Location = new System.Drawing.Point(177, 135);
            this.dtm_ngayBatDau.Name = "dtm_ngayBatDau";
            this.dtm_ngayBatDau.Size = new System.Drawing.Size(200, 24);
            this.dtm_ngayBatDau.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(74, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(49, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(53, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // lbl_tenCongViec
            // 
            this.lbl_tenCongViec.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.lbl_tenCongViec, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.lbl_tenCongViec, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tenCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenCongViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lbl_tenCongViec.Location = new System.Drawing.Point(36, 63);
            this.lbl_tenCongViec.Name = "lbl_tenCongViec";
            this.lbl_tenCongViec.Size = new System.Drawing.Size(131, 24);
            this.lbl_tenCongViec.TabIndex = 1;
            this.lbl_tenCongViec.Text = "Tên công việc";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Chi tiết";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(85, 41);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Chi tiết";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.dgv_congViec);
            this.PanelAnimatior.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(15, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 397);
            this.panel2.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Công việc";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(85, 41);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "Công việc";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgv_congViec
            // 
            this.dgv_congViec.AllowUserToAddRows = false;
            this.dgv_congViec.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_congViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_congViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_congViec.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_congViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_congViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PanelAnimatior.SetDecoration(this.dgv_congViec, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dgv_congViec, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_congViec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_congViec.EnableHeadersVisualStyles = false;
            this.dgv_congViec.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_congViec.Location = new System.Drawing.Point(16, 62);
            this.dgv_congViec.Name = "dgv_congViec";
            this.dgv_congViec.ReadOnly = true;
            this.dgv_congViec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_congViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_congViec.RowHeadersVisible = false;
            this.dgv_congViec.RowHeadersWidth = 50;
            this.dgv_congViec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_congViec.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_congViec.RowTemplate.Height = 27;
            this.dgv_congViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_congViec.Size = new System.Drawing.Size(1250, 318);
            this.dgv_congViec.TabIndex = 2;
            this.dgv_congViec.SelectionChanged += new System.EventHandler(this.dgv_congViec_SelectionChanged);
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
            this.panel1.TabIndex = 3;
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
            this.slidemenu.Size = new System.Drawing.Size(55, 726);
            this.slidemenu.TabIndex = 5;
            this.slidemenu.MouseHover += new System.EventHandler(this.slidemenu_MouseHover);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.Controls.Add(this.panel4);
            this.panelQuanLy.Controls.Add(this.panel3);
            this.panelQuanLy.Controls.Add(this.panel2);
            this.PanelAnimatior.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Location = new System.Drawing.Point(55, 42);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(1311, 726);
            this.panelQuanLy.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnXuat);
            this.panel4.Controls.Add(this.btnSuaCongViec);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Controls.Add(this.btnThem);
            this.PanelAnimatior.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1311, 43);
            this.panel4.TabIndex = 5;
            // 
            // PanelAnimatior
            // 
            this.PanelAnimatior.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimatior.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimatior.DefaultAnimation = animation2;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnRefresh, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnRefresh, BunifuAnimatorNS.DecorationType.None);
            this.btnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefresh.Iconimage = global::GUI.Properties.Resources.refresh_26px;
            this.btnRefresh.Iconimage_right = null;
            this.btnRefresh.Iconimage_right_Selected = null;
            this.btnRefresh.Iconimage_Selected = null;
            this.btnRefresh.IconMarginLeft = 0;
            this.btnRefresh.IconMarginRight = 0;
            this.btnRefresh.IconRightVisible = true;
            this.btnRefresh.IconRightZoom = 0D;
            this.btnRefresh.IconVisible = true;
            this.btnRefresh.IconZoom = 50D;
            this.btnRefresh.IsTab = false;
            this.btnRefresh.Location = new System.Drawing.Point(600, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(150, 43);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.BorderRadius = 0;
            this.btnXuat.ButtonText = "Xuất";
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnXuat, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnXuat, BunifuAnimatorNS.DecorationType.None);
            this.btnXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuat.Iconimage = global::GUI.Properties.Resources.undo_26px;
            this.btnXuat.Iconimage_right = null;
            this.btnXuat.Iconimage_right_Selected = null;
            this.btnXuat.Iconimage_Selected = null;
            this.btnXuat.IconMarginLeft = 0;
            this.btnXuat.IconMarginRight = 0;
            this.btnXuat.IconRightVisible = true;
            this.btnXuat.IconRightZoom = 0D;
            this.btnXuat.IconVisible = true;
            this.btnXuat.IconZoom = 50D;
            this.btnXuat.IsTab = false;
            this.btnXuat.Location = new System.Drawing.Point(450, 0);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuat.selected = false;
            this.btnXuat.Size = new System.Drawing.Size(150, 43);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuat.Textcolor = System.Drawing.Color.White;
            this.btnXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnSuaCongViec
            // 
            this.btnSuaCongViec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuaCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnSuaCongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaCongViec.BorderRadius = 0;
            this.btnSuaCongViec.ButtonText = "Sửa";
            this.btnSuaCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnSuaCongViec, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnSuaCongViec, BunifuAnimatorNS.DecorationType.None);
            this.btnSuaCongViec.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaCongViec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSuaCongViec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaCongViec.Iconimage = global::GUI.Properties.Resources.edit_24px;
            this.btnSuaCongViec.Iconimage_right = null;
            this.btnSuaCongViec.Iconimage_right_Selected = null;
            this.btnSuaCongViec.Iconimage_Selected = null;
            this.btnSuaCongViec.IconMarginLeft = 0;
            this.btnSuaCongViec.IconMarginRight = 0;
            this.btnSuaCongViec.IconRightVisible = true;
            this.btnSuaCongViec.IconRightZoom = 0D;
            this.btnSuaCongViec.IconVisible = true;
            this.btnSuaCongViec.IconZoom = 50D;
            this.btnSuaCongViec.IsTab = false;
            this.btnSuaCongViec.Location = new System.Drawing.Point(300, 0);
            this.btnSuaCongViec.Name = "btnSuaCongViec";
            this.btnSuaCongViec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnSuaCongViec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnSuaCongViec.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaCongViec.selected = false;
            this.btnSuaCongViec.Size = new System.Drawing.Size(150, 43);
            this.btnSuaCongViec.TabIndex = 2;
            this.btnSuaCongViec.Text = "Sửa";
            this.btnSuaCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaCongViec.Textcolor = System.Drawing.Color.White;
            this.btnSuaCongViec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCongViec.Click += new System.EventHandler(this.btnSuaCongViec_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnTimKiem, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnTimKiem, BunifuAnimatorNS.DecorationType.None);
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = global::GUI.Properties.Resources.search;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 50D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(150, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(150, 43);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatior.SetDecoration(this.btnThem, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnThem, BunifuAnimatorNS.DecorationType.None);
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = global::GUI.Properties.Resources.add;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 50D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(150, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // frm_quanLyCongViec
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
            this.Name = "frm_quanLyCongViec";
            this.Text = "frm_userMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_menu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_congViec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            this.panelQuanLy.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.DataGridView dgv_congViec;
        private Bunifu.Framework.UI.BunifuProgressBar pro_tienDoHoanThanh;
        private System.Windows.Forms.TextBox txt_trangThai;
        private System.Windows.Forms.DateTimePicker dtm_ngayKetThuc;
        private System.Windows.Forms.DateTimePicker dtm_ngayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tenCongViec;
        private System.Windows.Forms.Label lbl_tienDoHoanThanh;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaCongViec;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
    }
}