using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Data;
using Microsoft.ReportingServices.DataProcessing;


namespace DataAccess
{
    public class DALThongKe:DataContextBLO
    {
        QuanLyLaoDongDataContext db;
        string connect = @"Data Source=DESKTOP-S8DEDHP\SQLEXPRESS;Initial Catalog=QLLaoDong;Integrated Security=True";
        string connect1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLLaoDong;Integrated Security=True";
        public DALThongKe()
        {
            db = new QuanLyLaoDongDataContext();
        }

        public void BCCVTheoTienDo(string tenduan, string tiendo, ReportViewer reportViewer)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;
            con.ConnectionString = db.Connection.ConnectionString;

            SqlCommand cmd = new SqlCommand();
            if (!tiendo.Equals("Trễ tiến độ"))
            {
                //truyền vào trên store procedure trong sql 
                cmd.CommandText = "BCCongViecTheoTienDo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {

                    try
                    {
                        cmd.Connection = con;
                    }
                    catch (Exception)
                    {


                    }
                }
                // truyền parameter từ form vào store procedure
                cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));
                cmd.Parameters.Add(new SqlParameter("@tinhtrangcv", tiendo));

                // khởi tạo dataset để chứa dữ liệu
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
                // thiết lập báo cáo
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.LocalReport.ReportPath = "Report1.rdlc";
                // gán dữ liệu vào báo cáo 
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                //gán dữ liệu báo cáo lên report viewer
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(rds);
                reportViewer.RefreshReport();
            }
            else
            {
                cmd.CommandText = "BCCVTreTienDo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {

                    try
                    {
                        cmd.Connection = con;
                    }
                    catch (Exception)
                    {


                    }
                }
                cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));
                cmd.Parameters.Add(new SqlParameter("@ngayhientai", DateTime.Now));
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.LocalReport.ReportPath = "Report1.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(rds);
                reportViewer.RefreshReport();
            }
        }
        public void TongSoCongViecTuADenB(string tenduan, string fromday, string today, ReportViewer reportViewer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;
            con.ConnectionString = db.Connection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TongSoCongViecTuADenB";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));
            cmd.Parameters.Add(new SqlParameter("@fromday", fromday));
            cmd.Parameters.Add(new SqlParameter("@today", today));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }
        public void TongSoCongViec(string tenduan, ReportViewer reportViewer)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TongSoCongViec";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {

                   
                }
            }
            cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));


            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }



        public void SLNhanVienTuADenB(string tenduan, string fromday, string today, ReportViewer reportViewer)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            con.ConnectionString = db.Connection.ConnectionString;
            con.ConnectionString = connect;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SLNhanVienTuADenB";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));
            cmd.Parameters.Add(new SqlParameter("@fromday", fromday));
            cmd.Parameters.Add(new SqlParameter("@today", today));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report2.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }

        public void TongSLNhanVien(string tenduan, ReportViewer reportViewer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            con.ConnectionString = db.Connection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TongSLNhanVien";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report2.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }
        public void LuongChiTraTrongDuAnTheoNam(string nam, ReportViewer reportViewer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            con.ConnectionString = db.Connection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LuongChiTraTrongDuAnTheoNam";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@nam", nam));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report4.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }
        public void LuongChiTraTrongDuAnTheoThang(string nam, string thang, ReportViewer reportViewer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            con.ConnectionString = db.Connection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LuongChiTraTrongDuAnTheoThang";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@nam", nam));
            cmd.Parameters.Add(new SqlParameter("@thang", thang));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report3.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }
        public void TongLuongChiTraTrongDuAn(string tenduan, ReportViewer reportViewer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;

            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = connect1;

            con.ConnectionString = db.Connection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LuongChiTraTrongDuAn";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Connection = con;
            }
            catch (Exception)
            {

                try
                {
                    cmd.Connection = con;
                }
                catch (Exception)
                {


                }
            }
            cmd.Parameters.Add(new SqlParameter("@tenduan", tenduan));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "Report5.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }



    }
}
