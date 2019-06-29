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

                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
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
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                    $"WHERE TenLoaiKhach = N'{customerType}' AND KhaDung = 1";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return result;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
