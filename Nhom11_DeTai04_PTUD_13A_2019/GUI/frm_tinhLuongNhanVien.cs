using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;
using LinqToExcel;

namespace GUI
{
    public partial class frm_tinhLuongNhanVien : Form
    {
        BUSNhanVien _nhanVien;
        BUSChamCong _chamCong;
        BUSCongViec _congViec;
        private static System.Data.DataTable dataTable;
        public frm_tinhLuongNhanVien()
        {
            
            InitializeComponent();
            _nhanVien = new BUSNhanVien();
            _chamCong = new BUSChamCong();
            _congViec = new BUSCongViec();
            BeginTable();

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
        public void LoadDgvBangLuong()
        {
            dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            if (of.FileName != "")
            {
                string file = of.FileName;

                string ext = Path.GetExtension(file);
                List<eNhanVien> list = _nhanVien.GetAllList();

                if (ext.ToLower() == ".xls" || ext.ToLower().Equals(".xlsx"))
                {
                    var excel = new ExcelQueryFactory(file);
                    var chamCong = from nv in excel.Worksheet<eChamCong>("Sheet1")
                                   select nv;


                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add("Mã Nhân Viên");
                    dt.Columns.Add("Mã Công Việc");
                    dt.Columns.Add("Số Ngày Công");
                    dt.Columns.Add("Lương");

                    foreach (eChamCong item in chamCong)
                    {
                        eCongViec cv = _congViec.getCVTheoMa(item.MaCongViec);
                        foreach (var item1 in list)
                        {
                           
                           
                            if (item1.manhanVien.Equals(item.MaNhanvien))
                            {
                                dt.Rows.Add(item1.manhanVien, item.MaCongViec, item.NgayCong, item.tinhluong(item.NgayCong, (int)item1.tienCongMotNgay));

                                if (_chamCong.themChamCong(new eChamCong(new eNhanVien(item1.manhanVien, item1.hoTen, item1.dienThoai,
                                    item1.soCMND, item1.soBaoHiemXH, item1.ngayVaolam, item1.namSinh, item1.hinhAnh,
                                    item1.gioiTinh, item1.email, item1.diaChi, item1.tienCongMotNgay,
                                    item1.viTriCongViec)
                                    , new eCongViec(cv.MaCongViec, cv.DuAn, cv.TenCongViec, cv.NgayBatDau,
                                    cv.NgayKetThuc, cv.Tiendo, cv.TrangThai, cv.ViTriCongViec),
                                    item.NgayCong,
                                    DateTime.Now,
                                    item.tinhluong(item.NgayCong, (int)item1.tienCongMotNgay))))
                                {


                                }
                            }
                        }
                    }
                    dt.AcceptChanges();
                    LoadDgvBangLuong();
                    dgvBangLuong.DataSource = dt;
                }
            }
        }

        private void frm_tinhLuongNhanVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);
            List<eNhanVien> listNhanVien = _nhanVien.GetAllList();
            foreach (var item in listNhanVien)
            {
                cboNhanVien.Items.Add(item.manhanVien + " - " + item.hoTen);

            }
            cboNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgvBangLuong.DataSource = null;
        //    string[] arrNhanVien = cboNhanVien.Text.Split('-');
        //    List<eChamCong> listChamCong = _chamCong.GetManyItemByCondition(arrNhanVien[0].Trim());
        //    List<eNhanVien> listNhanVien = _nhanVien.GetAllList();
        //    //
        //    if (dgvBangLuong.items > 0)
        //    {
        //        LoadDgvBangLuong();
        //        dgvBangLuong.DataSource = listChamCong;

        //        foreach (eChamCong item in listChamCong)
        //        {
        
        //            foreach (var item1 in listNhanVien)
        //            {

        //                if (item1.manhanVien.Equals(arrNhanVien[0].Trim()))
        //                {
        //                    dataTable.Rows.Add(item1.manhanVien, item.MaCongViec, item.NgayCong, item.tinhluong(item.NgayCong, (int)item1.tienCongMotNgay));
        //                }
        //            }
        //        }
        //    }
        //}

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xuất file excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Export(dataTable, "Sheet", "Bảng Lương Nhân Viên " + cboNhanVien.Text);
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

            cl2.Value2 = "Mã Công Việc";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Số Ngày Công";

            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl3.Value2 = "Ngày Phân Công";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Lương";

            cl5.ColumnWidth = 50.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "E2");

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
    }
}
