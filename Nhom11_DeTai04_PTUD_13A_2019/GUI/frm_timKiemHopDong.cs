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
    public partial class frm_timKiemHopDong : Form
    {
        BUSHopDong _hopDong;
        BUSDuAn _duAn;
        public frm_timKiemHopDong()
        {
            _duAn = new BUSDuAn();
            _hopDong = new BUSHopDong();
            InitializeComponent();
        }
        public void searchHopDong(List<eHopDong> list)
        {
            frm_quanLyHopDong _quanLyHopDong = new frm_quanLyHopDong(list);
            _quanLyHopDong.ShowDialog();
            timerClose.Start();
        }
        private void LoadCBODuAn()
        {
            List<eDuAn> listDuAn = _duAn.GetAllList();
            var item = cboDuAn.Items;
            cboDuAn.Text = listDuAn.ElementAt(0).MaDuAn + " - " + listDuAn.ElementAt(0).TenDuAn;
            foreach (eDuAn da in listDuAn)
            {
                item.Add(da.MaDuAn +"-"+da.TenDuAn);
            }
        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_timKiemHopDong_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);
            LoadCBODuAn();
        }

        private void btnMaHopDong_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Enabled = true;
            txtTenHopDong.Enabled = false;
            dtmNgayKyKet.Enabled = false;
            dtmNgayHetHan.Enabled = false;
            cboDuAn.Enabled = false;

            btnMaHopDong.Normalcolor = Color.FromArgb(39, 99, 109);
            btnMaHopDong.Textcolor = Color.White;

            btnTenHopDong.Normalcolor = Color.White;
            btnTenHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKyKet.Normalcolor = Color.White;
            btnNgayKyKet.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayHetHan.Normalcolor = Color.White;
            btnNgayHetHan.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTenHopDong_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Enabled = false;
            txtTenHopDong.Enabled = true;
            dtmNgayKyKet.Enabled = false;
            dtmNgayHetHan.Enabled = false;
            cboDuAn.Enabled = false;

            btnTenHopDong.Normalcolor = Color.FromArgb(39, 99, 109);
            btnTenHopDong.Textcolor = Color.White;

            btnMaHopDong.Normalcolor = Color.White;
            btnMaHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKyKet.Normalcolor = Color.White;
            btnNgayKyKet.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayHetHan.Normalcolor = Color.White;
            btnNgayHetHan.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayKyKet_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Enabled = false;
            txtTenHopDong.Enabled = false;
            dtmNgayKyKet.Enabled = true;
            dtmNgayHetHan.Enabled = false;
            cboDuAn.Enabled = false;

            btnNgayKyKet.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayKyKet.Textcolor = Color.White;

            btnMaHopDong.Normalcolor = Color.White;
            btnMaHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenHopDong.Normalcolor = Color.White;
            btnTenHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayHetHan.Normalcolor = Color.White;
            btnNgayHetHan.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnNgayHetHan_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Enabled = false;
            txtTenHopDong.Enabled = false;
            dtmNgayKyKet.Enabled = false;
            dtmNgayHetHan.Enabled = true;
            cboDuAn.Enabled = false;

            btnNgayHetHan.Normalcolor = Color.FromArgb(39, 99, 109);
            btnNgayHetHan.Textcolor = Color.White;

            btnMaHopDong.Normalcolor = Color.White;
            btnMaHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenHopDong.Normalcolor = Color.White;
            btnTenHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKyKet.Normalcolor = Color.White;
            btnNgayKyKet.Textcolor = Color.FromArgb(68, 71, 72);
            btnDuAn.Normalcolor = Color.White;
            btnDuAn.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Enabled = false;
            txtTenHopDong.Enabled = false;
            dtmNgayKyKet.Enabled = false;
            dtmNgayHetHan.Enabled = false;
            cboDuAn.Enabled = true;

            btnDuAn.Normalcolor = Color.FromArgb(39, 99, 109);
            btnDuAn.Textcolor = Color.White;

            btnMaHopDong.Normalcolor = Color.White;
            btnMaHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnTenHopDong.Normalcolor = Color.White;
            btnTenHopDong.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayKyKet.Normalcolor = Color.White;
            btnNgayKyKet.Textcolor = Color.FromArgb(68, 71, 72);
            btnNgayHetHan.Normalcolor = Color.White;
            btnNgayHetHan.Textcolor = Color.FromArgb(68, 71, 72);
            btnTimKiem.Normalcolor = Color.White;
            btnTimKiem.Textcolor = Color.FromArgb(68, 71, 72);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maHopDong = txtMaHopDong.Text.Trim();
            string tenHopDong = txtTenHopDong.Text;
            DateTime ngayKyKet = DateTime.Parse(dtmNgayKyKet.Value.ToString("yyyy/MM/dd"));
            DateTime ngayHetHan = DateTime.Parse(dtmNgayHetHan.Value.ToString("yyyy/MM/dd"));

            if (maHopDong != string.Empty && btnMaHopDong.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eHopDong> listHopDong = _hopDong.GetManyItemByCondition(x => x.maHopDong == maHopDong);
                if (listHopDong.Count >0)
                {
                    searchHopDong(listHopDong);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy hợp đồng yêu cầu.";
                }
            }
            else if (btnMaHopDong.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập mã hợp đồng cần tìm.";
            }

            if (tenHopDong != string.Empty && btnTenHopDong.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eHopDong> listHopDong = _hopDong.GetManyItemByCondition(x => x.tenHopDong == tenHopDong);
                if (listHopDong.Count > 0)
                {
                    searchHopDong(listHopDong);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy hợp đồng yêu cầu.";
                }
            }
            else if (btnTenHopDong.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                lblThongBao.Text = "Nhập tên hợp đồng cần tìm.";
            }

            if (ngayKyKet != null && btnNgayKyKet.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eHopDong> listHopDong = _hopDong.GetManyItemByCondition(x => x.ngayKyKet == ngayKyKet);
                if (listHopDong.Count > 0)
                {
                    searchHopDong(listHopDong);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy hợp đồng yêu cầu.";
                }
            }

            if (ngayHetHan != null && btnNgayHetHan.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eHopDong> listHopDong = _hopDong.GetManyItemByCondition(x => x.ngayHetHan == ngayHetHan);
                if (listHopDong.Count > 0)
                {
                    searchHopDong(listHopDong);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy hợp đồng yêu cầu.";
                }
            }
            string[] arrDuAn = cboDuAn.Text.Split('-');
            if(btnDuAn.Normalcolor == Color.FromArgb(39, 99, 109))
            {
                List<eHopDong> listHopDong = _hopDong.GetManyItemByCondition(x => x.maDuAn == arrDuAn[0]);
                if (listHopDong.Count > 0)
                {
                    searchHopDong(listHopDong);
                }
                else
                {
                    lblThongBao.Text = "Không tìm thấy hợp đồng yêu cầu.";
                }
            }
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
