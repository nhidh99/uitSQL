using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{

    public class LoginDAO : DBConnection
    {
        public static int Login(string username, string password)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("DangNhap", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TenDangNhap", username));
                command.Parameters.Add(new SqlParameter("@MatKhau", password));
                var result = command.ExecuteScalar().ToString();
                connection.Close();
                if (result == "admin") return 1;
                else return 0;
            }
            catch
            {
                connection.Close();
                return -1;
            }
        }

    }

}