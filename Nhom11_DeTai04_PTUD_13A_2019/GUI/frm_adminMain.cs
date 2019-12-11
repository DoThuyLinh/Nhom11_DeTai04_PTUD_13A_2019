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
    public partial class frm_adminMain : Form
    {
        public frm_adminMain()
        {
            InitializeComponent();
        }
        public void setTooltip(Control control,string tb)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(control, tb);
        }
        private void picMenu_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 200)
            {
                LogoAnimator.Hide(logo);
                slidemenu.Visible = false;
                slidemenu.Width = 55;
                panelQuanLy.Width = 1311;
                LogoAnimator.ShowSync(slidemenu);
            }
        }

        private void slidemenu_MouseHover(object sender, EventArgs e)
        {
            if (slidemenu.Width == 55)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 200;
                LogoAnimator.ShowSync(slidemenu);
                LogoAnimator.ShowSync(logo);
                panelQuanLy.Width = 1166;
            }
        }

        private void txtTenTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtTenTaiKhoan,"Vui lòng điền vào trường này.");
        }

        private void cboMaNhanVien_MouseHover(object sender, EventArgs e)
        {
            setTooltip(cboMaNhanVien, "Chọn nhân viên để thêm.");
        }

        private void cboTenNhanVien_MouseHover(object sender, EventArgs e)
        {
            setTooltip(cboTenNhanVien, "Chọn nhân viên để thêm.");
        }

        private void cboPhongBan_MouseHover(object sender, EventArgs e)
        {
            setTooltip(cboPhongBan, "phòng ban của nhân viên");
        }

        private void cboChucVu_MouseHover(object sender, EventArgs e)
        {
            setTooltip(cboChucVu, "Chọn chức vụ của nhân viên.");
        }

        private void txtMatKhauMacDinh_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtMatKhauMacDinh, "Vui lòng điền vào trường này.");
        }

        private void cirPicUser_Click(object sender, EventArgs e)
        {
            frm_cirPicUser cirPicUser = new frm_cirPicUser();
            cirPicUser.ShowDialog();
        }
    }
}
