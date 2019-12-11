using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContextBLO
    {
        protected QuanLyLaoDongDataContext db;
      
        //public DataContextBLO()
        //{
        //    db = new QuanLyLaoDongDataContext();
        //}

        //protected QuanLyLaoDongDataContext db_main_1;
        public DataContextBLO()
        {
            // db = new QuanLyLaoDongDataContext();
            db = new QuanLyLaoDongDataContext();

            //--------------------------------------------
            /*
            bool check = false;
            string connect = @"Data Source=DESKTOP-S8DEDHP\SQLEXPRESS;Initial Catalog=QLLaoDong;Integrated Security=True";
            string connect1 = @"Data Source = PC - TNTQ\TNTQ; Initial Catalog = QLLaoDong; Persist Security Info = True; User ID = sa";

            try
            {
                QuanLyLaoDongDataContext db_main = new QuanLyLaoDongDataContext(connect);
                db_main.Connection.Open();
                check = true;
                db = db_main;
                return;
            }
            catch (Exception)
            {

                check = false;
            }

            if (check == false)
            {
                try
                {
                    QuanLyLaoDongDataContext db1 = new QuanLyLaoDongDataContext(connect1);
                    db1.Connection.Open();
                    check = true;
                    db = db1;
                    return;
                }
                catch (Exception)
                {

                    check = false;
                }
               
            }*/
        }
    }
}
