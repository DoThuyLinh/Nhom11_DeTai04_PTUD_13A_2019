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
    public partial class frm_suaHopDong : Form
    {
        eHopDong eHopDong;
        BUSHopDong busHopDong;
        BUSDuAn busDuAn;
        public frm_suaHopDong()
        {
            InitializeComponent();
            busHopDong = new BUSHopDong();
            eHopDong = new eHopDong();
            busDuAn = new BUSDuAn();
        }
        public frm_suaHopDong(string maHopDong, eDuAn duAn, string tenHopDong, DateTime ngayKyKet, DateTime ngayHetHan, double giaTriHopDong, string thongTin)
        {
            InitializeComponent();

            eHopDong = new eHopDong();
            busHopDong = new BUSHopDong();

            eHopDong.maHopDong = maHopDong;
            eHopDong.duAn = duAn;
            eHopDong.tenHopDong = tenHopDong;
            eHopDong.ngayKyKet = ngayKyKet;
            eHopDong.ngayHetHan = ngayHetHan;
            eHopDong.giaTriHopDong = giaTriHopDong;
            eHopDong.thongTin = thongTin;

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_suaHopDong_Load(object sender, EventArgs e)
        {
            nudGiaTriHopDong.Maximum = Decimal.MaxValue;
            this.Location = new Point(55, 42);

            txtMaHopDong.Text = eHopDong.maHopDong;
            txtTenHopDong.Text = eHopDong.tenHopDong;
            dtmNgayKyKet.Value = eHopDong.ngayKyKet;
            dtmNgayHetHan.Value = eHopDong.ngayHetHan;
            nudGiaTriHopDong.Value = (decimal)eHopDong.giaTriHopDong;
        }

        


        private void txtTenHopDong_Leave(object sender, EventArgs e)
        {
            if (!ChecktenHopDong())
            {
                txtTenHopDong.Focus();

            }
            else
            {
                errorProvider1.SetError(txtTenHopDong, "");
            }
        }

        bool ChecktenHopDong()
        {
            if (txtTenHopDong.Text.Trim().Equals(""))
            {

                errorProvider1.SetError(txtTenHopDong, "Khong de trong ten hop dong");
                return false;
            }
            return true;

        }

        private void dtmNgayKyKet_Leave(object sender, EventArgs e)
        {


            if (!CheckNgayKyKet())
            {
                dtmNgayKyKet.Focus();

            }
            else
            {
                errorProvider1.SetError(dtmNgayKyKet, "");
            }
        }

        bool CheckNgayKyKet()
        {
            
            
            if (dtmNgayKyKet.Value < eHopDong.duAn.NgayBatDau || dtmNgayKyKet.Value > eHopDong.duAn.NgayKetThuc || dtmNgayKyKet.Value > DateTime.Now)
            {

                errorProvider1.SetError(dtmNgayKyKet, "ngay Ky Ket Trong Khoang Thoi Gian Du An Hoat Dong, Nho Hon Ngay Hien Tai. Ngay Du An:" + eHopDong.duAn.NgayBatDau.ToLongDateString() + "-" + eHopDong.duAn.NgayKetThuc.ToLongDateString());
                return false;
            }
            return true;
        }

        private void dtmNgayHetHan_Leave(object sender, EventArgs e)
        {
            if (!CheckNgayHetHan())
            {
                dtmNgayHetHan.Focus();

            }
            else
            {
                errorProvider1.SetError(dtmNgayHetHan, "");
            }
        }

        bool CheckNgayHetHan()
        {
            if (dtmNgayHetHan.Value <= dtmNgayKyKet.Value)
            {

                errorProvider1.SetError(dtmNgayHetHan, "ngay Het Han > ngay Ky Ket");
                return false;
            }
            return true;
        }

        private void nudGiaTriHopDong_Leave(object sender, EventArgs e)
        {
            if (!CheckGiaTriHopDong())
            {
                nudGiaTriHopDong.Focus();

            }
            else
            {
                errorProvider1.SetError(nudGiaTriHopDong, "");
            }
        }

        bool CheckGiaTriHopDong()
        {
            if (nudGiaTriHopDong.Value <= 0)
            {

                errorProvider1.SetError(nudGiaTriHopDong, "Gia Tri  > 0");
                return false;
            }
            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int soLoi = 0;
            if (!ChecktenHopDong())
                soLoi++;
            if (!CheckNgayKyKet())
                soLoi++;
            if (!CheckNgayHetHan())
                soLoi++;
            if (!CheckGiaTriHopDong())
                soLoi++;

            if (soLoi > 0)
            {
                txtTenHopDong.Focus();
                MessageBox.Show("Thong Tin Khong Hop Le");
                return;
            }

            eHopDong.tenHopDong = txtTenHopDong.Text;
            eHopDong.ngayKyKet = dtmNgayKyKet.Value;
            eHopDong.ngayHetHan = dtmNgayHetHan.Value;
            eHopDong.giaTriHopDong = (double)nudGiaTriHopDong.Value;

            busHopDong.UpdateItem(eHopDong);

            this.Close();
        }
    }
}
