namespace GUI
{
    partial class frm_quanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_quanLyNhanVien));
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChamCong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTinhLuong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_nhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nguoiDaiDien = new System.Windows.Forms.Label();
            this.lbl_tenPhongBan = new System.Windows.Forms.Label();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_namSinh = new System.Windows.Forms.DateTimePicker();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.txt_soDienThoai = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tenNhanVien = new System.Windows.Forms.Label();
            this.pic_nhanVien = new System.Windows.Forms.PictureBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelAnimatior = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).BeginInit();
            this.slidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panelQuanLy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnRefresh, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnRefresh, BunifuAnimatorNS.DecorationType.None);
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
            this.btnRefresh.Location = new System.Drawing.Point(900, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(150, 42);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChamCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChamCong.BorderRadius = 0;
            this.btnChamCong.ButtonText = "Phân công";
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnChamCong, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnChamCong, BunifuAnimatorNS.DecorationType.None);
            this.btnChamCong.DisabledColor = System.Drawing.Color.Gray;
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChamCong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChamCong.Iconimage = global::GUI.Properties.Resources.assignment_turned_in_24px;
            this.btnChamCong.Iconimage_right = null;
            this.btnChamCong.Iconimage_right_Selected = null;
            this.btnChamCong.Iconimage_Selected = null;
            this.btnChamCong.IconMarginLeft = 0;
            this.btnChamCong.IconMarginRight = 0;
            this.btnChamCong.IconRightVisible = true;
            this.btnChamCong.IconRightZoom = 0D;
            this.btnChamCong.IconVisible = true;
            this.btnChamCong.IconZoom = 60D;
            this.btnChamCong.IsTab = false;
            this.btnChamCong.Location = new System.Drawing.Point(750, 0);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChamCong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnChamCong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChamCong.selected = false;
            this.btnChamCong.Size = new System.Drawing.Size(150, 42);
            this.btnChamCong.TabIndex = 8;
            this.btnChamCong.Text = "Phân công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChamCong.Textcolor = System.Drawing.Color.White;
            this.btnChamCong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTinhLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhLuong.BorderRadius = 0;
            this.btnTinhLuong.ButtonText = "Tính lương";
            this.btnTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnTinhLuong, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnTinhLuong, BunifuAnimatorNS.DecorationType.None);
            this.btnTinhLuong.DisabledColor = System.Drawing.Color.Gray;
            this.btnTinhLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTinhLuong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTinhLuong.Iconimage = global::GUI.Properties.Resources.property_time_filled_50px;
            this.btnTinhLuong.Iconimage_right = null;
            this.btnTinhLuong.Iconimage_right_Selected = null;
            this.btnTinhLuong.Iconimage_Selected = null;
            this.btnTinhLuong.IconMarginLeft = 0;
            this.btnTinhLuong.IconMarginRight = 0;
            this.btnTinhLuong.IconRightVisible = true;
            this.btnTinhLuong.IconRightZoom = 0D;
            this.btnTinhLuong.IconVisible = true;
            this.btnTinhLuong.IconZoom = 50D;
            this.btnTinhLuong.IsTab = false;
            this.btnTinhLuong.Location = new System.Drawing.Point(600, 0);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTinhLuong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnTinhLuong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTinhLuong.selected = false;
            this.btnTinhLuong.Size = new System.Drawing.Size(150, 42);
            this.btnTinhLuong.TabIndex = 8;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTinhLuong.Textcolor = System.Drawing.Color.White;
            this.btnTinhLuong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnSua, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnSua, BunifuAnimatorNS.DecorationType.None);
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::GUI.Properties.Resources.edit_24px;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 50D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(300, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(150, 42);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnThem, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnThem, BunifuAnimatorNS.DecorationType.None);
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
            this.btnThem.Location = new System.Drawing.Point(150, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(150, 42);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnTimKiem, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnTimKiem, BunifuAnimatorNS.DecorationType.None);
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
            this.btnTimKiem.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(150, 42);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.BorderRadius = 0;
            this.btnXuat.ButtonText = "Xuất";
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnXuat, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnXuat, BunifuAnimatorNS.DecorationType.None);
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
            this.btnXuat.Size = new System.Drawing.Size(150, 42);
            this.btnXuat.TabIndex = 4;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuat.Textcolor = System.Drawing.Color.White;
            this.btnXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgv_nhanVien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbl_nguoiDaiDien);
            this.panel4.Controls.Add(this.lbl_tenPhongBan);
            this.panel4.Controls.Add(this.bunifuFlatButton8);
            this.LogoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(16, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 343);
            this.panel4.TabIndex = 4;
            // 
            // dgv_nhanVien
            // 
            this.dgv_nhanVien.AllowUserToAddRows = false;
            this.dgv_nhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_nhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_nhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_nhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogoAnimator.SetDecoration(this.dgv_nhanVien, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dgv_nhanVien, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhanVien.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_nhanVien.EnableHeadersVisualStyles = false;
            this.dgv_nhanVien.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_nhanVien.Location = new System.Drawing.Point(16, 66);
            this.dgv_nhanVien.Name = "dgv_nhanVien";
            this.dgv_nhanVien.ReadOnly = true;
            this.dgv_nhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_nhanVien.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_nhanVien.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_nhanVien.RowTemplate.Height = 27;
            this.dgv_nhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhanVien.Size = new System.Drawing.Size(1248, 260);
            this.dgv_nhanVien.TabIndex = 4;
            this.dgv_nhanVien.SelectionChanged += new System.EventHandler(this.dgv_nhanVien_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // lbl_nguoiDaiDien
            // 
            this.lbl_nguoiDaiDien.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.lbl_nguoiDaiDien, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lbl_nguoiDaiDien, BunifuAnimatorNS.DecorationType.None);
            this.lbl_nguoiDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguoiDaiDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lbl_nguoiDaiDien.Location = new System.Drawing.Point(125, 36);
            this.lbl_nguoiDaiDien.Name = "lbl_nguoiDaiDien";
            this.lbl_nguoiDaiDien.Size = new System.Drawing.Size(101, 18);
            this.lbl_nguoiDaiDien.TabIndex = 2;
            this.lbl_nguoiDaiDien.Text = "Người đại diện";
            this.lbl_nguoiDaiDien.Visible = false;
            // 
            // lbl_tenPhongBan
            // 
            this.lbl_tenPhongBan.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.lbl_tenPhongBan, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lbl_tenPhongBan, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lbl_tenPhongBan.Location = new System.Drawing.Point(118, 3);
            this.lbl_tenPhongBan.Name = "lbl_tenPhongBan";
            this.lbl_tenPhongBan.Size = new System.Drawing.Size(119, 24);
            this.lbl_tenPhongBan.TabIndex = 1;
            this.lbl_tenPhongBan.Text = "Phòng dự án";
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Chi tiết";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(85, 41);
            this.bunifuFlatButton8.TabIndex = 0;
            this.bunifuFlatButton8.Text = "Chi tiết";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtm_namSinh);
            this.panel1.Controls.Add(this.txt_gioiTinh);
            this.panel1.Controls.Add(this.txt_soDienThoai);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_tenNhanVien);
            this.panel1.Controls.Add(this.pic_nhanVien);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(16, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 251);
            this.panel1.TabIndex = 5;
            // 
            // dtm_namSinh
            // 
            this.PanelAnimatior.SetDecoration(this.dtm_namSinh, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dtm_namSinh, BunifuAnimatorNS.DecorationType.None);
            this.dtm_namSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_namSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_namSinh.Location = new System.Drawing.Point(419, 110);
            this.dtm_namSinh.Name = "dtm_namSinh";
            this.dtm_namSinh.Size = new System.Drawing.Size(234, 24);
            this.dtm_namSinh.TabIndex = 5;
            // 
            // txt_gioiTinh
            // 
            this.PanelAnimatior.SetDecoration(this.txt_gioiTinh, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.txt_gioiTinh, BunifuAnimatorNS.DecorationType.None);
            this.txt_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioiTinh.Location = new System.Drawing.Point(419, 151);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.ReadOnly = true;
            this.txt_gioiTinh.Size = new System.Drawing.Size(234, 24);
            this.txt_gioiTinh.TabIndex = 4;
            // 
            // txt_soDienThoai
            // 
            this.PanelAnimatior.SetDecoration(this.txt_soDienThoai, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.txt_soDienThoai, BunifuAnimatorNS.DecorationType.None);
            this.txt_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDienThoai.Location = new System.Drawing.Point(858, 112);
            this.txt_soDienThoai.Name = "txt_soDienThoai";
            this.txt_soDienThoai.ReadOnly = true;
            this.txt_soDienThoai.Size = new System.Drawing.Size(263, 24);
            this.txt_soDienThoai.TabIndex = 4;
            // 
            // txt_email
            // 
            this.PanelAnimatior.SetDecoration(this.txt_email, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.txt_email, BunifuAnimatorNS.DecorationType.None);
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(858, 155);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(263, 24);
            this.txt_email.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label10.Location = new System.Drawing.Point(779, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(730, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(323, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(312, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // lbl_tenNhanVien
            // 
            this.lbl_tenNhanVien.AutoSize = true;
            this.PanelAnimatior.SetDecoration(this.lbl_tenNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lbl_tenNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lbl_tenNhanVien.Location = new System.Drawing.Point(284, 50);
            this.lbl_tenNhanVien.Name = "lbl_tenNhanVien";
            this.lbl_tenNhanVien.Size = new System.Drawing.Size(132, 24);
            this.lbl_tenNhanVien.TabIndex = 2;
            this.lbl_tenNhanVien.Text = "Tên nhân viên";
            // 
            // pic_nhanVien
            // 
            this.pic_nhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelAnimatior.SetDecoration(this.pic_nhanVien, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pic_nhanVien, BunifuAnimatorNS.DecorationType.None);
            this.pic_nhanVien.Location = new System.Drawing.Point(56, 24);
            this.pic_nhanVien.Name = "pic_nhanVien";
            this.pic_nhanVien.Size = new System.Drawing.Size(170, 222);
            this.pic_nhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nhanVien.TabIndex = 0;
            this.pic_nhanVien.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.cirPicUser);
            this.panel2.Controls.Add(this.dtmToday);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 42);
            this.panel2.TabIndex = 6;
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Help";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
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
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Textcolor = System.Drawing.Color.Black;
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cirPicUser
            // 
            this.cirPicUser.BackColor = System.Drawing.Color.White;
            this.PanelAnimatior.SetDecoration(this.cirPicUser, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.cirPicUser, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.dtmToday, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.dtmToday, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.slidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidemenu.Location = new System.Drawing.Point(0, 42);
            this.slidemenu.Name = "slidemenu";
            this.slidemenu.Size = new System.Drawing.Size(55, 684);
            this.slidemenu.TabIndex = 7;
            this.slidemenu.MouseHover += new System.EventHandler(this.slidemenu_MouseHover);
            // 
            // logo
            // 
            this.PanelAnimatior.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.btnQuanLyHopDong, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnQuanLyHopDong, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.btnQuanLyCongViec, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnQuanLyCongViec, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.btnQuanLyDuAn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.btnQuanLyDuAn, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimator.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
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
            this.panelQuanLy.Controls.Add(this.panel3);
            this.panelQuanLy.Controls.Add(this.panel1);
            this.panelQuanLy.Controls.Add(this.panel4);
            this.LogoAnimator.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.panelQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Location = new System.Drawing.Point(55, 42);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(1311, 684);
            this.panelQuanLy.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnChamCong);
            this.panel3.Controls.Add(this.btnTinhLuong);
            this.panel3.Controls.Add(this.btnXuat);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatior.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 42);
            this.panel3.TabIndex = 11;
            // 
            // PanelAnimatior
            // 
            this.PanelAnimatior.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimatior.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.PanelAnimatior.DefaultAnimation = animation4;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // frm_quanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 726);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.panel2);
            this.PanelAnimatior.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_quanLyNhanVien";
            this.Text = "frm_quanLyNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_quanLyNhanVien_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cirPicUser)).EndInit();
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panelQuanLy.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnChamCong;
        private Bunifu.Framework.UI.BunifuFlatButton btnTinhLuong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_nhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nguoiDaiDien;
        private System.Windows.Forms.Label lbl_tenPhongBan;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtm_namSinh;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.TextBox txt_soDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tenNhanVien;
        private System.Windows.Forms.PictureBox pic_nhanVien;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
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
        private BunifuAnimatorNS.BunifuTransition PanelAnimatior;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private System.Windows.Forms.Timer timerClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
    }
}