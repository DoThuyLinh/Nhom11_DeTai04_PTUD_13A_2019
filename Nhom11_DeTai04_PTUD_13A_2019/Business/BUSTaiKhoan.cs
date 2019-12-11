using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Business
{
    public class BUSTaiKhoan
    {
        DALTaiKhoan dalTaiKhoan;
        public BUSTaiKhoan()
        {
            dalTaiKhoan = new DALTaiKhoan();
        }

        /// <summary>
        /// name: Linh
        /// content: Truy xuat tai khoan va mat khau de truy cap vao he thong
        /// </summary>
        public eTaiKhoan GetAllList() {
            return dalTaiKhoan.getALL();
        }

        /// <summary>
        /// name: Linh
        /// content: Cap nhat mat khau truy cap
        /// </summary>
        public bool UpdateItem(eTaiKhoan entity)
        {
            if (dalTaiKhoan.Update(entity))
                return true;
            return false;
        }
    }
}
