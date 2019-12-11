using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_timKiemNhanVien : Form
    {
        BUSNhanVien _nhanVien;
        BUSDiaChi _diaChi;
        public frm_timKiemNhanVien()
        {
            InitializeComponent();
            _diaChi = new BUSDiaChi();
            _nhanVien = new BUSNhanVien();
        }
        public void searchNhanVien(List<eNhanVien> list)
        {
            frm_quanLyNhanVien _quanLyNhanVien = new frm_quanLyNhanVien(list);
            _quanLyNhanVien.ShowDialog();
            timerClose.Start();
        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_timKiemNhanVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            List<eThanhPho> eThanhPho = _diaChi.getAllThanhPho();
            cboDiaChi.DisplayMember = "thanhPho";
            cboDiaChi.ValueMember = "maThanhPho";
            cboDiaChi.DataSource = eThanhPho;
            cboDiaChi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboDiaChi.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnMaNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = false;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = false;
            txtEmail.Enabled = false;

            btnMaNhanVien.Normalcolor = Color.FromArgb(39, 99, 109);
            btnMaNhanVien.Textcolor = Color.White;

            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
            
        }

        private void btnTenNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = true;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = false;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = false;
            txtEmail.Enabled = false;

            btnTenNhanVien.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTenNhanVien.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayVaoLam_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = true;
            txtSoDienThoai.Enabled = false;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = false;
            txtEmail.Enabled = false;

            btnNgayVaoLam.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayVaoLam.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnSoDienThoai_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = true;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = false;
            txtEmail.Enabled = false;

            btnSoDienThoai.Normalcolor = Color.FromArgb(39, 99, 109);
            btnSoDienThoai.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = true;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = false;

            btnEmail.Normalcolor = Color.FromArgb(39, 99, 109);
            btnEmail.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnGioiTinh_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            cboGioiTinh.Enabled = true;
            cboDiaChi.Enabled = false;

            btnGioiTinh.Normalcolor = Color.FromArgb(39, 99, 109);
            btnGioiTinh.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnDiaChi.Normalcolor = Color.White;
            btnDiaChi.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnDiaChi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayVaoLam.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            cboGioiTinh.Enabled = false;
            cboDiaChi.Enabled = true;

            btnDiaChi.Normalcolor = Color.FromArgb(39, 99, 109);
            btnDiaChi.Textcolor = Color.White;

            btnMaNhanVien.Normalcolor = Color.White;
            btnMaNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenNhanVien.Normalcolor = Color.White;
            btnTenNhanVien.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayVaoLam.Normalcolor = Color.White;
            btnNgayVaoLam.Textcolor = Color.FromArgb(68, 71, 72);
            btnSoDienThoai.Normalcolor = Color.White;
            btnSoDienThoai.Textcolor = Color.FromArgb(68, 71, 72);
            btnEmail.Normalcolor = Color.White;
            btnEmail.Textcolor = Color.FromArgb(68, 71, 72);
            btnGioiTinh.Normalcolor = Color.White;
            btnGioiTinh.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string tenNhanVien = txtTenNhanVien.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            DateTime ngayVaoLam = DateTime.Parse(dtmNgayVaoLam.Value.ToString("yyyy/MM/dd"));

            if (maNhanVien != string.Empty && btnMaNhanVien.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.maNhanVien == maNhanVien);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnMaNhanVien.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập mã nhân viên cần tìm.";
            }

            if (tenNhanVien != string.Empty && btnTenNhanVien.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.hoTen == tenNhanVien);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnTenNhanVien.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập tên nhân viên cần tìm.";
            }

            if (ngayVaoLam != null && btnNgayVaoLam.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.ngayVaolam == ngayVaoLam);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }

            if (soDienThoai != string.Empty && btnSoDienThoai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.dienThoai == soDienThoai);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnSoDienThoai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập số điện thoại cần tìm.";
            }

            if (cboDiaChi.SelectedItem != null && btnDiaChi.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.DiaChi.thanhPho == cboDiaChi.Text);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnDiaChi.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Chọn thành phố cần tìm.";
            }

            if (cboGioiTinh.SelectedItem != null && btnGioiTinh.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.gioiTinh == cboGioiTinh.Text);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnGioiTinh.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Chọn giới tính cần tìm.";
            }

            if (email != string.Empty && btnEmail.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eNhanVien> listNhanVien = _nhanVien.GetManyItemByCondition(x => x.email == email);
                if (listNhanVien.Count > 0)
                {
                    searchNhanVien(listNhanVien);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy nhân viên yêu cầu.";
                }
            }
            else if (btnEmail.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập email cần tìm.";
            }
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
