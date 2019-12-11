using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_doiMatKhau : Form
    {
        BUSTaiKhoan _taiKhoan;
        public frm_doiMatKhau()
        {
            InitializeComponent();
            _taiKhoan = new BUSTaiKhoan();
        }
        public void setTooltip(Control control)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(control, "Vui lòng điền vào trường này");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_doiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhauCu_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtMatKhauCu);
        }

        private void txtMatKhauMoi_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtMatKhauMoi);
        }

        private void txtNhapLaiMatKhau_MouseHover(object sender, EventArgs e)
        {
            setTooltip(txtNhapLaiMatKhau);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text != null && txtMatKhauMoi.Text != null && txtNhapLaiMatKhau.Text != null)
            {
                if (Regex.IsMatch(txtMatKhauMoi.Text, @"^(\w|\b|@|_){6,}$") && txtMatKhauMoi.Text.Equals(txtNhapLaiMatKhau.Text))
                {
                    eTaiKhoan tk = _taiKhoan.GetAllList();
                    eTaiKhoan taiKhoan = new eTaiKhoan(tk.taiKhoan, txtMatKhauMoi.Text);
                    if (txtMatKhauCu.Text.Equals(tk.matKhau))
                    {
                        if (_taiKhoan.UpdateItem(taiKhoan))
                        {
                            lblThongBao.Text = "Thay đổi mật khẩu thành công.";
                            lblThongBao.ForeColor = Color.Black;
                        }
                        else
                        {
                            lblThongBao.Text = "Lỗi cập nhật.";
                            lblThongBao.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblThongBao.Text = "Mật khẩu cũ không đúng.";
                        lblThongBao.ForeColor = Color.Red;
                    }
                }
                else if (txtMatKhauMoi.Text.Equals(txtNhapLaiMatKhau.Text) == false)
                {
                    lblThongBao.Text = "Mật khẩu không trùng khớp.";
                    lblThongBao.ForeColor = Color.Red;
                }
                else
                {
                    lblThongBao.Text = "Mật khẩu phải lớn hơn 5 ký tự và không bao gồm các ký tự đặc biệt.";
                    lblThongBao.ForeColor = Color.Red;
                }
            }
        }
    }
}
