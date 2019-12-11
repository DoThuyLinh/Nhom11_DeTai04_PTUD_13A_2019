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
    public partial class frm_phanCongCongViec : Form
    {
        BUSNhanVien _nhanVien;
        BUSCongViec _congViec;
        private static System.Data.DataTable dataTable;
        List<eNhanVien> listNhanVien;
        
        public frm_phanCongCongViec()
        {
            _nhanVien = new BUSNhanVien();
            _congViec = new BUSCongViec();
            InitializeComponent();
        }
        
        public void BeginTable()
        {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã nhân viên");
            dataTable.Columns.Add("Họ và tên");
            dataTable.Columns.Add("Mã công việc");
            dataTable.Columns.Add("Tên công việc");
            dataTable.Columns.Add("Số lượng ngày công");
            dataTable.Columns.Add("Ngày phân công");
        }
        public void LoadDgvPhanCong()
        {
            dgv_phanCong.ColumnCount = 6;
            dgv_phanCong.Columns[0].HeaderText = "Mã nhân viên";
            dgv_phanCong.Columns[0].Width = 100;
            dgv_phanCong.Columns[1].HeaderText = "Họ và tên";
            dgv_phanCong.Columns[1].Width = 150;
            dgv_phanCong.Columns[2].HeaderText = "Mã công việc";
            dgv_phanCong.Columns[2].Width = 100;
            dgv_phanCong.Columns[3].HeaderText = "Tên công việc";
            dgv_phanCong.Columns[3].Width = 200;
            dgv_phanCong.Columns[4].HeaderText = "Số lượng ngày công";
            dgv_phanCong.Columns[4].Width = 170;
            dgv_phanCong.Columns[5].HeaderText = "Ngày phân công";
            dgv_phanCong.Columns[5].Width = 170;
        }
        public void LoadPhanCongNhanVien()
        {
            string CheckedItemsString = "";
            string[] arrNhanVien;
            string[] arrCongViec = cbo_congViec.Text.Split('-');
            string[] row;
            LoadDgvPhanCong();

            foreach (object checkbox in clb_nhanVien.CheckedItems)
            {
                CheckedItemsString = checkbox.ToString();
                arrNhanVien = CheckedItemsString.Split('-');
                row = new string[] { arrNhanVien[0], arrNhanVien[1], arrCongViec[0], arrCongViec[1], "0", DateTime.Now.ToString() };
                //all.Rows.Add(row);
                dgv_phanCong.Rows.Add(row);

            }         
        }


        private void frm_phanCongCongViec_Load(object sender, EventArgs e)
        {
            this.Location = new Point(55, 42);

            var congViec = cbo_congViec.Items;
            List<eCongViec> listCongViec = _congViec.GetAllList();
            cbo_congViec.Text = listCongViec.ElementAt(0).MaCongViec +" - "+ listCongViec.ElementAt(0).TenCongViec;
            List<eNhanVien> listNV = _nhanVien.GetManyItemByCondition(x => x.viTriCongViec.Equals(listCongViec.ElementAt(0).ViTriCongViec));
            var item = clb_nhanVien.Items;
            foreach (eNhanVien nv in listNV)
            {
                item.Add(nv.manhanVien + "-" + nv.hoTen);
            }
            foreach (eCongViec cv in listCongViec)
            {
                if (cv.Tiendo < 100)
                {
                    congViec.Add(cv.MaCongViec + " - " + cv.TenCongViec);
                }
            }
            cbo_congViec.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_congViec.AutoCompleteSource = AutoCompleteSource.ListItems;  
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            LoadPhanCongNhanVien();
            foreach (int i in clb_nhanVien.CheckedIndices)
            {
                clb_nhanVien.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnXoaPhanCong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgv_phanCong.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dgv_phanCong.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            BeginTable();
            List<dynamic> datadgv = new List<dynamic>();
            for (int i = 0; i < dgv_phanCong.Rows.Count; i++)
            {
                dataTable.Rows.Add(dgv_phanCong.Rows[i].Cells[0].Value.ToString(),dgv_phanCong.Rows[i].Cells[1].Value.ToString(),dgv_phanCong.Rows[i].Cells[2].Value.ToString(),dgv_phanCong.Rows[i].Cells[3].Value.ToString(),dgv_phanCong.Rows[i].Cells[4].Value.ToString(), DateTime.Now.ToShortDateString());
            }
            Export(dataTable,"Sheet1", "Bảng phân công tháng "+ DateTime.Now.Month.ToString());
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

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");

            cl2.Value2 = "Tên nhân viên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");

            cl3.Value2 = "Mã công việc";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");

            cl4.Value2 = "Tên công việc";

            cl4.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");

            cl5.Value2 = "Số lượng ngày công";

            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");

            cl6.Value2 = "Ngày phân công";

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

        private void cbo_congViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            clb_nhanVien.Items.Clear();

            string[] arrCongViec = cbo_congViec.Text.Split('-');

            string maCongViec = arrCongViec[0].Trim();
            eCongViec congViec = _congViec.GetSingleItemByCondiditon(x => x.MaCongViec == maCongViec);
            listNhanVien = _nhanVien.GetManyItemByCondition(x => x.viTriCongViec == congViec.ViTriCongViec);

            var item = clb_nhanVien.Items;
            foreach (eNhanVien nv in listNhanVien)
            {
                item.Add(nv.manhanVien + "-" + nv.hoTen);
            }
        }
    }
}
