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
    public partial class frm_taiKhoan : Form
    {
        public frm_taiKhoan()
        {
            InitializeComponent();
        }

        private void frm_cirPicUser_Load(object sender, EventArgs e)
        {
            this.Location= new Point(1000,55);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_doiMatKhau doiMatKhau = new frm_doiMatKhau();
            doiMatKhau.Show();
           // this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn đăng xuất?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                frm_login login = new frm_login();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
