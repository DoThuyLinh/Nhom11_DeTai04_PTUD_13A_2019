namespace GUI
{
    partial class frm_phanCongCongViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXuatFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoaPhanCong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhanCong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_phanCong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clb_nhanVien = new System.Windows.Forms.CheckedListBox();
            this.cbo_congViec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanCong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 726);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXuatFile);
            this.panel5.Controls.Add(this.btnXoaPhanCong);
            this.panel5.Controls.Add(this.btnPhanCong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1307, 42);
            this.panel5.TabIndex = 36;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatFile.BorderRadius = 0;
            this.btnXuatFile.ButtonText = "Xuất file";
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXuatFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuatFile.Iconimage = null;
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
            this.btnXuatFile.Location = new System.Drawing.Point(245, 0);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXuatFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnXuatFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuatFile.selected = false;
            this.btnXuatFile.Size = new System.Drawing.Size(115, 42);
            this.btnXuatFile.TabIndex = 28;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatFile.Textcolor = System.Drawing.Color.White;
            this.btnXuatFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnXoaPhanCong
            // 
            this.btnXoaPhanCong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoaPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXoaPhanCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaPhanCong.BorderRadius = 0;
            this.btnXoaPhanCong.ButtonText = "Xoá phân công";
            this.btnXoaPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhanCong.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoaPhanCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoaPhanCong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoaPhanCong.Iconimage = null;
            this.btnXoaPhanCong.Iconimage_right = null;
            this.btnXoaPhanCong.Iconimage_right_Selected = null;
            this.btnXoaPhanCong.Iconimage_Selected = null;
            this.btnXoaPhanCong.IconMarginLeft = 0;
            this.btnXoaPhanCong.IconMarginRight = 0;
            this.btnXoaPhanCong.IconRightVisible = true;
            this.btnXoaPhanCong.IconRightZoom = 0D;
            this.btnXoaPhanCong.IconVisible = true;
            this.btnXoaPhanCong.IconZoom = 50D;
            this.btnXoaPhanCong.IsTab = false;
            this.btnXoaPhanCong.Location = new System.Drawing.Point(115, 0);
            this.btnXoaPhanCong.Name = "btnXoaPhanCong";
            this.btnXoaPhanCong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnXoaPhanCong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnXoaPhanCong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoaPhanCong.selected = false;
            this.btnXoaPhanCong.Size = new System.Drawing.Size(130, 42);
            this.btnXoaPhanCong.TabIndex = 34;
            this.btnXoaPhanCong.Text = "Xoá phân công";
            this.btnXoaPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaPhanCong.Textcolor = System.Drawing.Color.White;
            this.btnXoaPhanCong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanCong.Click += new System.EventHandler(this.btnXoaPhanCong_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnPhanCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanCong.BorderRadius = 0;
            this.btnPhanCong.ButtonText = "Phân công";
            this.btnPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhanCong.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhanCong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhanCong.Iconimage = null;
            this.btnPhanCong.Iconimage_right = null;
            this.btnPhanCong.Iconimage_right_Selected = null;
            this.btnPhanCong.Iconimage_Selected = null;
            this.btnPhanCong.IconMarginLeft = 0;
            this.btnPhanCong.IconMarginRight = 0;
            this.btnPhanCong.IconRightVisible = true;
            this.btnPhanCong.IconRightZoom = 0D;
            this.btnPhanCong.IconVisible = true;
            this.btnPhanCong.IconZoom = 50D;
            this.btnPhanCong.IsTab = false;
            this.btnPhanCong.Location = new System.Drawing.Point(0, 0);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.btnPhanCong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.btnPhanCong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhanCong.selected = false;
            this.btnPhanCong.Size = new System.Drawing.Size(115, 42);
            this.btnPhanCong.TabIndex = 28;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhanCong.Textcolor = System.Drawing.Color.White;
            this.btnPhanCong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgv_phanCong);
            this.panel4.Location = new System.Drawing.Point(520, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 563);
            this.panel4.TabIndex = 33;
            // 
            // dgv_phanCong
            // 
            this.dgv_phanCong.AllowUserToAddRows = false;
            this.dgv_phanCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_phanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_phanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_phanCong.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_phanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phanCong.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_phanCong.EnableHeadersVisualStyles = false;
            this.dgv_phanCong.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_phanCong.Location = new System.Drawing.Point(19, 88);
            this.dgv_phanCong.Name = "dgv_phanCong";
            this.dgv_phanCong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phanCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_phanCong.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_phanCong.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_phanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phanCong.Size = new System.Drawing.Size(721, 460);
            this.dgv_phanCong.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.clb_nhanVien);
            this.panel3.Controls.Add(this.cbo_congViec);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(25, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 563);
            this.panel3.TabIndex = 32;
            // 
            // clb_nhanVien
            // 
            this.clb_nhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_nhanVien.FormattingEnabled = true;
            this.clb_nhanVien.Location = new System.Drawing.Point(19, 88);
            this.clb_nhanVien.Name = "clb_nhanVien";
            this.clb_nhanVien.Size = new System.Drawing.Size(451, 460);
            this.clb_nhanVien.TabIndex = 32;
            // 
            // cbo_congViec
            // 
            this.cbo_congViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_congViec.FormattingEnabled = true;
            this.cbo_congViec.Location = new System.Drawing.Point(122, 14);
            this.cbo_congViec.Name = "cbo_congViec";
            this.cbo_congViec.Size = new System.Drawing.Size(348, 26);
            this.cbo_congViec.TabIndex = 31;
            this.cbo_congViec.SelectedIndexChanged += new System.EventHandler(this.cbo_congViec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chọn công việc";
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(588, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân công công việc";
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // frm_phanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 726);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_phanCongCongViec";
            this.Text = "frm_phanCongCongViec";
            this.Load += new System.EventHandler(this.frm_phanCongCongViec_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanCong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_congViec;
        private System.Windows.Forms.DataGridView dgv_phanCong;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhanCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckedListBox clb_nhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuatFile;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoaPhanCong;
        private System.Windows.Forms.Panel panel5;
    }
}