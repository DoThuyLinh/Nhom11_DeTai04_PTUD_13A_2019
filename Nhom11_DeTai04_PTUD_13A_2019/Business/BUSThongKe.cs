using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.DataProcessing;

namespace Business
{
    public class BUSThongKe
    {
        DALThongKe tk;
        public BUSThongKe()
        {
            tk = new DALThongKe();
        }


        public void SLNhanVienTuADenB(string tenduan, string fromday, string today, ReportViewer reportViewer)
        {
            tk.SLNhanVienTuADenB(tenduan, fromday, today, reportViewer);
        }
        public void TongSLNhanVien(string tenduan, ReportViewer reportViewer)
        {
            tk.TongSLNhanVien(tenduan, reportViewer);
        }

        public void TongSoCongViecTuADenB(string tenduan, string fromday, string today, ReportViewer reportViewer)
        {
            tk.TongSoCongViecTuADenB(tenduan, fromday, today, reportViewer);
        }
        public void BCCVTheoTienDo(string tenduan, string tiendo, ReportViewer reportViewer)
        {
            tk.BCCVTheoTienDo(tenduan, tiendo, reportViewer);
        }
        public void TongSoCongViec(string tenduan, ReportViewer reportViewer)
        {
            tk.TongSoCongViec(tenduan, reportViewer);
        }
        public void LuongChiTraTrongDuAnTheoThang(string nam, string thang, ReportViewer reportViewer)
        {
            tk.LuongChiTraTrongDuAnTheoThang(nam, thang, reportViewer);
        }
        public void LuongChiTraTrongDuAnTheoNam(string nam, ReportViewer reportViewer)
        {
            tk.LuongChiTraTrongDuAnTheoNam(nam, reportViewer);
        }
        public void TongLuongChiTraTrongDuAn(string tenduan, ReportViewer reportViewer)
        {
            tk.TongLuongChiTraTrongDuAn(tenduan, reportViewer);
        }
    }
}
