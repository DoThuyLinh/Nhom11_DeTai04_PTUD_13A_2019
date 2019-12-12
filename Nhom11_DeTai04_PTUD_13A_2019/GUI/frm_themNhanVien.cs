using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_themNhanVien : Form
    {
        eNhanVien eNhanVien;
        List<ePhuongXa> ePhuongXa;
        List<eQuanHuyen> eQuanHuyen;
        List<eThanhPho> eThanhPho;
        BUSNhanVien busNhanVien;
        BUSDiaChi busDiaChi;
        public frm_themNhanVien()
        {
            InitializeComponent();
            eNhanVien = new eNhanVien();
            busNhanVien = new BUSNhanVien();
            ePhuongXa = new List<ePhuongXa>();
            eQuanHuyen = new List<eQuanHuyen>();
            eThanhPho = new List<eThanhPho>();
            busDiaChi = new BUSDiaChi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_themNhanVien_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
             this.Location = new Point(55, 42);
           

            eThanhPho = busDiaChi.getAllThanhPho();

            cboThanhPho.DisplayMember = "thanhPho";
            cboThanhPho.ValueMember = "maThanhPho";
            cboThanhPho.DataSource = eThanhPho;

            cboGioiTinh.DataSource = new string[] { "Nữ", "Nam" };

            cboViTriCongViec.DataSource = new string[] {"Quản Lý", "Khảo Sát", "Giám Sát", "Thi Công" };
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

        private void txtTienCongMotNgay_Leave(object sender, EventArgs e)
        {
            if (CheckTienCongMotNgay() == false)
            {
               
                txtTienCongMotNgay.Focus();
            }
            else
            {
               
                errorProvider1.SetError(txtTienCongMotNgay, "");
            }
        }

        bool CheckTienCongMotNgay()
        {
            if (Regex.IsMatch(txtTienCongMotNgay.Text, @"^\d+$") == false)
            {
                errorProvider1.SetError(txtTienCongMotNgay, "Khong de trong, khong nhap chu");

                return false;
            }
            return true;
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e)
        {
            if (CheckTenNhanVien() == false)
            {
                txtEmail.Focus();
               
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        bool CheckTenNhanVien()
        {
            if (txtTenNhanVien.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtTenNhanVien, "Khong de trong ten nhan vien");
                return false;
            }
            return true;
        }

        private void dtmNamSinh_Leave(object sender, EventArgs e)
        {
           

            if (CheckNamSinh() == false)
            {
                dtmNamSinh.Focus();
            }
            else
            {
                errorProvider1.SetError(dtmNamSinh, "");
            }
        }

        bool CheckNamSinh()
        {
            DateTime hientai = DateTime.Now;

            int tuoi = hientai.Year - dtmNamSinh.Value.Year;

            if (tuoi < 22 || tuoi > 65)
            {
               
                errorProvider1.SetError(dtmNamSinh, "Do tuoi khong hop le (tu 22 den 65)");
                return false;
            }
            return true;
        }

        private void dtmNgayVaoLam_Leave(object sender, EventArgs e)
        {
           

            if (CheckNgayVaoLam() == false)
            {
                dtmNgayVaoLam.Focus();
                
            }
            else
            {
                errorProvider1.SetError(dtmNgayVaoLam, "");
            }

        }

        bool CheckNgayVaoLam()
        {
            DateTime hientai = DateTime.Now;

            if (dtmNgayVaoLam.Value > hientai)
            {
               
                errorProvider1.SetError(dtmNgayVaoLam, "Ngay Vao Lam <= Ngay Hien Tai");
                return false;
            }
            return true;
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (!CheckSDT())
            {

                txtSoDienThoai.Focus();
           
            }
            else
            {

                errorProvider1.SetError(txtSoDienThoai, "");
            }
        }

        bool CheckSDT()
        {

            if (Regex.IsMatch(txtSoDienThoai.Text, @"^\d{10,12}$") == false)
            {

              
                errorProvider1.SetError(txtSoDienThoai, "nhap so tu 10 den 12 chu so");
                return false;
            }

            return true;
        }

        private void txtEMail_Leave(object sender, EventArgs e)
        {
            if (!CheckEmail())
            {
                txtEmail.Focus();
            
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        bool CheckEmail()
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^\w+(\.\w+)*@\w+(\.\w+)*$"))
            {
               
                errorProvider1.SetError(txtEmail, "email khong hop le. Mau: abc@gmail.com hoac abc@yahoo.com.vn");
                return false;
            }
            return true;
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (!CheckCMND())
            {
                txtCMND.Focus();
             
            }
            else
            {
                errorProvider1.SetError(txtCMND, "");
            }
        }

        bool CheckCMND()
        {
            if (!Regex.IsMatch(txtCMND.Text,  @"^\d{2,3}-\d{2,3}-\d{4,5}$"))
            {

                errorProvider1.SetError(txtCMND, "Khong de trong CMND, mau 333-56-8888");
                return false;
            }
            return true;
        }

        private void txtBHXH_Leave(object sender, EventArgs e)
        {
            if (!CheckBHXH())
            {
                txtBHXH.Focus();
                
            }
            else
            {
                errorProvider1.SetError(txtBHXH, "");
            }
        }

        bool CheckBHXH()
        {
            if (!Regex.IsMatch(txtBHXH.Text, @"^\d{10}$"))
            {

                errorProvider1.SetError(txtBHXH, "Khong de trong BHXH, 10 so");
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.png*)|*.jpg; *.png*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picImage.Image = new Bitmap(open.FileName);
                // image fileName 
               
                picImage.Text = Path.GetFileName(open.FileName);

               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            int soLoi = 0;

            if (!CheckTienCongMotNgay())
            {
                soLoi ++;
            }
            if (!CheckTenNhanVien())
            {
                soLoi++;
            }

            if (!CheckNamSinh())
            {
                soLoi++;
            }
            if (!CheckCMND())
            {
                soLoi++;
            }

            if (!CheckBHXH())
            {
                soLoi++;
            }
            if (!CheckSDT())
            {
                soLoi++;
            }
            
            if(!CheckSoNha())
            {
                soLoi++;
            }

            if (!CheckNgayVaoLam())
            {
                soLoi++;
            }


            if(soLoi > 0)
            {
                MessageBox.Show("Thông Tin Nhập Không Hợp Lệ");
                txtTenNhanVien.Focus();
                return;
            }

            eNhanVien.diaChi = new eDiaChi(txtSoNha.Text, cboPhuongXa.Text, cboQuanHuyen.Text, cboThanhPho.Text);

            eNhanVien.dienThoai = txtSoDienThoai.Text;
            eNhanVien.gioiTinh = cboGioiTinh.Text;
            eNhanVien.hoTen = txtEmail.Text;
            eNhanVien.namSinh = dtmNamSinh.Value;
            eNhanVien.ngayVaolam = dtmNgayVaoLam.Value;
            eNhanVien.soBaoHiemXH = txtBHXH.Text;
            eNhanVien.soCMND = txtCMND.Text;
            eNhanVien.tienCongMotNgay = double.Parse(txtTienCongMotNgay.Text);
            eNhanVien.email = txtTenNhanVien.Text;
            eNhanVien.viTriCongViec = cboViTriCongViec.Text;
            if(picImage.Text.Trim().Equals(""))
                eNhanVien.hinhAnh = "macDinh.jpg";
            else
            eNhanVien.hinhAnh = picImage.Text;

            busNhanVien.AddItem(eNhanVien);

            this.Close();
        }


    }
}
