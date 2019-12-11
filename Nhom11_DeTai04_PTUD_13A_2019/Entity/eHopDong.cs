using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eHopDong
    {
        public string maHopDong { get; set; }
        public eDuAn duAn { get; set; }
        public string tenHopDong { get; set; }
        public DateTime ngayKyKet { get; set; }
        public double giaTriHopDong { get; set; }
        public DateTime ngayHetHan { get; set; }
        public string thongTin { get; set; }
        public eHopDong()
        {

        }
        public eHopDong(string maHopDong, eDuAn duAn, string tenHopDong, DateTime ngayKyKet, double giaTriHopDong, DateTime ngayHetHan, string thongTin)
        {
            this.maHopDong= maHopDong ;
            this.duAn= duAn;
            this.tenHopDong= tenHopDong;
            this.ngayKyKet= ngayKyKet;
            this.ngayHetHan= ngayHetHan;
            this.giaTriHopDong=giaTriHopDong;
            this.thongTin= thongTin;
        }
    }
}
