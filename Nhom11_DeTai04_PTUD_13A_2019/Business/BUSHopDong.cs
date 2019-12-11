using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUSHopDong
    {
        DALHopDong dalHopDong;
        public BUSHopDong()
        {
            dalHopDong = new DALHopDong();
        }

        /// <summary>
        /// name: Quynh
        /// content: Them mot hop dong moi
        /// </summary>
        public void AddItem(eHopDong entity)
        {
            dalHopDong.Add(entity);
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca cac hop dong
        /// </summary>
        public List<eHopDong> GetAllList()
        {
            return dalHopDong.GetAll();
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem hop dong theo yeu cau
        /// </summary>
        public List<eHopDong> GetManyItemByCondition(Func<HopDong, bool> lambda)
        {
            return dalHopDong.GetManyByCondition(lambda);
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin hop dong
        /// </summary>
        public void UpdateItem(eHopDong entity)
        {
            dalHopDong.Update(entity);
        }
    }
}
