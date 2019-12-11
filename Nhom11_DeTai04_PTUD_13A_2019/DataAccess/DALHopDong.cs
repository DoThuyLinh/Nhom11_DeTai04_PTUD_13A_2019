using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALHopDong : DataContextBLO
    {

        /// <summary>
        /// name: Quynh
        /// content: Them mot hop dong moi
        /// </summary>
        public void Add(eHopDong entity)
        {
            HopDong hd = new HopDong();
            hd.maDuAn = entity.duAn.MaDuAn;
            hd.ngayHetHan = entity.ngayHetHan;
            hd.ngayKyKet = entity.ngayKyKet;
            hd.tenHopDong = entity.tenHopDong;
            hd.thongTin = entity.thongTin;
            hd.giaTriHopDong = (decimal)entity.giaTriHopDong;

            db.HopDongs.InsertOnSubmit(hd);
            db.SubmitChanges();
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach hop dong trong co so du lieu
        /// </summary>
        public List<eHopDong> GetAll()
        {
            List<eHopDong> list = new List<eHopDong>();
            foreach (var item in db.HopDongs)
            {
                list.Add(new eHopDong(item.maHopDong, new eDuAn(item.DuAn.maDuAn,item.DuAn.tenDuAn,null,item.DuAn.ngayBatDau,item.DuAn.ngayKetThuc,item.DuAn.tienDoHoanThanh,item.DuAn.trangThai), item.tenHopDong, (DateTime)item.ngayKyKet, (double)item.giaTriHopDong, (DateTime)item.ngayHetHan, item.thongTin));
            }
            return list;
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem hop dong theo yeu cau
        /// </summary>
        public List<eHopDong> GetManyByCondition(Func<HopDong, bool> lambda)
        {
            List<eHopDong> list = new List<eHopDong>();
            foreach (var item in db.HopDongs.Where(lambda).ToList())
            {
                list.Add(new eHopDong(item.maHopDong, new eDuAn(item.DuAn.maDuAn, item.DuAn.tenDuAn, null, item.DuAn.ngayBatDau, item.DuAn.ngayKetThuc, item.DuAn.tienDoHoanThanh, item.DuAn.trangThai), item.tenHopDong,(DateTime)item.ngayKyKet, (long)item.giaTriHopDong, (DateTime)item.ngayHetHan,item.thongTin));
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin hop dong
        /// </summary>
        public void Update(eHopDong entity)
        {
            HopDong hd = db.HopDongs.Where(t => t.maHopDong.Equals(entity.maHopDong)).SingleOrDefault();
            hd.ngayHetHan = entity.ngayHetHan;
            hd.ngayKyKet = entity.ngayKyKet;
            hd.tenHopDong = entity.tenHopDong;
            hd.thongTin = entity.thongTin;
            hd.giaTriHopDong = (decimal)entity.giaTriHopDong;

            db.SubmitChanges();
        }
    }
}
