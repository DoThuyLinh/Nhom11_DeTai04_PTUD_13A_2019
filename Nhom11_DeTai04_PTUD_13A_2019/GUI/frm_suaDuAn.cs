using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace GUI
{
    public partial class frm_suaDuAn : Form
    {
        List<ePhuongXa> ePhuongXa;
        List<eQuanHuyen> eQuanHuyen;
        List<eThanhPho> eThanhPho;
        BUSDiaChi busDiaChi;


        // Du An
        BUSDuAn busDuAn;
        eDuAn eDuAn;


        public frm_suaDuAn(string maDuAn, string tenDuAn, DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai, int tienDoHoanThanh, string maDiaChi, string soNha, string phuongXa, string quanHuyen, string thanhPho)
        {

            InitializeComponent();

            ePhuongXa = new List<ePhuongXa>();
            eQuanHuyen = new List<eQuanHuyen>();
            eThanhPho = new List<eThanhPho>();
            busDiaChi = new BUSDiaChi();


            eDuAn = new eDuAn();
            busDuAn = new BUSDuAn();

            eDuAn.MaDuAn = maDuAn;
            eDuAn.NgayBatDau = ngayBatDau;
            eDuAn.NgayKetThuc = ngayKetThuc;
            eDuAn.TrangThai = trangThai;
            eDuAn.TienDo = tienDoHoanThanh;
            eDuAn.TenDuAn = tenDuAn;

            eDuAn.DiaChi = new eDiaChi(maDiaChi, soNha, phuongXa, quanHuyen, thanhPho);

        }
        public frm_suaDuAn(string maDuAn)
        {
            
            InitializeComponent();
            
        }
        public frm_suaDuAn()
        {
            InitializeComponent();
        }
        private void LoadSubForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.ShowInTaskbar = false;
            form.TopLevel = false;
            form.Show();
            form.Dock = DockStyle.Fill;
            this.panelQuanLy.Controls.Clear();
            this.panelQuanLy.Controls.Add(form);
        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void frm_suaDuAn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            cboTrangThai.DataSource = new string[] { "Ý Tưởng", "Kế Hoạch", "Đang triển khai", "Đang Hoàn Thành", "Hoàn Thành", "Đã Đóng", "Tạm Dừng", "Thất Bại", "Không Thực Hiện" };

            eThanhPho = busDiaChi.getAllThanhPho();

            cboThanhPho.DisplayMember = "thanhPho";
            cboThanhPho.ValueMember = "maThanhPho";
            cboThanhPho.DataSource = eThanhPho;


            txtMaDuAn.Text = eDuAn.MaDuAn;
            txtSoNha1.Text = eDuAn.TenDuAn;
            dtmNgayBatDau.Value = eDuAn.NgayBatDau;
            dtmNgayKetThuc.Value = eDuAn.NgayKetThuc;
            cboTrangThai.Text = eDuAn.TrangThai;
            nudTienDoHoanThanh.Value = eDuAn.TienDo;

            txtTenDuAn.Text = eDuAn.DiaChi.soNha;
            cboThanhPho.Text = eDuAn.DiaChi.thanhPho;
            cboQuanHuyen.Text = eDuAn.DiaChi.quanHuyen;
            cboPhuongXa.Text = eDuAn.DiaChi.phuongXa;
        }

        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            eQuanHuyen = busDiaChi.getAllQuanHuyen(cboThanhPho.SelectedValue.ToString());

            cboQuanHuyen.DisplayMember = "quanHuyen";
            cboQuanHuyen.ValueMember = "maQuanHuyen";
            cboQuanHuyen.DataSource = eQuanHuyen;
        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ePhuongXa = busDiaChi.getAllPhuongXa(cboQuanHuyen.SelectedValue.ToString());

            cboPhuongXa.DisplayMember = "phuongXa";
            cboPhuongXa.ValueMember = "maPhuongXa";
            cboPhuongXa.DataSource = ePhuongXa;
        }


        

        private void txtTenDuAn_Leave(object sender, EventArgs e)
        {

            if (!CheckTenDuAn())
            {
                txtSoNha1.Focus();

            }
            else
            {
                errorProvider1.SetError(txtSoNha1, "");
            }
        }

        bool CheckTenDuAn()
        {
            if (txtSoNha1.Text.Trim().Equals(""))
            {

                errorProvider1.SetError(txtSoNha1, "Khong de trong ten du an");
                return false;
            }
            return true;
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
            if (dtmNgayKetThuc.Value < dtmNgayBatDau.Value)
            {

                errorProvider1.SetError(dtmNgayKetThuc, "ngay ket thuc  > ngay bat dau");
                return false;
            }

            return true;
        }

        private void nudTienDoHoanThanh_Leave(object sender, EventArgs e)
        {
            if (!CheckTienDoHoanThanh())
            {
                nudTienDoHoanThanh.Focus();

            }
            else
            {
                errorProvider1.SetError(nudTienDoHoanThanh, "");
            }
        }

        bool CheckTienDoHoanThanh()
        {
            if (nudTienDoHoanThanh.Value < 0 || nudTienDoHoanThanh.Value > 100)
            {

                errorProvider1.SetError(nudTienDoHoanThanh, "tu 0 den 100");
                return false;
            }
            return true;
        }

        private void txtSoNha_Leave(object sender, EventArgs e)
        {
            if (!CheckSoNha())
            {
                txtTenDuAn.Focus();

            }
            else
            {
                errorProvider1.SetError(txtTenDuAn, "");
            }
        }

        bool CheckSoNha()
        {
            if (txtTenDuAn.Text.Trim().Equals(""))
            {

                errorProvider1.SetError(txtTenDuAn, "Khong de trong so nha");
                return false;
            }
            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int soLoi = 0;
            if (!CheckNgayKetThuc())
                soLoi++;
            if (!CheckSoNha())
                soLoi++;
            if (!CheckTenDuAn())
                soLoi++;
            if (!CheckTienDoHoanThanh())
                soLoi++;

            if (soLoi > 0)
            {
                txtSoNha1.Focus();
                MessageBox.Show("Thong Tin Khong Hop Le");
                return;
            }

            eDuAn.TenDuAn = txtSoNha1.Text;
            eDuAn.NgayBatDau = dtmNgayBatDau.Value;
            eDuAn.NgayKetThuc = dtmNgayKetThuc.Value;
            eDuAn.TrangThai = cboTrangThai.Text;
            eDuAn.TienDo = (int)nudTienDoHoanThanh.Value;

            eDuAn.DiaChi.soNha = txtTenDuAn.Text;
            eDuAn.DiaChi.thanhPho = cboThanhPho.Text;
            eDuAn.DiaChi.quanHuyen = cboQuanHuyen.Text;
            eDuAn.DiaChi.phuongXa = cboPhuongXa.Text;

            busDuAn.UpdateItem(eDuAn);

            this.Close();
        }
    }
}
