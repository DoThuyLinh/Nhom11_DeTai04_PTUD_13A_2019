using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eChamCong
    {
        private eNhanVien nhanvien;
        private eCongViec congViec;
        private int ngayCong;
        private DateTime ngayPC;
        private double luong;

        private string maNhanvien;
        private string maCongViec;


        public eNhanVien Nhanvien { get => nhanvien; set => nhanvien = value; }

        public eCongViec CongViec { get => congViec; set => congViec = value; }

        [ExcelColumn("Số lượng ngày công")]
        [DisplayName("Số lượng ngày công")]
        public int NgayCong { get => ngayCong; set => ngayCong = value; }

        [ExcelColumn("Ngày phân công")]
        [DisplayName("Ngày phân công")]
        public DateTime Daytime { get => ngayPC; set => ngayPC = value; }

        [ExcelColumn("Lương")]
        [DisplayName("Lương")]
        public double Luong { get => luong; set => luong = value; }
        [ExcelColumn("Mã nhân viên")]
        [DisplayName("Mã nhân viên")]
        public string MaNhanvien { get => maNhanvien; set => maNhanvien = value; }
        [DisplayName("Mã công việc")]
        [ExcelColumn("Mã công việc")]
        public string MaCongViec { get => maCongViec; set => maCongViec = value; }

        public double tinhluong(int ngaycong, int sotien)
        {
            return ngaycong * sotien;
        }
        public eChamCong()
        {

        }
        public eChamCong(eNhanVien nhanVien, eCongViec congViec, int songay, DateTime ngay, double _luong)
        {
            this.Nhanvien = nhanVien;
            this.CongViec = CongViec;
            this.maNhanvien = nhanVien.manhanVien;
            this.MaCongViec = congViec.MaCongViec;
            this.NgayCong = songay;
            this.ngayPC = ngay;
            this.Luong = _luong;

        }
    }
}
