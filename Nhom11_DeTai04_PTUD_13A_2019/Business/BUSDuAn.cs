using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUSDuAn
    {
        DALDuAn dalDuAn;
        public BUSDuAn()
        {
            dalDuAn = new DALDuAn();
        }

        /// <summary>
        /// name: Quynh
        /// content: Them mot du an moi
        /// </summary>
        public void AddItem(eDuAn entity)
        {
            dalDuAn.Add(entity);
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca cac du an co trong co so du lieu
        /// </summary>
        public List<eDuAn> GetAllList()
        {
            return dalDuAn.GetAll();
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem du an theo yeu cau
        /// </summary>
        public List<eDuAn> GetManyItemByCondition(Func<DuAn, bool> lambda)
        {
            return dalDuAn.GetManyByCondition(lambda);
        }

        /// <summary>
        /// name: Quynh
        /// content: Tim kiem 1 du an theo yeu cau
        /// </summary>
        public eDuAn GetItemByCondition(Func<eDuAn, bool> lambda)
        {
            return dalDuAn.GetItemyByCondition(lambda);
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin cua du an trong co so du lieu
        /// </summary>
        public void UpdateItem(eDuAn entity)
        {
            dalDuAn.Update(entity);
        }
    }
}
