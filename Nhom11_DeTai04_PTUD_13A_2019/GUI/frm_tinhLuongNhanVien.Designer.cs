namespace GUI
{
    partial class frm_tinhLuongNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChonFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChonNhanVien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboNhanVien);
            this.panel1.Controls.Add(this.dgvBangLuong);
            this.panel1.Controls.Add(this.btnXuatFile);
            this.panel1.Controls.Add(this.btnChonFile);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblChonNhanVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 726);
            this.panel1.TabIndex = 5;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(699, 111);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(373, 26);
            this.cboNhanVien.TabIndex = 31;
           
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvBangLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangLuong.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBangLuong.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBangLuong.Location = new System.Drawing.Point(24, 165);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBangLuong.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvBangLuong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1273, 547);
            this.dgvBangLuong.TabIndex = 30;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatFile.BorderRadius = 0;
            this.btnXuatFile.ButtonText = "Xuất file";
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuatFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuatFile.Iconimage = global::GUI.Properties.Resources.undo_26px;
            this.btnXuatFile.Iconimage_right = null;
            this.btnXuatFile.Iconimage_right_Selected = null;
            this.btnXuatFile.Iconimage_Selected = null;
            this.btnXuatFile.IconMarginLeft = 0;
            this.btnXuatFile.IconMarginRight = 0;
            this.btnXuatFile.IconRightVisible = true;
            this.btnXuatFile.IconRightZoom = 0D;
            this.btnXuatFile.IconVisible = true;
            this.btnXuatFile.IconZoom = 50D;
            this.btnXuatFile.IsTab = false;
            this.btnXuatFile.Location = new System.Drawing.Point(3, 48);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuatFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnXuatFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuatFile.selected = false;
            this.btnXuatFile.Size = new System.Drawing.Size(123, 42);
            this.btnXuatFile.TabIndex = 27;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatFile.Textcolor = System.Drawing.Color.White;
            this.btnXuatFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChonFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonFile.BorderRadius = 0;
            this.btnChonFile.ButtonText = "Chọn file";
            this.btnChonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnChonFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChonFile.Iconimage = null;
            this.btnChonFile.Iconimage_right = null;
            this.btnChonFile.Iconimage_right_Selected = null;
            this.btnChonFile.Iconimage_Selected = null;
            this.btnChonFile.IconMarginLeft = 0;
            this.btnChonFile.IconMarginRight = 0;
            this.btnChonFile.IconRightVisible = true;
            this.btnChonFile.IconRightZoom = 0D;
            this.btnChonFile.IconVisible = true;
            this.btnChonFile.IconZoom = 50D;
            this.btnChonFile.IsTab = false;
            this.btnChonFile.Location = new System.Drawing.Point(191, 107);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnChonFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnChonFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChonFile.selected = false;
            this.btnChonFile.Size = new System.Drawing.Size(90, 30);
            this.btnChonFile.TabIndex = 28;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChonFile.Textcolor = System.Drawing.Color.White;
            this.btnChonFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(30, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chọn file chấm công";
            // 
            // lblChonNhanVien
            // 
            this.lblChonNhanVien.AutoSize = true;
            this.lblChonNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.lblChonNhanVien.Location = new System.Drawing.Point(497, 114);
            this.lblChonNhanVien.Name = "lblChonNhanVien";
            this.lblChonNhanVien.Size = new System.Drawing.Size(181, 18);
            this.lblChonNhanVien.TabIndex = 19;
            this.lblChonNhanVien.Text = "Xem bảng lương nhân viên";
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
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính lương nhân viên";
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Image = global::GUI.Properties.Resources.multiply_2_26px;
            this.pic_close.Location = new System.Drawing.Point(1278, 3);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(26, 26);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // frm_tinhLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 726);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_tinhLuongNhanVien";
            this.Text = "frm_tinhLuongNhanVien";
            this.Load += new System.EventHandler(this.frm_tinhLuongNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblChonNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnChonFile;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuatFile;
    }
}