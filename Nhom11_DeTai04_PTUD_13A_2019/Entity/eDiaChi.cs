using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eDiaChi
    {
        public string maDiaChi { get; set; }
        public string soNha { get; set; }
        public string phuongXa { get; set; }
        public string quanHuyen { get; set; }
        public string thanhPho { get; set; }
        public eDiaChi()
        {

        }
        public eDiaChi(string maDiaChi, string soNha, string phuongXa, string quanHuyen, string thanhPho)
        {
            this.maDiaChi = maDiaChi;
            this.soNha = soNha;
            this.phuongXa = phuongXa;
            this.quanHuyen = quanHuyen;
            this.thanhPho = thanhPho;
        }
        public eDiaChi(string soNha, string phuongXa, string quanHuyen, string thanhPho)
        {

            this.soNha = soNha;
            this.phuongXa = phuongXa;
            this.quanHuyen = quanHuyen;
            this.thanhPho = thanhPho;
        }
    }
}
