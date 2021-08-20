using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI
{
    public class DBConnection
    {
        public static SqlConnection sqlConnect()
        {
            String sqlConnectStr = "Data Source=DESKTOP-9RHI76C;Initial Catalog=QUANLYTASK_TTTN;User ID=sa;Password=123456";
            SqlConnection conn = new SqlConnection(sqlConnectStr);
            return conn;
        }
    }
}
