using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace Business
{
    public class BUSChamCong
    {
         DALChamCong dalChamCong;
        public BUSChamCong()
        {
            dalChamCong = new DALChamCong();
        }

        /// <summary>
        /// name: Tan
        /// content: them bang cham cong
        /// </summary>
        public Boolean themChamCong(eChamCong cc) {
            return dalChamCong.themChamCong(cc);
        }
        public List<eChamCong> GetManyItemByCondition(string maNhanVien)
        {
            return dalChamCong.getManyByCondition(maNhanVien);
        }
    }
}
