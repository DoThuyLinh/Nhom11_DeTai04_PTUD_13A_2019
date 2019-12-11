using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eNhanVien
    {
        public string manhanVien { get; set; }
        public string hoTen { get; set; }
        public string dienThoai { get; set; }
        public string soCMND { get; set; }
        public string soBaoHiemXH { get; set; }
        public DateTime ngayVaolam { get; set; }
        public DateTime namSinh { get; set; }
        public string hinhAnh { get; set; }
        public string gioiTinh { get; set; }
        public string email { get; set; }
        public eDiaChi diaChi { get; set; }
        public double tienCongMotNgay { get; set; }
        public string viTriCongViec { get; set; }

        public eNhanVien()
        {

        }
        public eNhanVien(string manhanVien, string hoTen, string dienThoai, string soCMND, string soBaoHiemXH, DateTime ngayVaolam, DateTime namSinh, string hinhAnh, string gioiTinh, string email, eDiaChi diaChi, double tienCongMotNgay, string viTriCongViec)
        {
            this.manhanVien = manhanVien;
            this.hoTen = hoTen;
            this.dienThoai = dienThoai;
            this.soCMND = soCMND;
            this.soBaoHiemXH = soBaoHiemXH;
            this.ngayVaolam = ngayVaolam;
            this.namSinh = namSinh;
            this.hinhAnh = hinhAnh;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.diaChi = diaChi;
            this.tienCongMotNgay = tienCongMotNgay;
            this.viTriCongViec = viTriCongViec;
        }
    }
}
