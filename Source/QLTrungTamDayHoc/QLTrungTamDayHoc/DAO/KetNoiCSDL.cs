using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.DAO
{

    public class KetNoiCSDL
    {
        public static SqlConnection conn;
        string _TenMay;
        string _TenCSDL;
        string _User;
        string _Pass;

        public string Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        public string TenCSDL
        {
            get { return _TenCSDL; }
            set { _TenCSDL = value; }
        }
        public string TenMay
        {
            get { return _TenMay; }
            set { _TenMay = value; }
        }


        public void KhoiTaoCNN()
        {
            //conn = new SqlConnection("Data Source=" + TenMay + ";Initial Catalog=" + TenCSDL + ";User ID=" + User + ";Password=" + Pass + "");
            conn = new SqlConnection("Data Source=BESNHI\\MSSQLSERVER1;Initial Catalog=QL_TT;Integrated Security=True");

        }
        public bool KiemTraKN(string pTenMay, string pTenCSDL, string pUser, string pPass)
        {
            this.TenCSDL = pTenCSDL;
            this.TenMay = pTenMay;
            this.User = pUser;
            this.Pass = pPass;

            KhoiTaoCNN();

            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
