using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                var query = "SELECT * FROM LoaiKhach WHERE KhaDung = 1";
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
