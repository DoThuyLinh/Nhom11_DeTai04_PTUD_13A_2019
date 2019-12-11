using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALDiaChi : DataContextBLO
    {

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac tinh/thanh pho trong co so du lieu
        /// </summary>
        public List<eThanhPho> getAllThanhPho()
        {
            var listTam = db.ThanhPhos.ToList();
            List<eThanhPho> list = new List<eThanhPho>();

            foreach (ThanhPho i in listTam)
            {
                eThanhPho tp = new eThanhPho();
                tp.ThanhPho = i.thanhPho1;
                tp.MaThanhPho = i.maThanhPho;
                list.Add(tp);
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac quan huyen theo tinh/thanhpho
        /// </summary>
        public List<eQuanHuyen> getAllQuanHuyenTheoTP(string maTP)
        {
            var listTam = db.QuanHuyens.Where(t => t.maThanhPho.Equals(maTP)).ToList();
            List<eQuanHuyen> list = new List<eQuanHuyen>();

            foreach (QuanHuyen i in listTam)
            {
                eQuanHuyen qh = new eQuanHuyen();
                qh.MaThanhPho = i.maThanhPho;
                qh.MaQuanHuyen = i.maQuanHuyen;
                qh.QuanHuyen = i.quanHuyen1;

                list.Add(qh);
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac phuong xa theo quan/huyen
        /// </summary>
        public List<ePhuongXa> getAllPhuongXaTheoQH(string maQH)
        {
            var listTam = db.PhuongXas.Where(t => t.maQuanHuyen.Equals(maQH)).ToList();
            List<ePhuongXa> list = new List<ePhuongXa>();

            foreach (PhuongXa i in listTam)
            {
                ePhuongXa px = new ePhuongXa();
                px.PhuongXa = i.phuongXa1;
                px.MaQuanHuyen = i.maQuanHuyen;
                px.PhuongXa = i.phuongXa1;

                list.Add(px);
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: them mot dia moi
        /// </summary>
        public bool themDiaChi(eDiaChi diaChi) {
            try
            {
                DiaChi dc = new DiaChi();
                dc.maDiaChi = diaChi.maDiaChi;
                dc.soNha = diaChi.soNha;
                dc.quanHuyen = diaChi.quanHuyen;
                dc.thanhPho = diaChi.thanhPho;
                dc.phuongXa = diaChi.phuongXa;
                db.DiaChis.InsertOnSubmit(dc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }          
            
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay danh sach tat ca cac dia chi trong co so du lieu
        /// </summary>
        public List<eDiaChi> getallDiaChi() {
            List<eDiaChi> list = new List<eDiaChi>();
            foreach (var item in db.DiaChis)
            {
                list.Add(new eDiaChi(item.maDiaChi, item.soNha, item.phuongXa, item.quanHuyen, item.thanhPho));
            }
            return list;
        }
    }
}
