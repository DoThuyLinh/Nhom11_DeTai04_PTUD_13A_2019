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
    public partial class frm_quanLyNhanVien : Form
    {
        private BUSNhanVien _nhanVien;
        private BindingSource BindingSourceNhanVien;
        private List<eNhanVien> listNhanVien;
        private static System.Data.DataTable dataTable;
        public frm_quanLyNhanVien()
        {
            _nhanVien = new BUSNhanVien();
            BindingSourceNhanVien = new BindingSource();
            BeginTable();
            InitializeComponent();
        }
        public frm_quanLyNhanVien(List<eNhanVien> list)
        {
            InitializeComponent();
            listNhanVien = list;
        }
        public void BeginTable()
        {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Ma Nhan Vien");
            dataTable.Columns.Add("Ten Nhan Vien");
            dataTable.Columns.Add("Dien Thoai");
            dataTable.Columns.Add("So Chung Minh Nhan Dan");
            dataTable.Columns.Add("So Bao Hiem Xa Hoi");
            dataTable.Columns.Add("Ngay Vao lam");
            dataTable.Columns.Add("Ngay Sinh");
            dataTable.Columns.Add("Gioi Tinh");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Tien Cong Mot Ngay");
            dataTable.Columns.Add("Hinh Anh");
        }

        /// <summary>
        /// name: Linh
        /// content: Load cac column cho datagridview nhan vien
        /// </summary>
        public void LoadDgvNhanVien()
        {
            dgv_nhanVien.Columns["maNhanVien"].HeaderText = "Mã nhân viên";
            dgv_nhanVien.Columns["maNhanVien"].Width = 100;
            dgv_nhanVien.Columns["hoTen"].HeaderText = "Họ và tên";
            dgv_nhanVien.Columns["hoTen"].Width = 150;
            dgv_nhanVien.Columns["dienThoai"].HeaderText = "Điện thoại";
            dgv_nhanVien.Columns["dienThoai"].Width = 150;
            dgv_nhanVien.Columns["soCMND"].HeaderText = "Số chứng minh nhân dân";
            dgv_nhanVien.Columns["soCMND"].Width = 170;
            dgv_nhanVien.Columns["soBaoHiemXH"].HeaderText = "Số bảo hiểm xã hội";
            dgv_nhanVien.Columns["soBaoHiemXH"].Width = 170;
            dgv_nhanVien.Columns["ngayVaoLam"].HeaderText = "Ngày vào làm";
            dgv_nhanVien.Columns["ngayVaoLam"].Width = 170;
            dgv_nhanVien.Columns["namSinh"].HeaderText = "Ngày sinh";
            dgv_nhanVien.Columns["namSinh"].Width = 170;
            dgv_nhanVien.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgv_nhanVien.Columns["gioiTinh"].Width = 170;
            dgv_nhanVien.Columns["email"].HeaderText = "Email";
            dgv_nhanVien.Columns["email"].Width = 170;
            dgv_nhanVien.Columns["tienCongMotNgay"].HeaderText = "Tiền công một ngày";
            dgv_nhanVien.Columns["tienCongMotNgay"].Width = 170;
            dgv_nhanVien.Columns["hinhAnh"].HeaderText = "Hình ảnh";
            dgv_nhanVien.Columns["hinhAnh"].Width = 170;
            dgv_nhanVien.Columns["DiaChi"].Visible = false;
            dgv_nhanVien.Columns["viTriCongViec"].HeaderText = "Vị trí công việc";
            dgv_nhanVien.Columns["viTriCongViec"].Width = 200;
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
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            frm_tinhLuongNhanVien tinhLuongNhanVien = new frm_tinhLuongNhanVien();
            tinhLuongNhanVien.ShowDialog();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frm_phanCongCongViec phanCongCongViec = new frm_phanCongCongViec();
            phanCongCongViec.ShowDialog();
        }

        private void frm_quanLyNhanVien_Load(object sender, EventArgs e)
        {
            dtmToday.Value = DateTime.Today;

            btnQuanLyNhanVien.Normalcolor = Color.FromArgb(39, 99, 109);
            if (listNhanVien == null)
            {
                BindingSourceNhanVien.DataSource = _nhanVien.GetAllList();
                dgv_nhanVien.DataSource = BindingSourceNhanVien;
                foreach (var item in _nhanVien.GetAllList())
                {
                    dataTable.Rows.Add(item.manhanVien, item.hoTen, item.dienThoai, item.soCMND, item.soBaoHiemXH, item.ngayVaolam, item.namSinh, item.gioiTinh, item.email, item.tienCongMotNgay, item.hinhAnh);
                }
                LoadDgvNhanVien();
            }
            else
            {
                dgv_nhanVien.DataSource = listNhanVien;
                LoadDgvNhanVien();
            }
        }
        private void dgv_nhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_nhanVien.CurrentRow != null)
            {
                int rowindex = dgv_nhanVien.CurrentRow.Index;
                if (rowindex >= 0)
                {
                    DataGridViewRow row = dgv_nhanVien.Rows[rowindex];
                    lbl_tenNhanVien.Text = row.Cells[1].Value.ToString();
                    dtm_namSinh.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    txt_gioiTinh.Text = row.Cells[8].Value.ToString();
                    txt_email.Text = row.Cells[9].Value.ToString();
                    txt_soDienThoai.Text = row.Cells[2].Value.ToString();
                    Image image = Image.FromFile(@"..\..\Images_nhanVien\" + row.Cells[7].Value.ToString());
                    pic_nhanVien.Image = image;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_nhanVien.DataSource = null;
            BUSNhanVien nv = new BUSNhanVien();
            dgv_nhanVien.DataSource = nv.GetAllList();
            LoadDgvNhanVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_timKiemNhanVien timKiemNhanVien = new frm_timKiemNhanVien();
            timKiemNhanVien.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_themNhanVien themNhanVien = new frm_themNhanVien();
            themNhanVien.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_nhanVien.SelectedRows.Count > 0)
            {
                string maNV = dgv_nhanVien.SelectedCells[0].Value.ToString();
                List<eNhanVien> list = _nhanVien.GetAllList();

                eNhanVien nv = list.Where(t => t.manhanVien.Equals(maNV)).SingleOrDefault();
                frm_suaNhanVien suaNhanVien = new frm_suaNhanVien(nv.manhanVien, nv.hoTen, nv.gioiTinh, nv.dienThoai, nv.email, nv.ngayVaolam, nv.namSinh, nv.soCMND, nv.soBaoHiemXH, nv.diaChi.maDiaChi, nv.diaChi.soNha, nv.diaChi.phuongXa, nv.diaChi.quanHuyen, nv.diaChi.thanhPho, nv.viTriCongViec);
                suaNhanVien.ShowDialog();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xuất file excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Export(dataTable, "Sheet1", "Danh sách nhân viên");
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

            cl1.Value2 = "Mã Nhân Viên";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");

            cl2.Value2 = "Tên nhân viên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Điện thoại";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl4.Value2 = "Số chứng minh nhân dân";

            cl4.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Số bảo hiểm xã hội";

            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");

            cl6.Value2 = "Ngày vào làm";

            cl6.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G2", "G2");

            cl7.Value2 = "Giới tính";

            cl7.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H2", "H2");

            cl8.Value2 = "Email";

            cl8.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I2", "I2");

            cl9.Value2 = "Tiền lương một ngày";

            cl9.ColumnWidth = 25.0;
            //Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J2", "J2");

            //cl10.Value2 = "Hinh Anh";

            //cl10.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "J2");

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

        private void logo_MouseHover(object sender, EventArgs e)
        {
            setTooltip(logo, "Bàn làm việc");
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
