using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eTaiKhoan
    {
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public eTaiKhoan(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }
        public eTaiKhoan()
        {

        }
     
    }
}
