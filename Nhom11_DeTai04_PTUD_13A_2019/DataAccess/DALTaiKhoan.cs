using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataAccess
{

    public class DALTaiKhoan:DataContextBLO
    {
        /// <summary>
        /// name: Linh
        /// content: Truy xuat tai khoan va mat khau de truy cap vao he thong
        /// </summary>
        public eTaiKhoan getALL() {
            eTaiKhoan tk = new eTaiKhoan();
            TaiKhoan taiKhoan = db.TaiKhoans.FirstOrDefault();
            tk.taiKhoan = taiKhoan.taiKhoan1;
            tk.matKhau = taiKhoan.matKhau;
            return tk;
        }
        /// <summary>
        /// name: Linh
        /// content: Cap nhat mat khau truy cap
        /// </summary>
        public bool Update(eTaiKhoan entity)
        {
            try
            {
                TaiKhoan taiKhoan = db.TaiKhoans.FirstOrDefault();

                taiKhoan.matKhau = entity.matKhau;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
