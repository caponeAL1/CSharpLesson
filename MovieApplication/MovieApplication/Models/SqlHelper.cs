using Microsoft.Data.SqlClient;

namespace MovieApplication.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2719\SQLEXPRESS01;database = testDB;integrated security = true;Encrypt = false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
