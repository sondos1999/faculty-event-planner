using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FacultyEventPlanner
{
    class OracleHelper
    {
        private static OracleConnection conn;
        static string constr = "Data Source=orcl; User Id=hr;Password=hr;";
        public struct user
        {
            public string user_name, fName, lName, e_mail, did, jid;
        }
        public static user LoggedIn;
        public static OracleConnection getConnection()
        {
            if (conn == null)
            {
                conn = new OracleConnection(constr);
                conn.Open();
            }
            return conn;
        }

        public static void closeConnection()
        {
            if (conn != null)
                conn.Close();
        }
    }
}
