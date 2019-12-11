using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eDuAn
    {
        
        private String maDuAn, tenDuAn;// maDiaChi, diaChi;
        private String trangThai;
        private DateTime ngayBatDau, ngayKetThuc;
        private int tienDo;
        eDiaChi diaChi;

        public string MaDuAn { get => maDuAn; set => maDuAn = value; }
        public string TenDuAn { get => tenDuAn; set => tenDuAn = value; }
        //public string MaDiaChi { get => maDiaChi; set => maDiaChi = value; }
        // public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int TienDo { get => tienDo; set => tienDo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public eDiaChi DiaChi { get => diaChi; set => diaChi = value; }

        public eDuAn()
        {

        }
        public eDuAn(String ma, String ten, eDiaChi diachi, DateTime ngaybatdau, DateTime ngayketthuc, int tiendo, String trangthai)
        {
            this.maDuAn = ma;
            this.tenDuAn = ten;
            this.diaChi = diachi;
            this.ngayBatDau = ngaybatdau;
            this.ngayKetThuc = ngayketthuc;
            this.tienDo = tiendo;
            this.trangThai = trangthai;
        }
    }
}
