using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALDuAn : DataContextBLO
    {

        /// <summary>
        /// name: Quynh
        /// content: Them mot du an moi
        /// </summary>
        public void Add(eDuAn entity)
        {
            ThemDuAn da = new ThemDuAn();
            da.tenDuAn = entity.TenDuAn;
            da.ngayBatDau = entity.NgayBatDau;
            da.ngayKetThuc = entity.NgayKetThuc;
            da.tienDoHoanThanh = entity.TienDo;
            da.trangThai = entity.TrangThai;
            da.soNha = entity.DiaChi.soNha;
            da.phuongXa = entity.DiaChi.phuongXa;
            da.quanHuyen = entity.DiaChi.quanHuyen;
            da.ThanhPho = entity.DiaChi.thanhPho;

            db.ThemDuAns.InsertOnSubmit(da);
            db.SubmitChanges();
        }

        /// <summary>
        /// name: Linh
        /// content: Lay danh sach tat ca cac du an co trong co so du lieu
        /// </summary>
        public List<eDuAn> GetAll()
        {
            //List<eDuAn> list = new List<eDuAn>();
            //foreach (var item in db.DuAns)
            //{
            //    list.Add(new eDuAn(item.maDuAn, item.tenDuAn, null, (DateTime)item.ngayBatDau, (DateTime)item.ngayKetThuc, (int)item.tienDoHoanThanh, item.trangThai));
            //}
            //return list;
            List<eDuAn> list = (from da in db.DuAns
                                join dc in db.DiaChis on da.maDiaChi equals dc.maDiaChi
                                select new eDuAn
                                {
                                    MaDuAn = da.maDuAn,
                                    TenDuAn = da.tenDuAn,
                                    DiaChi = new eDiaChi(dc.maDiaChi, dc.soNha, dc.phuongXa, dc.quanHuyen, dc.thanhPho),
                                    NgayBatDau = (DateTime)da.ngayBatDau,
                                    NgayKetThuc = (DateTime)da.ngayKetThuc,
                                    TienDo = (int)da.tienDoHoanThanh,
                                    TrangThai = da.trangThai

                                }).ToList();
            return list;
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem du an theo yeu cau
        /// </summary>
        public List<eDuAn> GetManyByCondition(Func<DuAn, bool> lambda)
        {
            List<eDuAn> list = new List<eDuAn>();
            foreach (var item in db.DuAns.Where(lambda).ToList())
            {
                list.Add(new eDuAn(item.maDuAn, item.tenDuAn,null, (DateTime)item.ngayBatDau, (DateTime)item.ngayKetThuc, (int)item.tienDoHoanThanh, item.trangThai));
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: Tim kiem 1 du an theo yeu cau
        /// </summary>
        public eDuAn GetItemyByCondition(Func<eDuAn, bool> lambda)
        {
            eDuAn duAn = db.DuAns.Join(
                                  db.DiaChis,
                                  da => da.maDiaChi,
                                  dc => dc.maDiaChi, 
                                  (da, dc) => new eDuAn { DiaChi = new eDiaChi(dc.maDiaChi, dc.soNha, dc.phuongXa, dc.quanHuyen, dc.thanhPho),
                                                          MaDuAn = da.maDuAn,
                                                          NgayBatDau = da.ngayBatDau,
                                                          NgayKetThuc = da.ngayKetThuc,
                                                          TenDuAn = da.tenDuAn,
                                                          TienDo = da.tienDoHoanThanh,
                                                          TrangThai = da.trangThai
                                                          
                                  })
                        .Where(lambda).SingleOrDefault();
            return duAn;
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin cua du an trong co so du lieu
        /// </summary>
        public void Update(eDuAn entity)
        {
            DuAn da = db.DuAns.Where(t => t.maDuAn.Equals(entity.MaDuAn)).SingleOrDefault();
            da.tenDuAn = entity.TenDuAn;
            da.ngayBatDau = entity.NgayBatDau;
            da.ngayKetThuc = entity.NgayKetThuc;
            da.tienDoHoanThanh = entity.TienDo;
            da.trangThai = entity.TrangThai;

            db.SubmitChanges();

            DiaChi dc = db.DiaChis.Where(t => t.maDiaChi.Equals(entity.DiaChi.maDiaChi)).SingleOrDefault();
            dc.soNha = entity.DiaChi.soNha;
            dc.phuongXa = entity.DiaChi.phuongXa;
            dc.quanHuyen = entity.DiaChi.quanHuyen;
            dc.thanhPho = entity.DiaChi.thanhPho;

            db.SubmitChanges();
        }
    }
}
