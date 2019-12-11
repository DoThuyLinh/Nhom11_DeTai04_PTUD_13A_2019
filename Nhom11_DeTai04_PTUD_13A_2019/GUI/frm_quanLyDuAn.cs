using Business;
using DataAccess;
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
    public partial class frm_quanLyDuAn : Form
    {
        private BUSDuAn _duAn;
        BindingSource BindingSourceDuAn;
        List<eDuAn> listDuAn = null;
        private static System.Data.DataTable dataTable;
        public frm_quanLyDuAn()
        {
            _duAn = new BUSDuAn();
            BindingSourceDuAn = new BindingSource();
            BeginTable();
            InitializeComponent();
        }
        public void BeginTable()
        {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Dự Án");
            dataTable.Columns.Add("Tên Dự Án");
            dataTable.Columns.Add("Ngày Bắt Đầu");
            dataTable.Columns.Add("Ngày Kết Thúc");
            dataTable.Columns.Add("Tiến Độ Hoàn Thành");
            dataTable.Columns.Add("Trạng Thái");
        }

        public frm_quanLyDuAn(List<eDuAn> list)
        {
            InitializeComponent();
            listDuAn = list;
        }

        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview du an
        /// </summary>
        public void LoadDgvDuAn()
        {
            dgv_duAn.Columns["maDuAn"].HeaderText = "Mã dự án";
            dgv_duAn.Columns["maDuAn"].Width = 100;
            dgv_duAn.Columns["tenDuAn"].HeaderText = "Tên dự án";
            dgv_duAn.Columns["tenDuAn"].Width = 300;
            dgv_duAn.Columns["DiaChi"].Visible = false;
            dgv_duAn.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dgv_duAn.Columns["ngayBatDau"].Width = 120;
            dgv_duAn.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dgv_duAn.Columns["ngayKetThuc"].Width = 120;
            dgv_duAn.Columns["tienDo"].HeaderText = "Tiến độ hoàn thành";
            dgv_duAn.Columns["tienDo"].Width = 170;
            dgv_duAn.Columns["trangThai"].HeaderText = "Trạng thái";
            dgv_duAn.Columns["trangThai"].Width = 150;
        }

        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview cong viec
        /// </summary>
        public void LoadDgvCongViec()
        {
            dgv_congViec.Columns["maCongViec"].HeaderText = "Mã công việc";
            dgv_congViec.Columns["maCongViec"].Width = 100;
            dgv_congViec.Columns["DuAn"].Visible = false;
            dgv_congViec.Columns["tenCongViec"].HeaderText = "Tên công việc";
            dgv_congViec.Columns["tenCongViec"].Width = 300;
            dgv_congViec.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dgv_congViec.Columns["ngayBatDau"].Width = 150;
            dgv_congViec.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dgv_congViec.Columns["ngayKetThuc"].Width = 150;
            dgv_congViec.Columns["tienDo"].HeaderText = "Tiến độ công việc";
            dgv_congViec.Columns["tienDo"].Width = 170;
            dgv_congViec.Columns["trangThai"].HeaderText = "Trạng thái";
            dgv_congViec.Columns["trangThai"].Width = 150;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_themDuAn themDuAn = new frm_themDuAn();
            themDuAn.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xuất file excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Export(dataTable, "Sheet1", "Danh sách dự án");
            }
        }
        public void Export(System.Data.DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A2", "A2");

            cl1.Value2 = "Mã Dự Án";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");

            cl2.Value2 = "Tên Dự Án";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Ngày Bắt Đầu";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl4.Value2 = "Ngày Kết Thúc";

            cl4.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Tiến Độ Hoàn Thành";

            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");

            cl6.Value2 = "Trạng Thái";

            cl6.ColumnWidth = 25.0;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "F2");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 3;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }

        private void frm_quanLyDuAn_Load(object sender, EventArgs e)
        {
            dtmToday.Value = DateTime.Today;

            btnQuanLyDuAn.Normalcolor = Color.FromArgb(39, 99, 109);
            if (listDuAn == null)
            {
                BindingSourceDuAn.DataSource = _duAn.GetAllList();
                dgv_duAn.DataSource = BindingSourceDuAn;
                foreach (var item in _duAn.GetAllList())
                {
                    dataTable.Rows.Add(item.MaDuAn, item.TenDuAn, item.NgayBatDau, item.NgayKetThuc, item.TienDo, item.TrangThai);
                }
                LoadDgvDuAn();
            }
            else if (listDuAn != null)
            {
                dgv_duAn.DataSource = listDuAn;
                LoadDgvDuAn();

            }

        }
        private void dgv_duAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_duAn.CurrentRow != null)
            {
                int rowindex = dgv_duAn.CurrentRow.Index;
                if (rowindex >= 0)
                {
                    DataGridViewRow row = dgv_duAn.Rows[rowindex];
                    string maDuAn = row.Cells[0].Value.ToString();
                    BUSCongViec cv = new BUSCongViec();
                    List<eCongViec> list = cv.GetManyItemByCondition(x => x.DuAn.MaDuAn == maDuAn);
                    dgv_congViec.DataSource = list;
                    LoadDgvCongViec();
                    lbl_tenDuAn.Text = row.Cells[1].Value.ToString();
                    lbl_ngayThangNam.Text = row.Cells[2].Value.ToString() + "-" + row.Cells[3].Value.ToString();
                    lbl_trangThai.Text = "Trạng thái: " + row.Cells[5].Value.ToString();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_duAn.DataSource = null;
            BUSDuAn da = new BUSDuAn();
            dgv_duAn.DataSource = da.GetAllList();
            LoadDgvDuAn();
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

        private void cirPicUser_Click(object sender, EventArgs e)
        {
            frm_taiKhoan cirPicUser = new frm_taiKhoan();
            cirPicUser.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            frm_userMain userMain = new frm_userMain();
            userMain.ShowDialog();
            timerClose.Start();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_duAn.SelectedRows.Count > 0)
            {
                string maDuAn = dgv_duAn.SelectedCells[0].Value.ToString();
                List<eDuAn> da = _duAn.GetAllList();

                eDuAn duAn = da.Where(t => t.MaDuAn.Equals(maDuAn)).SingleOrDefault();

                frm_suaDuAn suaCongViec = new frm_suaDuAn(duAn.MaDuAn, duAn.TenDuAn, duAn.NgayBatDau, duAn.NgayKetThuc, duAn.TrangThai, duAn.TienDo, duAn.DiaChi.maDiaChi, duAn.DiaChi.soNha, duAn.DiaChi.phuongXa, duAn.DiaChi.quanHuyen, duAn.DiaChi.thanhPho);
                suaCongViec.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_timKiemDuAn timKiemDuAn = new frm_timKiemDuAn();
            timKiemDuAn.Show();
        }

        private void timerClose_Tick(object sender, EventArgs e)
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

        private void dgv_duAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Html\HTMLHelp.html");
        }
    }
}
