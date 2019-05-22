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

                var command = new SqlCommand("LietKeLoaiKhach", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                connection.Close();

                var adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

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

                var command = new SqlCommand("TimTenLoaiKhachTheoMa", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaLoaiKhach", typeID));
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
