using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUSCongViec
    {
        DALCongViec dalCongViec;
        public BUSCongViec()
        {
            dalCongViec = new DALCongViec();
        }

        /// <summary>
        /// name: Quynh
        /// content: them cong viec moi
        /// </summary>
        public void AddItem(eCongViec entity)
        {
            dalCongViec.Add(entity);
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca cac cong viec trong csdl
        /// </summary>
        public List<eCongViec> GetAllList()
        {
            return dalCongViec.GetAll();
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem cong viec theo yeu cau
        /// </summary>
        public List<eCongViec> GetManyItemByCondition(Func<eCongViec, bool> lambda)
        {
            return dalCongViec.GetManyByCondition(lambda);
        }


        public eCongViec GetSingleItemByCondiditon(Func<eCongViec, bool> lambda)
        {
            return dalCongViec.GetSingleByCondiditon(lambda);
        }
        /// <summary>
        /// name: Quynh
        /// content: Cap nhat thong tin cua cong viec
        /// </summary>
        public void UpdateItem(eCongViec entity)
        {
            dalCongViec.Update(entity);
        }
        public eCongViec getCVTheoMa(string ma)
        {
            return dalCongViec.layCongViecTheoMa(ma);
        }
      
    }
}
