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
    public partial class frm_userMain : Form
    {
        BUSCongViec _congViec;
        BUSDuAn _duAn;
        public frm_userMain()
        {
            _duAn = new BUSDuAn();
            _congViec = new BUSCongViec();
            InitializeComponent();
        }
        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview du an
        /// </summary>
        public void LoadDgvDuAn()
        {
            dgvDuAn.Columns["maDuAn"].HeaderText = "Mã dự án";
            dgvDuAn.Columns["maDuAn"].Width = 100;
            dgvDuAn.Columns["tenDuAn"].HeaderText = "Tên dự án";
            dgvDuAn.Columns["tenDuAn"].Width = 300;
            dgvDuAn.Columns["DiaChi"].Visible = false;
            dgvDuAn.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dgvDuAn.Columns["ngayBatDau"].Width = 120;
            dgvDuAn.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dgvDuAn.Columns["ngayKetThuc"].Width = 150;
            dgvDuAn.Columns["tienDo"].HeaderText = "Tiến độ hoàn thành";
            dgvDuAn.Columns["tienDo"].Width = 150;
            dgvDuAn.Columns["trangThai"].HeaderText = "Trạng thái";
            dgvDuAn.Columns["trangThai"].Width = 150;
        }

        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview cong viec
        /// </summary>
        public void LoadDgvCongViec()
        {
            dgvCongViec.Columns["maCongViec"].HeaderText = "Mã công việc";
            dgvCongViec.Columns["maCongViec"].Width = 100;
            dgvCongViec.Columns["DuAn"].Visible = false;
            dgvCongViec.Columns["tenCongViec"].HeaderText = "Tên công việc";
            dgvCongViec.Columns["tenCongViec"].Width = 535;
            dgvCongViec.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dgvCongViec.Columns["ngayBatDau"].Width = 150;
            dgvCongViec.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dgvCongViec.Columns["ngayKetThuc"].Width = 150;
            dgvCongViec.Columns["tienDo"].HeaderText = "Tiến độ công việc";
            dgvCongViec.Columns["tienDo"].Width = 170;
            dgvCongViec.Columns["trangThai"].HeaderText = "Trạng thái";
            dgvCongViec.Columns["trangThai"].Width = 150;
        }

        /// <summary>
        /// name: Linh
        /// content: Load du lieu cong viec cho cac cot trong bieu do cot
        /// </summary>
        private void LoadChart()
        {
            List<eCongViec> listTong = _congViec.GetManyItemByCondition(x => x.NgayBatDau.Month == DateTime.Now.Month || x.NgayKetThuc.Month == DateTime.Now.Month);
            List<eCongViec> listDangThucHien = _congViec.GetManyItemByCondition(x => (x.NgayBatDau.Month == DateTime.Now.Month || x.NgayKetThuc.Month == DateTime.Now.Month) && x.TrangThai.Equals("Đang thực hiện"));
            List<eCongViec> listChuaThucHien = _congViec.GetManyItemByCondition(x => (x.NgayBatDau.Month == DateTime.Now.Month || x.NgayKetThuc.Month == DateTime.Now.Month) && x.TrangThai.Equals("Chưa thực hiện"));
            List<eCongViec> listHoanThanh = _congViec.GetManyItemByCondition(x => (x.NgayBatDau.Month == DateTime.Now.Month || x.NgayKetThuc.Month == DateTime.Now.Month) && x.TrangThai.Equals("Hoàn thành"));

            this.chartCongViec.Series["Công việc (30-30 ngày)"].Points.AddXY("Tổng", listTong.Count);
            this.chartCongViec.Series["Công việc (30-30 ngày)"].Points.AddXY("Đang thực hiện", listDangThucHien.Count);
            this.chartCongViec.Series["Công việc (30-30 ngày)"].Points.AddXY("Chưa thực hiện", listChuaThucHien.Count);
            this.chartCongViec.Series["Công việc (30-30 ngày)"].Points.AddXY("Hoàn thành", listHoanThanh.Count);
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
        private void PicMenu_Click(object sender, EventArgs e)
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

        private void Frm_userMain_Load(object sender, EventArgs e)
        {
            dtmToday.Value = DateTime.Today;

            LoadChart();
            List<eDuAn> listDuAn = _duAn.GetManyItemByCondition(x => (x.ngayKetThuc.Day >= (DateTime.Now.Day+10) && x.tienDoHoanThanh <= 70) || (x.ngayKetThuc.Day <= DateTime.Now.Day && x.ngayKetThuc.Month <= DateTime.Now.Month && x.ngayKetThuc.Year <= DateTime.Now.Year && x.tienDoHoanThanh <= 70));
            dgvDuAn.DataSource = listDuAn;
            LoadDgvDuAn();

            List<eCongViec> listCongViec = _congViec.GetManyItemByCondition(x => x.NgayBatDau.DayOfWeek >= DayOfWeek.Sunday && x.NgayBatDau.DayOfWeek <= DayOfWeek.Saturday && x.NgayBatDau.Month == DateTime.Now.Month && (x.NgayBatDau.Day - DateTime.Now.Day <=7));
            if (listCongViec != null)
            {
                dgvCongViec.DataSource = listCongViec;
                LoadDgvCongViec();
            }
        }
        private void BtnQuanLyDuAn_Click(object sender, EventArgs e)
        {
            frm_quanLyDuAn quanLyDuAn = new frm_quanLyDuAn();
            quanLyDuAn.ShowDialog();
            timeClose.Start();
        }

        private void BtnQuanLyCongViec_Click(object sender, EventArgs e)
        {
            frm_quanLyCongViec quanLyCongViec = new frm_quanLyCongViec();
            quanLyCongViec.ShowDialog();
            timeClose.Start();
        }

        private void Slidemenu_MouseHover(object sender, EventArgs e)
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

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            frm_quanLyHopDong quanLyHopDong = new frm_quanLyHopDong();
            quanLyHopDong.ShowDialog();
            timeClose.Start();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_quanLyNhanVien quanLyNhanVien = new frm_quanLyNhanVien();
            quanLyNhanVien.ShowDialog();
            timeClose.Start();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frm_thongKe thongKe = new frm_thongKe();
            thongKe.ShowDialog();
            timeClose.Start();
        }

        private void cirPicUser_Click(object sender, EventArgs e)
        {
            frm_taiKhoan cirPicUser = new frm_taiKhoan();
            cirPicUser.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            frm_userMain userMain = new frm_userMain();
            userMain.ShowDialog();
            timeClose.Start();
        }

        private void timeClose_Tick(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Html\HTMLHelp.html");
        }
    }
}
