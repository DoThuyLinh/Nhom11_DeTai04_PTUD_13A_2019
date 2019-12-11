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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.DataProcessing;

namespace GUI
{
    public partial class frm_thongKe : Form
    {
        BUSNhanVien nv;
        BUSDuAn da;
        BUSThongKe tk;
        List<eDuAn> list;
        public frm_thongKe()
        {
            nv = new BUSNhanVien();
            da = new BUSDuAn();
            tk = new BUSThongKe();
            list = new List<eDuAn>();
            InitializeComponent();

        }
        /// <summary>
        /// name: Linh
        /// content: set tooltip cho cac control
        /// </summary>
        public void setTooltip(Control control, string text)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(control, text);
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

        private void logo_Click(object sender, EventArgs e)
        {
            frm_userMain userMain = new frm_userMain();
            userMain.ShowDialog();
            timerClose.Start();
        }

        private void btnQuanLyDuAn_Click(object sender, EventArgs e)
        {
            frm_quanLyDuAn quanLyDuAn = new frm_quanLyDuAn();
            quanLyDuAn.ShowDialog();
            timerClose.Start();
        }

        private void btnQuanLyCongViec_Click(object sender, EventArgs e)
        {
            frm_quanLyCongViec quanLyCongViec = new frm_quanLyCongViec();
            quanLyCongViec.ShowDialog();
            timerClose.Start();
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            frm_quanLyHopDong quanLyHopDong = new frm_quanLyHopDong();
            quanLyHopDong.ShowDialog();
            timerClose.Start();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_quanLyNhanVien quanLyNhanVien = new frm_quanLyNhanVien();
            quanLyNhanVien.ShowDialog();
            timerClose.Start();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frm_thongKe thongKe = new frm_thongKe();
            thongKe.ShowDialog();
            timerClose.Start();
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

        private void frm_thongKe_Load(object sender, EventArgs e)
        {
            btnThongKe.Normalcolor = Color.FromArgb(39, 99, 109);
            dtmToday.Value = DateTime.Today;

            string[] listThongKe = new string[] { "Thống kê tổng số nhân viên theo dự án", "Thống kê tổng số công việc theo dự án", "Thống kê số lượng công việc của dự án theo tiến độ", "Thống kê số lượng công việc của dự án từ ngày/đến ngày", "Thống kê số lượng nhân viên của dự án từ ngày/đến ngày", "Thống kê lương" };
            cboThongKe.DataSource = listThongKe;

            list = da.GetAllList();
            cboChonDuAn.DataSource = list;
            cboChonDuAn.DisplayMember = "tenDuAn";
            cboChonDuAn.ValueMember = "tenDuAn";      

            //Load du lieu thang len combobox
            for (int i = 1; i <= 12; i++) {
                cboThang.Items.Add(i);               
            }

            //Load du lieu nam len combobox
            int namMax = Int32.Parse(DateTime.MaxValue.Year.ToString());
            for (int i = 2019; i < namMax; i++)
            {
                cboNam.Items.Add(i.ToString());
            }

            this.reportViewer1.RefreshReport();
        }
        private void cirPicUser_Click(object sender, EventArgs e)
        {
            frm_taiKhoan cirPicUser = new frm_taiKhoan();
            cirPicUser.Show();
        }

        private void logo_MouseHover(object sender, EventArgs e)
        {
            setTooltip(logo, "Bàn làm việc");
        }

        private void btnQuanLyDuAn_MouseHover(object sender, EventArgs e)
        {
            setTooltip(btnQuanLyDuAn, "Quản lý dự án");
        }

        private void btnQuanLyCongViec_MouseHover(object sender, EventArgs e)
        {
            setTooltip(btnQuanLyCongViec, "Quản lý công việc");
        }

        private void btnQuanLyHopDong_MouseHover(object sender, EventArgs e)
        {
            setTooltip(btnQuanLyHopDong, "Quản lý hợp đồng");
        }

        private void btnQuanLyNhanVien_MouseHover(object sender, EventArgs e)
        {
            setTooltip(btnQuanLyNhanVien, "Quản lý nhân viên");
        }

        private void btnThongKe_MouseHover(object sender, EventArgs e)
        {
            setTooltip(btnThongKe, "Thống kê");
        }

        private void cboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = da.GetAllList();
            if (cboThongKe.Text != "Thống kê lương")
            {
                cboChonDuAn.DataSource = list;
                cboChonDuAn.DisplayMember = "tenDuAn";
                cboChonDuAn.ValueMember = "tenDuAn";
            }
            if (cboThongKe.Text == "Thống kê tổng số nhân viên theo dự án")
            {
                cboChonDuAn.Visible = true;
                cboNam.Visible = false;
                cboThang.Visible = false;
                cboTienDo.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                lblThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;

            }
            else if(cboThongKe.Text == "Thống kê tổng số công việc theo dự án")
            {
                cboChonDuAn.Visible = true;
                cboNam.Visible = false;
                cboThang.Visible = false;
                cboTienDo.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                lblThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;
            }
            else if (cboThongKe.Text == "Thống kê số lượng công việc của dự án theo tiến độ")
            {
                cboChonDuAn.Visible = true;
                cboTienDo.Visible = true;
                cboNam.Visible = false;
                cboThang.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                lblThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;
            }
            else if (cboThongKe.Text == "Thống kê số lượng công việc của dự án từ ngày/đến ngày")
            {
                cboChonDuAn.Visible = true;
                lblTuNgay.Visible = true;
                lblDenNgay.Visible = true;
                dtmNgayBatDau.Visible = true;
                dtmNgayKetThuc.Visible = true;
                cboTienDo.Visible = false;
                cboNam.Visible = false;
                lblThang.Visible = false;
                cboThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;
            }
            else if (cboThongKe.Text == "Thống kê số lượng nhân viên của dự án từ ngày/đến ngày")
            {
                cboChonDuAn.Visible = true;
                lblTuNgay.Visible = true;
                lblDenNgay.Visible = true;
                dtmNgayBatDau.Visible = true;
                dtmNgayKetThuc.Visible = true;
                cboTienDo.Visible = false;
                cboNam.Visible = false;
                cboThang.Visible = false;
                lblThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;
            }
            else if (cboThongKe.Text == "Thống kê lương")
            {
                cboChonDuAn.Visible = true;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                cboTienDo.Visible = false;
                cboNam.Visible = false;
                lblThang.Visible = false;
                cboThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = true;

                string[] mucLuong = new string[] {"Tổng số lương theo dự án","Thống kê theo tháng", "Thống kê theo năm" };
                cboChonDuAn.DataSource = mucLuong;

                cboTinhTongLuongTheoDuAn.DataSource = list;
                cboTinhTongLuongTheoDuAn.DisplayMember = "tenDuAn";
                cboTinhTongLuongTheoDuAn.ValueMember = "tenDuAn";
            }
        }

        private void cboChonDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonDuAn.Text == "Thống kê theo tháng")
            {
                cboThang.Visible = true;
                cboNam.Visible = true;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                cboTienDo.Visible = false;
                lblThang.Visible = true;
                cboThang.Location = new Point(465, 47);
                cboNam.Location = new Point(714, 47);
                cboTinhTongLuongTheoDuAn.Visible = false;
            }
            else if (cboChonDuAn.Text == "Thống kê theo năm")
            {
                cboNam.Location = new Point(465, 47);
                
                cboThang.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                cboTienDo.Visible = false;
                cboNam.Visible = true;
                lblThang.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = false;

            }
            else if (cboChonDuAn.Text == "Tổng số lương theo dự án")
            {
                cboThang.Visible = false;
                cboNam.Visible = false;
                cboThang.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                dtmNgayBatDau.Visible = false;
                dtmNgayKetThuc.Visible = false;
                cboTienDo.Visible = false;
                cboTinhTongLuongTheoDuAn.Visible = true;

            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Html\HTMLHelp.html");
        }

        private void btnThongKeDuLieu_Click(object sender, EventArgs e)
        {
            if (cboThongKe.Text.Equals("Thống kê tổng số nhân viên theo dự án"))
            {
                tk.TongSLNhanVien(cboChonDuAn.Text, reportViewer1);
            }
            else if (cboThongKe.Text.Equals("Thống kê tổng số công việc theo dự án"))
            {
                tk.TongSoCongViec(cboChonDuAn.Text, reportViewer1);
            }
            else if (cboThongKe.Text.Equals("Thống kê số lượng công việc của dự án theo tiến độ"))
            {
                tk.BCCVTheoTienDo(cboChonDuAn.Text, cboTienDo.Text, reportViewer1);
            }
            else if (cboThongKe.Text.Equals("Thống kê số lượng công việc của dự án từ ngày/đến ngày"))
            {
                tk.TongSoCongViecTuADenB(cboChonDuAn.Text, dtmNgayBatDau.Value.ToString(), dtmNgayKetThuc.Value.ToString(), reportViewer1);
            }
            else if (cboThongKe.Text.Equals("Thống kê số lượng nhân viên của dự án từ ngày/đến ngày"))
            {
                tk.SLNhanVienTuADenB(cboChonDuAn.Text, dtmNgayBatDau.Value.ToString(), dtmNgayKetThuc.Value.ToString(), reportViewer1);
            }
            else
            {
                if (cboChonDuAn.Text.Equals("Tổng số lương theo dự án"))
                {
                    tk.TongLuongChiTraTrongDuAn(cboTinhTongLuongTheoDuAn.Text, reportViewer1);
                }
                else if (cboChonDuAn.Text.Equals("Thống kê theo tháng"))
                {
                    tk.LuongChiTraTrongDuAnTheoThang(cboNam.Text, cboThang.Text, reportViewer1);
                }
                else
                {
                    tk.LuongChiTraTrongDuAnTheoNam(cboNam.Text, reportViewer1);
                }
            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
