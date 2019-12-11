using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccess
{
    public class DALChamCong:DataContextBLO
    {

        /// <summary>
        /// name: Tan
        /// content: them bang cham cong
        /// </summary>
        public Boolean themChamCong(eChamCong chamcong)
        {
            try
            {
                ChamCongNhanVien cc = new ChamCongNhanVien();
                cc.maNhanVien = chamcong.Nhanvien.manhanVien;
                cc.maCongViec = chamcong.CongViec.MaCongViec;
                cc.soNgayCong = chamcong.NgayCong;
                cc.ngayChamCong = chamcong.Daytime;
                cc.luong = (decimal) chamcong.Luong;
                
                db.ChamCongNhanViens.InsertOnSubmit(cc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<eChamCong> getManyByCondition(string maNhanVien)
        {
            List<eChamCong> listCC = (from nv in db.NhanViens
                                     join cc in db.ChamCongNhanViens on nv.maNhanVien equals cc.maNhanVien
                                     join cv in db.CongViecs on cc.maCongViec equals cv.maCongViec
                                     select new eChamCong{ 
                                       Nhanvien =   new eNhanVien(nv.maNhanVien,nv.hoTen,nv.dienThoai,nv.soCMND,nv.soBaoHiemXH,nv.ngayVaolam,nv.namSinh,nv.hinhAnh,nv.gioiTinh,nv.email,null,(double)nv.tienCongMotNgay,nv.viTriCongViec),
                                       CongViec = new eCongViec(cv.maCongViec,null,cv.tenCongViec,cv.ngayBatDau,cv.ngayKetThuc,cv.tienDoCongViec,cv.trangThai,cv.viTriCongViec),
                                       NgayCong = cc.soNgayCong,
                                       Daytime = cc.ngayChamCong,
                                       Luong = (double)cc.luong
                                     }).ToList();

            return listCC;
        }
    }
}
