using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eCongViec
    {
        private string maCongViec, tenCongViec, trangThai, viTriCongViec;
        private eDuAn duAn;
        private DateTime ngayBatDau, ngayKetThuc;
        private int tiendo;

        public string MaCongViec { get => maCongViec; set => maCongViec = value; }
        public eDuAn DuAn { get => duAn; set => duAn = value; }
        public string TenCongViec { get => tenCongViec; set => tenCongViec = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int Tiendo { get => tiendo; set => tiendo = value; }
        public string ViTriCongViec { get => viTriCongViec; set => viTriCongViec = value; }

        public eCongViec()
        {

        }
        public eCongViec(String macongviec, eDuAn duAn, String tencongviec, DateTime ngaybatdau, DateTime ngayketthuc, int tiendo, String trangthai, string viTriCongViec)
        {
            this.maCongViec = macongviec;
            this.duAn = duAn;
            this.tenCongViec = tencongviec;
            this.ngayBatDau = ngaybatdau;
            this.ngayKetThuc = ngayketthuc;
            this.Tiendo = tiendo;
            this.trangThai = trangthai;
            this.ViTriCongViec = viTriCongViec;
        }
    }
}
