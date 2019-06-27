using System.Data.SqlClient;

namespace DAO
{
    public class DBConnection
    {
        protected static SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS01;Initial Catalog=QuanLiKhachSan;Integrated Security=True");
    }
}