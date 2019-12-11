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
    public partial class frm_themCongViec : Form
    {
        eCongViec congViec;
        BUSCongViec busCongViec;
        BUSDuAn busDuAn;
        public frm_themCongViec()
        {
            InitializeComponent();
            congViec = new eCongViec();
            busCongViec = new BUSCongViec();
            busDuAn = new BUSDuAn();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_themCongViec_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);
            List<eDuAn> listDuAn = new List<eDuAn>();
            foreach (eDuAn i in busDuAn.GetAllList())
            {
                i.TenDuAn = "[" + i.MaDuAn + "] " + i.TenDuAn;
                listDuAn.Add(i);
            }

            // Gan danh sach Du An cho combobox
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.ValueMember = "MaDuAn";
            cboDuAn.DataSource = listDuAn;

            // Gan trang thai
            cboTrangThai.DataSource = new string[] { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" };
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void cboDuAn_Leave(object sender, EventArgs e)
        {

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

        private void dtmNgayKetThuc_Leave(object sender, EventArgs e)
        {
            if (!checkNgayKetThuc())
            {
                dtmNgayKetThuc.Focus();
             
            }
            else
            {
                errorProvider1.SetError(dtmNgayKetThuc, "");
            }
        }

        bool checkNgayKetThuc()
        {
            if (dtmNgayBatDau.Value < dtmNgayKetThuc.Value)
            {
               
                errorProvider1.SetError(dtmNgayKetThuc, "ngay ket thuc phai lon hon ngay bat dau");
                return false;
            }

            return true;
        }

        private void nudTienDoCongViec_Leave(object sender, EventArgs e)
        {
            if (!checkTienDoCongViec())
            {
                nudTienDoCongViec.Focus();
           
            }
            else
            {
                errorProvider1.SetError(nudTienDoCongViec, "");
            }
        }

        bool checkTienDoCongViec()
        {
            if (nudTienDoCongViec.Value < 0 || nudTienDoCongViec.Value > 100)
            { 
                errorProvider1.SetError(nudTienDoCongViec, "tu 0 den 100");
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soLoi = 0;

            if (!checkTenCongViec())
                soLoi++;
            if (!checkNgayKetThuc())
                soLoi++;
            if (checkTienDoCongViec())
                soLoi++;
            if(soLoi > 0)
            {
                txtTenCongViec.Focus();
                MessageBox.Show("Thong Tin Nhap Khong Hop Le");
                return;
            }
            congViec.DuAn.MaDuAn = cboDuAn.SelectedValue.ToString();
            congViec.TenCongViec = txtTenCongViec.Text;
            congViec.Tiendo = (int)nudTienDoCongViec.TextAlign;
            congViec.TrangThai = cboTrangThai.Text;
            congViec.NgayBatDau = dtmNgayBatDau.Value;
            congViec.NgayKetThuc = dtmNgayKetThuc.Value;
            congViec.ViTriCongViec = cboViTriCongViec.Text;
            busCongViec.AddItem(congViec);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
