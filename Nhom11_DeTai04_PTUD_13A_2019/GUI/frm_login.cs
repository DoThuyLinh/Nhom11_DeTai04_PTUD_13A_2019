using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace GUI
{
    public partial class frm_login : Form
    {
        BUSTaiKhoan tk;
        public frm_login()
        {
            InitializeComponent();
            tk = new BUSTaiKhoan();
            frm_flashScreen frm_FlashScreen = new frm_flashScreen();
            frm_FlashScreen.ShowDialog();
        }
        public void setTooltip(Control control)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(control, "Vui lòng điền vào trường này");
        }
        private void Pic_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            picLogoName.BackgroundImage = Properties.Resources.logologin;
            panelTenDangNhap.BackColor = Color.FromArgb(78, 184, 206);
            txtTenDangNhap.ForeColor = Color.FromArgb(14, 23, 24);
            picLogoPass.BackgroundImage = Properties.Resources.logologin2;
            panelMatKhau.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void TxtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            picLogoName.BackgroundImage = Properties.Resources.logologin;
            panelTenDangNhap.BackColor = Color.FromArgb(180, 180, 180);
            txtMatKhau.PasswordChar = '*';
            picLogoPass.BackgroundImage = Properties.Resources.logologin2;
            panelMatKhau.BackColor = Color.FromArgb(78, 184, 206);
            txtMatKhau.ForeColor = Color.FromArgb(14, 23, 24);
        }
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            eTaiKhoan taikhoan = tk.GetAllList();
            
            if (txtTenDangNhap.Text == taikhoan.taiKhoan && txtMatKhau.Text== taikhoan.matKhau)
            {
                frm_userMain userMain = new frm_userMain();
                userMain.ShowDialog();
                timerClose.Start();
            }
            else
            {
                lblThongBao.Text = "Tài khoản hoặc mật khẩu không chính xác.";
            }
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            eTaiKhoan taikhoan = tk.GetAllList();
            txtTenDangNhap.Text = taikhoan.taiKhoan;
            txtMatKhau.Text = taikhoan.matKhau;
        }

        private void txtTenDangNhap_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtTenDangNhap);
        }

        private void txtMatKhau_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtMatKhau);
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
