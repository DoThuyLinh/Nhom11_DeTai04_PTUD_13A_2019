using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALCongViec : DataContextBLO
    {
        
        /// <summary>
        /// name: Quynh
        /// content: them cong viec moi
        /// </summary>
        public void Add(eCongViec cviec)
        {
            CongViec cv = new CongViec();
            cv.maDuAn = cviec.DuAn.MaDuAn;
            cv.ngayBatDau = cviec.NgayBatDau;
            cv.ngayKetThuc = cviec.NgayKetThuc;
            cv.tenCongViec = cviec.TenCongViec;
            cv.tienDoCongViec = cviec.Tiendo;
            cv.trangThai = cviec.TrangThai;
            cv.viTriCongViec = cviec.ViTriCongViec;

            db.CongViecs.InsertOnSubmit(cv);
            db.SubmitChanges();
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca cac cong viec trong csdl
        /// </summary>
        public List<eCongViec> GetAll()
        {
            List<eCongViec> list = (from cv in db.CongViecs
                                    join da in db.DuAns on cv.maDuAn equals da.maDuAn
                                    select new eCongViec
                                    {
                                        MaCongViec = cv.maCongViec,
                                         DuAn = new eDuAn(da.maDuAn,da.tenDuAn,null,da.ngayBatDau,da.ngayKetThuc,da.tienDoHoanThanh,da.trangThai),
                                         TenCongViec =cv.tenCongViec,
                                         NgayBatDau = cv.ngayBatDau,
                                         NgayKetThuc =cv.ngayKetThuc,
                                         Tiendo =cv.tienDoCongViec,
                                         TrangThai = cv.trangThai,
                                         ViTriCongViec = cv.viTriCongViec
                                    }
                                    ).ToList();

            //foreach (var item in db.CongViecs)
            //{
            //    list.Add(new eCongViec(item.maCongViec, item.DuAn.maDuAn, item.tenCongViec, item.ngayBatDau, item.ngayKetThuc, (int)item.tienDoCongViec, item.trangThai,item.viTriCongViec));
            //}
            return list;
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem cong viec theo yeu cau
        /// </summary>
        public List<eCongViec> GetManyByCondition(Func<eCongViec, bool> lambda)
        {
            List<eCongViec> query = db.DuAns// your starting point - table in the "from" statement
               .Join(db.CongViecs, // the source table of the inner join
                  da => da.maDuAn,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                  cv => cv.maDuAn,   // Select the foreign key (the second part of the "on" clause)
                  (da, cv) => new eCongViec
                  {
                      MaCongViec = cv.maCongViec,
                      DuAn = new eDuAn(da.maDuAn, da.tenDuAn, null, da.ngayBatDau, da.ngayKetThuc, da.tienDoHoanThanh, da.trangThai),
                      TenCongViec = cv.tenCongViec,
                      NgayBatDau = cv.ngayBatDau,
                      NgayKetThuc = cv.ngayKetThuc,
                      Tiendo = cv.tienDoCongViec,
                      TrangThai = cv.trangThai,
                      ViTriCongViec = cv.viTriCongViec
                  }) // selection
               .Where(lambda).ToList();    // where statement

            return query;
        }

        public eCongViec GetSingleByCondiditon(Func<eCongViec, bool> lambda)       {            

            eCongViec query = db.DuAns// your starting point - table in the "from" statement
               .Join(db.CongViecs, // the source table of the inner join
                  da => da.maDuAn,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                  cv => cv.maDuAn,   // Select the foreign key (the second part of the "on" clause)
                  (da, cv) => new eCongViec
                  {
                      MaCongViec = cv.maCongViec,
                      DuAn = new eDuAn(da.maDuAn, da.tenDuAn, null, da.ngayBatDau, da.ngayKetThuc, da.tienDoHoanThanh, da.trangThai),
                      TenCongViec = cv.tenCongViec,
                      NgayBatDau = cv.ngayBatDau,
                      NgayKetThuc = cv.ngayKetThuc,
                      Tiendo = cv.tienDoCongViec,
                      TrangThai = cv.trangThai,
                      ViTriCongViec = cv.viTriCongViec
                  }) // selection
               .Where(lambda).SingleOrDefault();    // where statement

            return query;

        }
        public eCongViec layCongViecTheoMa(string ma)
        {
            CongViec cv = db.CongViecs.Where(x => x.maCongViec.Equals(ma)).FirstOrDefault();

            if (cv != null) {
                eCongViec congviec = new eCongViec(cv.maCongViec, null, cv.tenCongViec, cv.ngayBatDau, cv.ngayKetThuc, cv.tienDoCongViec, cv.trangThai, cv.viTriCongViec);
                return congviec;
            }
            return null;
            
        }

        /// <summary>
        /// name: Quynh
        /// content: Cap nhat thong tin cua cong viec
        /// </summary>
        public void Update(eCongViec entity)
        {
            CongViec congViec = db.CongViecs.Where(t => t.maCongViec.Equals(entity.MaCongViec)).FirstOrDefault();

            congViec.tenCongViec = entity.TenCongViec;
            congViec.tienDoCongViec = entity.Tiendo;
            congViec.trangThai = entity.TrangThai;
            congViec.ngayBatDau = entity.NgayBatDau;
            congViec.ngayKetThuc = entity.NgayKetThuc;
            congViec.viTriCongViec = entity.ViTriCongViec;

            db.SubmitChanges();
        }
    }
}
