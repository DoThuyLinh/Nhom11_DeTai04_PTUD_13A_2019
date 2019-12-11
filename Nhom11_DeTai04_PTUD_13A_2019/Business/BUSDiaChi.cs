using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUSDiaChi
    {
        DALDiaChi dalDiaChi;
        public BUSDiaChi()
        {
            dalDiaChi = new DALDiaChi();
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac tinh/thanh pho trong co so du lieu
        /// </summary>
        public List<eThanhPho> getAllThanhPho()
        {
            return dalDiaChi.getAllThanhPho();
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac quan huyen theo tinh/thanhpho
        /// </summary>
        public List<eQuanHuyen> getAllQuanHuyen(string maTP)
        {
            return dalDiaChi.getAllQuanHuyenTheoTP(maTP);
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac phuong xa theo quan/huyen
        /// </summary>
        public List<ePhuongXa> getAllPhuongXa(string maQH)
        {
            return dalDiaChi.getAllPhuongXaTheoQH(maQH);
        }

        /// <summary>
        /// name: Quynh
        /// content: them mot dia moi
        /// </summary>
        public bool insertDiaChi(eDiaChi diachi) {
            return dalDiaChi.themDiaChi(diachi);
        }
      
    }
}
