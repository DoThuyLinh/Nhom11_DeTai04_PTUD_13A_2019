using Business;
using DataAccess;
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
    public partial class frm_timKiemDuAn : Form
    {
        BUSDuAn _duAn;
        public BindingSource bindingSource;
        public frm_timKiemDuAn()
        {
            _duAn = new BUSDuAn();
            bindingSource = new BindingSource();
            InitializeComponent();
        }
        public void searchDuAn(List<eDuAn> list)
        {
            frm_quanLyDuAn _QuanLyCongViec = new frm_quanLyDuAn(list);
            _QuanLyCongViec.ShowDialog();
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

        private void frm_timKiemDuAn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maDuAn = txtMaDuAn.Text.Trim();
            string tenDuAn = txtTenDuAn.Text;
            DateTime ngayBatDau = DateTime.Parse(dtmNgayBatDau.Value.ToString("yyyy/MM/dd"));
            DateTime ngayKetThuc = DateTime.Parse(dtmNgayKetThuc.Value.ToString("yyyy/MM/dd"));

            if (maDuAn != string.Empty && btnMaDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.maDuAn == maDuAn);
                if (listDuAn.Count >0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }
            else if (btnMaDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập mã dự án cần tìm.";
            }
            if (tenDuAn != string.Empty && btnTenDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.tenDuAn == tenDuAn);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }
            else if (btnTenDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập tên dự án cần tìm.";
            }
            if (cboTrangThai.SelectedItem != null && btnTrangThai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.trangThai == cboTrangThai.Text);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }
            else if (btnTrangThai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Chọn trạng thái dự án cần tìm.";
            }
            if (nudTienDoHoanThanh.Value >= 0 && btnTienDoHoanThanh.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.tienDoHoanThanh == nudTienDoHoanThanh.Value);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }

            if (ngayBatDau != null && btnNgayBatDau.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.ngayBatDau == ngayBatDau);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }

            if (ngayKetThuc != null  && btnNgayKetThuc.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.ngayKetThuc == ngayKetThuc);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }

            if (cboTrangThai.SelectedItem != null && nudTienDoHoanThanh.Value >= 0 && ngayBatDau != null && dtmNgayKetThuc != null && btnTimKiem.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => x.trangThai == cboTrangThai.Text && x.tienDoHoanThanh >= nudTienDoHoanThanh.Value && x.ngayBatDau >= ngayBatDau && x.ngayKetThuc <= ngayKetThuc);
                if (listDuAn.Count > 0)
                {
                    searchDuAn(listDuAn);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy dự án yêu cầu.";
                }
            }
        }

        private void btnMaDuAn_Click(object sender, EventArgs e)
        {
            txtMaDuAn.Enabled = true;
            txtTenDuAn.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoHoanThanh.Enabled = false;

            btnMaDuAn.Normalcolor = Color.FromArgb(39, 99, 109);
            btnMaDuAn.Textcolor = Color.White;

            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTenDuAn_Click(object sender, EventArgs e)
        {
            txtTenDuAn.Enabled = true;
            txtMaDuAn.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoHoanThanh.Enabled = false;
            btnTenDuAn.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTenDuAn.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayBatDau_Click(object sender, EventArgs e)
        {
            dtmNgayBatDau.Enabled = true;
            txtTenDuAn.Enabled = false;
            txtMaDuAn.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoHoanThanh.Enabled = false;

            btnNgayBatDau.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayBatDau.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayKetThuc_Click(object sender, EventArgs e)
        {
            dtmNgayKetThuc.Enabled = true;
            dtmNgayBatDau.Enabled = false;
            txtTenDuAn.Enabled = false;
            txtMaDuAn.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoHoanThanh.Enabled = false;

            btnNgayKetThuc.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayKetThuc.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            cboTrangThai.Enabled = true;
            dtmNgayBatDau.Enabled = false;
            txtTenDuAn.Enabled = false;
            txtMaDuAn.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            nudTienDoHoanThanh.Enabled = false;

            btnTrangThai.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTrangThai.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTienDoHoanThanh_Click(object sender, EventArgs e)
        {
            nudTienDoHoanThanh.Enabled = true;
            cboTrangThai.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            txtTenDuAn.Enabled = false;
            txtMaDuAn.Enabled = false;
            dtmNgayKetThuc.Enabled = false;

            btnTienDoHoanThanh.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTienDoHoanThanh.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nudTienDoHoanThanh.Enabled = true;
            cboTrangThai.Enabled = true;
            dtmNgayBatDau.Enabled = true;
            txtMaDuAn.Enabled = false;
            txtTenDuAn.Enabled = false;
            dtmNgayKetThuc.Enabled = true;

            btnTimKiem.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTimKiem.Textcolor = Color.White;

            btnMaDuAn.Normalcolor = Color.White;
            btnMaDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenDuAn.Normalcolor = Color.White;
            btnTenDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoHoanThanh.Normalcolor = Color.White;
            btnTienDoHoanThanh.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
