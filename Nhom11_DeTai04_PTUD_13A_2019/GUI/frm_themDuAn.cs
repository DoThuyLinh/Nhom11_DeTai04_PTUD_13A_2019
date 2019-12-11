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
    public partial class frm_themDuAn : Form
    {
        eDuAn eDuAn;
        BUSDuAn busDuAn;
        List<ePhuongXa> ePhuongXa;
        List<eQuanHuyen> eQuanHuyen;
        List<eThanhPho> eThanhPho;
        BUSDiaChi busDiaChi;
        public frm_themDuAn()
        {
            InitializeComponent();
            eDuAn = new eDuAn();
            busDuAn = new BUSDuAn();
            ePhuongXa = new List<ePhuongXa>();
            eQuanHuyen = new List<eQuanHuyen>();
            eThanhPho = new List<eThanhPho>();
            busDiaChi = new BUSDiaChi();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_themDuAn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            cboTrangThai.DataSource = new string[] { "Ý Tưởng","Kế Hoạch", "Đang triển khai","Đang Hoàn Thành", "Hoàn Thành", "Đã Đóng", "Tạm Dừng", "Thất Bại", "Không Thực Hiện" };

            eThanhPho = busDiaChi.getAllThanhPho();

            cboThanhPho.DisplayMember = "thanhPho";
            cboThanhPho.ValueMember = "maThanhPho";
            cboThanhPho.DataSource = eThanhPho;
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
                txtTenDuAn.Focus();
                
            }
            else
            {
                errorProvider1.SetError(txtTenDuAn, "");
            }
        }

        bool CheckTenDuAn()
        {
            if (txtTenDuAn.Text.Trim().Equals(""))
            {
               
                errorProvider1.SetError(txtTenDuAn, "Khong de trong ten du an");
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
            if (dtmNgayKetThuc.Value < dtmNgayBatDau.Value )
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
                txtSoNha.Focus();
           
            }
            else
            {
                errorProvider1.SetError(txtSoNha, "");
            }
        }

        bool CheckSoNha()
        {
            if (txtSoNha.Text.Trim().Equals(""))
            {
               
                errorProvider1.SetError(txtSoNha, "Khong de trong so nha");
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

            if(soLoi > 0)
            {
                txtTenDuAn.Focus();
                MessageBox.Show("Thong Tin Khong Hop Le");
                return;
            }

            eDuAn.TenDuAn = txtTenDuAn.Text;
            eDuAn.NgayBatDau = dtmNgayBatDau.Value;
            eDuAn.NgayKetThuc = dtmNgayKetThuc.Value;
            eDuAn.TrangThai = cboTrangThai.Text;
            eDuAn.TienDo = (int)nudTienDoHoanThanh.Value;
            eDuAn.DiaChi = new eDiaChi(txtSoNha.Text, cboPhuongXa.Text, cboQuanHuyen.Text, cboThanhPho.Text);

            busDuAn.AddItem(eDuAn);

            this.Close();
        }
    }
}
