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
    public partial class frm_timKiemCongViec : Form
    {
        BUSCongViec _congViec;
        BUSDuAn _duAn;
        public frm_timKiemCongViec()
        {
            InitializeComponent();
            _congViec = new BUSCongViec();
            _duAn = new BUSDuAn();
        }
        public void setTooltip(Control control)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(control, "Vui lòng điền vào trường này");
        }
        public void searchCongViec(List<eCongViec> eCongViecs)
        {
            frm_quanLyCongViec _QuanLyCongViec = new frm_quanLyCongViec(eCongViecs);
            _QuanLyCongViec.ShowDialog();
            timerClose.Start();
        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_timKiemCongViec_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            List<eDuAn> listDuAn = _duAn.GetAllList();
            foreach (var item in listDuAn)
            {
                cboDuAn.Items.Add(item.MaDuAn + " - " + item.TenDuAn);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maCongViec = txtMaCongViec.Text.Trim();
            string[] arrDuAn = cboDuAn.Text.Split('-');
            string tenCongViec = txtTenCongViec.Text;
            DateTime ngayBatDau = DateTime.Parse(dtmNgayBatDau.Value.ToString("yyyy/MM/dd"));
            DateTime ngayKetThuc = DateTime.Parse(dtmNgayKetThuc.Value.ToString("yyyy/MM/dd"));
            
            if (maCongViec !=string.Empty && btnMaCongViec.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.MaCongViec == maCongViec).ToList();
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }
            else if(btnMaCongViec.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập mã công việc cần tìm.";
            }
            if (tenCongViec != string.Empty && btnTenCongViec.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.TenCongViec == tenCongViec);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }
            else if (btnTenCongViec.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập tên công việc cần tìm.";
            }
            if (cboTrangThai.SelectedItem != null  && btnTrangThai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.TrangThai == cboTrangThai.Text);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }
            else if (btnTrangThai.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Chọn trạng thái công việc cần tìm.";
            }

            if (nudTienDoCongViec.Value >= 0 && nudTienDoCongViec.Value <= 100 && btnTienDoCongViec.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List <eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.Tiendo == nudTienDoCongViec.Value);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }
            if (ngayBatDau != null && btnNgayBatDau.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.NgayBatDau == ngayBatDau);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }

            if (ngayKetThuc != null && btnNgayKetThuc.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.NgayKetThuc == ngayKetThuc);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }

            if (cboDuAn.SelectedItem != null && btnDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.DuAn.MaDuAn == arrDuAn[0].Trim());
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }
            else if (btnDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Chọn dự án của công việc cần tìm.";
            }

            if (cboDuAn.SelectedItem != null && cboTrangThai.SelectedItem != null && nudTienDoCongViec.Value >= 0 && ngayBatDau != null && dtmNgayKetThuc != null && btnTimKiem.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.DuAn.MaDuAn == arrDuAn[0].Trim() && x.TrangThai == cboTrangThai.Text && x.Tiendo >= nudTienDoCongViec.Value && x.NgayBatDau >= ngayBatDau && x.NgayKetThuc <= ngayKetThuc);
                if (listCongViec.Count > 0)
                {
                    searchCongViec(listCongViec);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy công việc yêu cầu.";
                }
            }

        }

        private void btnMaCongViec_Click(object sender, EventArgs e)
        {
            txtMaCongViec.Enabled = true;
            txtTenCongViec.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoCongViec.Enabled = false;
            cboDuAn.Enabled = false;

            btnMaCongViec.Normalcolor = Color.FromArgb(39, 99, 109);
            btnMaCongViec.Textcolor = Color.White;

            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);

        }

        private void btnTenCongViec_Click(object sender, EventArgs e)
        {
            txtTenCongViec.Enabled = true;
            txtMaCongViec.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoCongViec.Enabled = false;
            cboDuAn.Enabled = false;

            btnTenCongViec.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTenCongViec.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayBatDau_Click(object sender, EventArgs e)
        {
            dtmNgayBatDau.Enabled = true;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoCongViec.Enabled = false;
            cboDuAn.Enabled = false;

            btnNgayBatDau.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayBatDau.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayKetThuc_Click(object sender, EventArgs e)
        {
            dtmNgayKetThuc.Enabled = true;
            dtmNgayBatDau.Enabled = false;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            cboTrangThai.Enabled = false;
            nudTienDoCongViec.Enabled = false;
            cboDuAn.Enabled = false;

            btnNgayKetThuc.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayKetThuc.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            cboTrangThai.Enabled = true;
            dtmNgayBatDau.Enabled = false;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            nudTienDoCongViec.Enabled = false;
            cboDuAn.Enabled = false;

            btnTrangThai.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTrangThai.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTienDoCongViec_Click(object sender, EventArgs e)
        {
            nudTienDoCongViec.Enabled = true;
            cboTrangThai.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            dtmNgayKetThuc.Enabled = false;
            cboDuAn.Enabled = false;

            btnTienDoCongViec.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTienDoCongViec.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nudTienDoCongViec.Enabled = true;
            cboTrangThai.Enabled = true;
            dtmNgayBatDau.Enabled = true;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            dtmNgayKetThuc.Enabled = true;
            cboDuAn.Enabled = true;

            btnTimKiem.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTimKiem.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            cboDuAn.Enabled = true;
            nudTienDoCongViec.Enabled = false;
            cboTrangThai.Enabled = false;
            dtmNgayBatDau.Enabled = false;
            txtTenCongViec.Enabled = false;
            txtMaCongViec.Enabled = false;
            dtmNgayKetThuc.Enabled = false;

            btnDuAn.Normalcolor = Color.FromArgb(39, 99, 109);
            btnDuAn.Textcolor = Color.White;

            btnMaCongViec.Normalcolor = Color.White;
            btnMaCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenCongViec.Normalcolor = Color.White;
            btnTenCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKetThuc.Normalcolor = Color.White;
            btnNgayKetThuc.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayBatDau.Normalcolor = Color.White;
            btnNgayBatDau.Textcolor = Color.FromArgb(68, 71, 72);
            btnTrangThai.Normalcolor = Color.White;
            btnTrangThai.Textcolor = Color.FromArgb(68, 71, 72);
            btnTienDoCongViec.Normalcolor = Color.White;
            btnTienDoCongViec.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
