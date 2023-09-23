using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2719\SQLEXPRESS01; database=TestDB; integrated security=true; Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
