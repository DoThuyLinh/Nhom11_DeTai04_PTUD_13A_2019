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
    public partial class frm_suaCongViec : Form
    {
        eCongViec congViec;
        BUSCongViec busCongViec;
        public frm_suaCongViec()
        {
            InitializeComponent();
        }
        public frm_suaCongViec(string maCongViec, eDuAn duAn, string tenCongViec, DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai, int tienDoCongViec, string viTriCongViec)
        {
            InitializeComponent();

            congViec = new eCongViec();
            busCongViec = new BUSCongViec();

            congViec.MaCongViec = maCongViec;
            congViec.DuAn = duAn;
            congViec.TrangThai = trangThai;
            congViec.Tiendo = tienDoCongViec;
            congViec.NgayBatDau = ngayBatDau;
            congViec.NgayKetThuc = ngayKetThuc;
            congViec.TenCongViec = tenCongViec;
            congViec.ViTriCongViec = viTriCongViec;

            // Gan gia tri Trang Thai cho combobox
            cboTrangThai.DataSource = new string[] { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" };

            // Gan gia tri Vi Tri Cong Viec cho combobox
            cboViTriCongViec.DataSource = new string[] { "Quản Lý", "Khảo Sát", "Thiết Kế", "Giám Sát", "Thi Công" };

        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_suaCongViec_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            txtMaCongViec.Text = congViec.MaCongViec;
            txtMaCongViec.ReadOnly = true;
            txtTenCongViec.Text = congViec.TenCongViec;
            dtmNgayBatDau.Value = congViec.NgayBatDau;
            dtmNgayKetThuc.Value = congViec.NgayKetThuc;
            cboTrangThai.Text = congViec.TrangThai;
            nudTienDoCongViec.Value = congViec.Tiendo;
            cboViTriCongViec.Text = congViec.ViTriCongViec;
        }

        
        private void txtTenCongViec_Leave(object sender, EventArgs e)
        {
            if (!checkTenCongViec())
            {
                txtTenCongViec.Focus();

            }
            else
            {
                errorProvider1.SetError(txtTenCongViec, "");
            }
        }

        bool checkTenCongViec()
        {
            if (txtTenCongViec.Text.Trim().Equals(""))
            {

                errorProvider1.SetError(txtTenCongViec, "Khong de trong ten cong viec");
                return false;
            }

            return true;
        }

        private void dtmNgayBatDau_Leave(object sender, EventArgs e)
        {

        }

        private void dtmNgayKetThuc_Leave(object sender, EventArgs e)
        {
            if (!CheckNgayKetThuc())
            {
                dtmNgayKetThuc.Focus();

            }
            else
            {
                errorProvider1.SetError(dtmNgayKetThuc, "");
            }
        }
        bool CheckNgayKetThuc()
        {
            if (dtmNgayKetThuc.Value >= dtmNgayBatDau.Value)
            {

                return true;
            }
            else
            {
                errorProvider1.SetError(dtmNgayKetThuc, "ngay ket thuc >= ngay bat dau");
                return false;
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soLoi = 0;

            if (!checkTenCongViec())
                soLoi++;
            if (!CheckNgayKetThuc())
                soLoi++;

            if (soLoi > 0)
            {
                txtTenCongViec.Focus();
                MessageBox.Show("Thong Tin Nhap Khong Hop Le");
                return;
            }

            congViec.TenCongViec = txtTenCongViec.Text;
            congViec.NgayBatDau = dtmNgayBatDau.Value;
            congViec.NgayKetThuc = dtmNgayKetThuc.Value;
            congViec.TrangThai = cboTrangThai.Text;
            congViec.Tiendo = (int)nudTienDoCongViec.Value;
            congViec.ViTriCongViec = cboViTriCongViec.Text;

            busCongViec.UpdateItem(congViec);
            this.Close();
        }




    }
}
