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
    public partial class frm_quanLyHopDong : Form
    {
        private BUSHopDong _hopDong;
        BindingSource BindingSourceHopDong;
        List<eHopDong> listHopDong;
        private static System.Data.DataTable dataTable;
        public frm_quanLyHopDong()
        {
            _hopDong = new BUSHopDong();
            BindingSourceHopDong = new BindingSource();
            BeginTable();
            InitializeComponent();
        }
        public void BeginTable()
        {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Hợp Đồng");
            dataTable.Columns.Add("Tên Hợp Đồng");
            dataTable.Columns.Add("Ngày Ký Kết");
            dataTable.Columns.Add("Ngày Hết Hạn");
            dataTable.Columns.Add("Giá Trị Hợp Đồng");
            dataTable.Columns.Add("Thông Tin");
        }
        public frm_quanLyHopDong(List<eHopDong> list)
        {
            InitializeComponent();
            listHopDong = list;
        }

        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview hop dong
        /// </summary>
        public void LoadDgvHopDong()
        {
            dgv_hopDong.Columns["maHopDong"].HeaderText = "Mã hợp đồng";
            dgv_hopDong.Columns["maHopDong"].Width = 100;
            dgv_hopDong.Columns["DuAn"].Visible = false;
            dgv_hopDong.Columns["tenHopDong"].HeaderText = "Tên hợp đồng";
            dgv_hopDong.Columns["tenHopDong"].Width = 500;
            dgv_hopDong.Columns["ngayKyKet"].HeaderText = "Ngày ký kết";
            dgv_hopDong.Columns["ngayKyKet"].Width = 150;
            dgv_hopDong.Columns["ngayHetHan"].HeaderText = "Ngày hết hạn";
            dgv_hopDong.Columns["ngayHetHan"].Width = 150;
            dgv_hopDong.Columns["giaTriHopDong"].HeaderText = "giá trị hợp đồng";
            dgv_hopDong.Columns["giaTriHopDong"].Width = 170;
            dgv_hopDong.Columns["thongTin"].HeaderText = "Thông tin";
            dgv_hopDong.Columns["thongTin"].Width = 150;
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_timKiemHopDong timKiemHopDong = new frm_timKiemHopDong();
            timKiemHopDong.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_themHopDong themHopDong = new frm_themHopDong();
            themHopDong.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_hopDong.SelectedRows.Count > 0)
            {

                string maHopDong = dgv_hopDong.SelectedCells[0].Value.ToString();
                string maDuAn = dgv_hopDong.SelectedCells[1].Value.ToString();
                string tenHopDong = dgv_hopDong.SelectedCells[2].Value.ToString();
                DateTime ngayKyKet = (DateTime)dgv_hopDong.SelectedCells[3].Value;
                double giaTriHopDong = (double)dgv_hopDong.SelectedCells[4].Value;
                DateTime ngayHetHan = (DateTime)dgv_hopDong.SelectedCells[5].Value;
                string thongTin = dgv_hopDong.SelectedCells[6].Value.ToString();

                frm_suaHopDong suaHopDong = new frm_suaHopDong(maHopDong, maDuAn, tenHopDong, ngayKyKet, ngayHetHan, giaTriHopDong, thongTin);

                suaHopDong.ShowDialog();
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xuất file excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Export(dataTable, "Sheet1", "Danh sách hợp đồng");
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

            cl1.Value2 = "Mã Hợp Đồng";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");

            cl2.Value2 = "Tên Hợp Đồng";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Ngày Ký Kết";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl4.Value2 = "Ngày Hết Hạn";

            cl4.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Giá Trị Hợp Đồng";

            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");

            cl6.Value2 = "Thông Tin";

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

        private void frm_quanLyHopDong_Load(object sender, EventArgs e)
        {
            dtmToday.Value = DateTime.Today;

            btnQuanLyHopDong.Normalcolor = Color.FromArgb(39, 99, 109);
            if (listHopDong == null)
            {
                BindingSourceHopDong.DataSource = _hopDong.GetAllList();
                dgv_hopDong.DataSource = BindingSourceHopDong;
                foreach (var item in _hopDong.GetAllList())
                {
                    dataTable.Rows.Add(item.maHopDong, item.tenHopDong, item.ngayKyKet, item.ngayHetHan, item.giaTriHopDong, item.thongTin);
                }
                LoadDgvHopDong();
            }
            else
            {
                dgv_hopDong.DataSource = listHopDong;
                LoadDgvHopDong();
            }
        }

        private void dgv_hopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_hopDong.CurrentRow != null)
            {
                int rowindex = dgv_hopDong.CurrentRow.Index;
                if (rowindex >= 0)
                {
                    DataGridViewRow row = dgv_hopDong.Rows[rowindex];
                    lbl_tenHopDong.Text = row.Cells[2].Value.ToString();
                    dtm_ngayKyKet.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                    dtm_ngayHetHan.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                    txt_giaTriHopDong.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_hopDong.DataSource = null;
            BUSHopDong hd = new BUSHopDong();
            dgv_hopDong.DataSource = hd.GetAllList();
            LoadDgvHopDong();
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

        private void cirPicUser_Click(object sender, EventArgs e)
        {
            frm_taiKhoan cirPicUser = new frm_taiKhoan();
            cirPicUser.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Html\HTMLHelp.html");
        }
    }
}
