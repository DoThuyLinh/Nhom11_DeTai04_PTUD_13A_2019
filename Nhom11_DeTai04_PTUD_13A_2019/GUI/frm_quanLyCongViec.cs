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
    public partial class frm_quanLyCongViec : Form
    {
        private BUSCongViec _congViec;
        BindingSource BindingSourceCongViec;
        List<eCongViec> listCongViec = null;
        private static System.Data.DataTable dataTable;
        public frm_quanLyCongViec()
        {
            _congViec = new BUSCongViec();
            BindingSourceCongViec = new BindingSource();
            BeginTable();
            InitializeComponent();

        }
        public void BeginTable()
        {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Công Việc");
            dataTable.Columns.Add("Tên Công Việc");
            dataTable.Columns.Add("Ngày Bắt Đầu");
            dataTable.Columns.Add("Ngày Kết Thúc");
            dataTable.Columns.Add("Tiến Độ Công Việc");
            dataTable.Columns.Add("Trạng Thái");
        }

        public frm_quanLyCongViec(List<eCongViec> list)
        {
            InitializeComponent();
            listCongViec = list;
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
            dgv_congViec.Columns["tenCongViec"].Width = 500;
            dgv_congViec.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dgv_congViec.Columns["ngayBatDau"].Width = 150;
            dgv_congViec.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dgv_congViec.Columns["ngayKetThuc"].Width = 150;
            dgv_congViec.Columns["tienDo"].HeaderText = "Tiến độ công việc";
            dgv_congViec.Columns["tienDo"].Width = 170;
            dgv_congViec.Columns["trangThai"].HeaderText = "Trạng thái";
            dgv_congViec.Columns["trangThai"].Width = 150;
            dgv_congViec.Columns["viTriCongViec"].HeaderText = "Vị trí công việc";
            dgv_congViec.Columns["viTriCongViec"].Width = 200;
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
        private void Frm_menu_Load(object sender, EventArgs e)
        {
            dtmToday.Value = DateTime.Today;

            btnQuanLyCongViec.Normalcolor = Color.FromArgb(39, 99, 109);
            if (listCongViec == null)
            {
                BindingSourceCongViec.DataSource = _congViec.GetAllList();
                dgv_congViec.DataSource = BindingSourceCongViec;
                foreach (var item in _congViec.GetAllList())
                {
                    dataTable.Rows.Add(item.MaCongViec, item.TenCongViec, item.NgayBatDau, item.NgayKetThuc, item.Tiendo,item.TrangThai);
                }
                LoadDgvCongViec();
            }
            else if (listCongViec != null)
            {
                dgv_congViec.DataSource = listCongViec;
                LoadDgvCongViec();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_timKiemCongViec timKiemCongViec = new frm_timKiemCongViec();
            timKiemCongViec.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_themCongViec themCongViec = new frm_themCongViec();
            themCongViec.ShowDialog();
            if (themCongViec.DialogResult == DialogResult.OK)
            {
                BindingSourceCongViec.DataSource = _congViec.GetAllList();
                dgv_congViec.DataSource = BindingSourceCongViec;
                LoadDgvCongViec();
            }
        }

        private void btnSuaCongViec_Click(object sender, EventArgs e)
        {
            if (dgv_congViec.SelectedRows.Count > 0)
            {
                string maCongViec = dgv_congViec.SelectedCells[0].Value.ToString();
                eCongViec cv = new eCongViec();
                cv = _congViec.GetSingleItemByCondiditon(t=>t.MaCongViec.Equals(maCongViec));
                frm_suaCongViec suaCongViec = new frm_suaCongViec(cv.MaCongViec, cv.DuAn, cv.TenCongViec, cv.NgayBatDau, cv.NgayKetThuc, cv.TrangThai, cv.Tiendo, cv.ViTriCongViec);
                suaCongViec.ShowDialog();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xuất file excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Export(dataTable, "Sheet1", "Danh sách công việc");
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

            cl1.Value2 = "Mã Công Việc";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");

            cl2.Value2 = "Tên Công Việc";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Ngày Bắt Đầu";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl4.Value2 = "Ngày Kết Thúc";

            cl4.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Tiến Độ Công Việc";

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

        private void dgv_congViec_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_congViec.CurrentRow != null)
            {
                int rowindex = dgv_congViec.CurrentRow.Index;
                if (rowindex >= 0)
                {
                    DataGridViewRow row = dgv_congViec.Rows[rowindex];
                    lbl_tenCongViec.Text = row.Cells[2].Value.ToString();
                    pro_tienDoHoanThanh.Value = Int32.Parse(row.Cells[6].Value.ToString());
                    lbl_tienDoHoanThanh.Text = row.Cells[6].Value.ToString() + "%";
                    dtm_ngayBatDau.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                    dtm_ngayKetThuc.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                    txt_trangThai.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_congViec.DataSource = null;
            BUSCongViec cv = new BUSCongViec();
            dgv_congViec.DataSource = cv.GetAllList();
            LoadDgvCongViec();
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

        private void logo_Click(object sender, EventArgs e)
        {
            frm_userMain userMain = new frm_userMain();
            userMain.Show();
            timerClose.Start();
        }

        private void btnQuanLyDuAn_Click(object sender, EventArgs e)
        {
            frm_quanLyDuAn quanLyDuAn = new frm_quanLyDuAn();
            quanLyDuAn.ShowDialog();
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

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
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

        private void logo_MouseHover(object sender, EventArgs e)
        {
            setTooltip(logo, "Bàn làm việc");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Html\HTMLHelp.html");
        }
    }
}
