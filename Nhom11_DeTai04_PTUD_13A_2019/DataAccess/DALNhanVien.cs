using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALNhanVien : DataContextBLO
    {
        /// <summary>
        /// name: Quynh
        /// content: Them mot nhan vien moi
        /// </summary>
        public void Add(eNhanVien entity)
        {
            ThemNV nv = new ThemNV(); // View them Nhan Vien
            nv.dienThoai = entity.dienThoai;
            nv.tienCongMotNgay = (decimal)entity.tienCongMotNgay;
            nv.email = entity.email;
            nv.gioiTinh = entity.gioiTinh;
            nv.hinhAnh = entity.hinhAnh;
            nv.hoTen = entity.hoTen;
            nv.namSinh = entity.namSinh;
            nv.ngayVaolam = entity.ngayVaolam;
            nv.phuongXa = entity.diaChi.phuongXa;
            nv.quanHuyen = entity.diaChi.quanHuyen;
            nv.soBaoHiemXH = entity.soBaoHiemXH;
            nv.soCMND = entity.soCMND;
            nv.soNha = entity.diaChi.soNha;
            nv.thanhPho = entity.diaChi.thanhPho;
            nv.viTriCongViec = entity.viTriCongViec;
            
            db.ThemNVs.InsertOnSubmit(nv);
            db.SubmitChanges();
        }

        /// <summary>
        /// name: Quynh
        /// content: Lay tat ca nhan vien trong co so du lieu
        /// </summary>
        public List<eNhanVien> GetAll()
        {
            List<eNhanVien> list = (from nv in db.NhanViens
                                    join dc in db.DiaChis on nv.maDiaChi equals dc.maDiaChi
                                    select new eNhanVien
                                    {
                                        manhanVien = nv.maNhanVien,
                                        hoTen = nv.hoTen,
                                        dienThoai = nv.dienThoai,
                                        soCMND = nv.soCMND,
                                        soBaoHiemXH = nv.soBaoHiemXH,
                                        ngayVaolam = nv.ngayVaolam,
                                        namSinh = nv.namSinh,
                                        hinhAnh = nv.hinhAnh,
                                        gioiTinh = nv.gioiTinh,
                                        email = nv.email,
                                        diaChi = new eDiaChi(dc.maDiaChi, dc.soNha, dc.phuongXa, dc.quanHuyen, dc.thanhPho),
                                        tienCongMotNgay = (double)nv.tienCongMotNgay,
                                        viTriCongViec = nv.viTriCongViec
                                        
                                    }).ToList();
            return list;
        }

        /// <summary>
        /// name: Linh
        /// content: Tim kiem cac nhan vien theo yeu cau
        /// </summary>
        public List<eNhanVien> GetManyByCondition(Func<NhanVien, bool> lambda)
        {
            List<eNhanVien> list = new List<eNhanVien>();
            List<NhanVien> listNV = db.NhanViens.Where(lambda).ToList();
            foreach (var item in listNV)
            {
                list.Add(new eNhanVien(item.maNhanVien, item.hoTen, item.dienThoai, item.soCMND, item.soBaoHiemXH, item.ngayVaolam, item.namSinh, item.hinhAnh, item.gioiTinh, item.email, null, (int)item.tienCongMotNgay, item.viTriCongViec));
            }
            return list;
        }

        /// <summary>
        /// name: Quynh
        /// content: Chinh sua thong tin nhan vien
        /// </summary>
        public void Update(eNhanVien entity)
        {
            NhanVien nv = db.NhanViens.Where(t => t.maNhanVien.Equals(entity.manhanVien)).SingleOrDefault();
            nv.hoTen = entity.hoTen;
            nv.gioiTinh = entity.gioiTinh;
            nv.dienThoai = entity.dienThoai;
            nv.email = entity.email;
            nv.ngayVaolam = entity.ngayVaolam;
            nv.soCMND = entity.soCMND;
            nv.soBaoHiemXH = entity.soBaoHiemXH;
            nv.viTriCongViec = entity.viTriCongViec;
            nv.hinhAnh = entity.hinhAnh;

            db.SubmitChanges();
            
            DiaChi dc = db.DiaChis.Where(t => t.maDiaChi.Equals(entity.diaChi.maDiaChi)).SingleOrDefault();

            dc.soNha = entity.diaChi.soNha;
            dc.phuongXa = entity.diaChi.phuongXa;
            dc.quanHuyen = entity.diaChi.quanHuyen;
            dc.thanhPho = entity.diaChi.thanhPho;

            db.SubmitChanges();
        }

        /// <summary>
        /// name: Tan
        /// content: Thong ke luong nhan vien theo thang
        /// </summary>
        public dynamic ThongKeNhanVienTheoThang(int thang, int nam)
        {
            dynamic list = (from nv in db.NhanViens
                            join ccnv in db.ChamCongNhanViens on nv.maNhanVien equals ccnv.maNhanVien
                            join cv in db.CongViecs on ccnv.maCongViec equals cv.maCongViec
                            join da in db.DuAns on cv.maDuAn equals da.maDuAn
                            where ccnv.ngayChamCong.Month == thang && ccnv.ngayChamCong.Year == nam
                            select new
                            {
                                tenNV = nv.hoTen,
                                tenCV = cv.tenCongViec,
                                luong = ccnv.luong,
                                ngayChamCong = ccnv.ngayChamCong,
                                tenDuAn = da.tenDuAn
                            }).ToList();
            return list;
        }

        /// <summary>
        /// name: Tan
        /// content: Thong ke luong nhan vien theo nam
        /// </summary>
        public dynamic ThongKeNhanVienTheoNam(int nam)
        {
            dynamic list1 = (from nv in db.NhanViens
                            join ccnv in db.ChamCongNhanViens on nv.maNhanVien equals ccnv.maNhanVien
                            join cv in db.CongViecs on ccnv.maCongViec equals cv.maCongViec
                            join da in db.DuAns on cv.maDuAn equals da.maDuAn
                            where ccnv.ngayChamCong.Year == nam
                            select new
                            {
                                tenNV = nv.hoTen,
                                tenCV = cv.tenCongViec,
                                luong = ccnv.luong,
                                ngayChamCong = ccnv.ngayChamCong,
                                tenDuAn = da.tenDuAn
                            }).ToList();
            return list1;
        }
    }
}
