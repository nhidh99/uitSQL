using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CustomerTypeDAO : DBConnection
    {
        public static DataTable GetCustomerTypeList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "SELECT MaLoaiKhach, TenLoaiKhach FROM LoaiKhach WHERE KhaDung = 1";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }

        public static bool InsertCustomerType(string customerType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemLoaiKhach", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TenLoaiKhach", customerType));
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }

            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public static bool UpdateCustomerType(string oldType, string newType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "UPDATE LoaiKhach\n" +
                    $"SET TenLoaiKhach = N'{newType}'\n" +
                    $"WHERE TenLoaiKhach = N'{oldType}'";

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public static bool DeleteCustomerType(string customerType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("XoaLoaiKhach", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TenLoaiKhach", customerType));
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }

            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public static bool CheckCustomerType(string customerType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"SELECT * FROM LoaiKhach\n" +
                    $"WHERE TenLoaiKhach = '{customerType} AND KhaDung = 1'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    connection.Close();
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public static string GetCustomerTypeByID(int typeID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"SELECT TenLoaiKhach FROM LoaiKhach WHERE MaLoaiKhach = {typeID}";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteScalar().ToString();
                connection.Close();
                return result;
            }
            catch (Exception)
            {
                connection.Close();
                return null;
            }
        }
    }
}
