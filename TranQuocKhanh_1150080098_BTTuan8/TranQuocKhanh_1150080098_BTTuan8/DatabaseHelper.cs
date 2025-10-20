using System.Data.SqlClient;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public static class DatabaseHelper
    {
        private static string strCon = @"Data Source=LAPTOP-21NS4Q03\MSSQLSERVER2022;Initial Catalog=QuanLyBanSach;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;
        }
    }
}
