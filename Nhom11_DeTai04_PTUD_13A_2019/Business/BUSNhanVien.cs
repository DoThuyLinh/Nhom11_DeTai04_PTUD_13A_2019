using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUSNhanVien
    {
        DALNhanVien dalNhanVien;
        public BUSNhanVien()
        {
            dalNhanVien = new DALNhanVien();
        }

        /// <summary>
        /// name: Quynh
        /// content: Them mot nhan vien moi
        /// </summary>
        public void AddItem(eNhanVien entity)
        {
            dalNhanVien.Add(entity);
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca nhan vien
        /// </summary>
        public List<eNhanVien> GetAllList()
        {
            return dalNhanVien.GetAll();
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem cac nhan vien theo yeu cau
        /// </summary>
        public List<eNhanVien> GetManyItemByCondition(Func<NhanVien, bool> lambda)
        {
            return dalNhanVien.GetManyByCondition(lambda);
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin nhan vien
        /// </summary>
        public void UpdateItem(eNhanVien entity)
        {
            dalNhanVien.Update(entity);
        }

        /// <summary>
        /// name: Tan
        /// content: Thong ke luong nhan vien theo thang
        /// </summary>
        public dynamic thongKeTheoThang(int thang, int nam) {
            return dalNhanVien.ThongKeNhanVienTheoThang(thang,nam);
        }

        /// <summary>
        /// name: Tan
        /// content: Thong ke luong nhan vien theo nam
        /// </summary>
        public dynamic thongKeTheoNam(int nam)
        {
            return dalNhanVien.ThongKeNhanVienTheoNam(nam);
        }
    }
}
