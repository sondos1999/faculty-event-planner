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
        public static OracleConnection getConnection()
        {
            if (conn == null)
            {
                conn = new OracleConnection(constr);
                conn.Open();
            }
            return conn;
        }
    }
}
