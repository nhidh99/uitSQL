using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RoomTypeDAO : DBConnection
    {
        public static DataTable GetRoomTypeList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("LietKeLoaiPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                connection.Close();
                return dt;
            }

            catch (Exception)
            {
                connection.Close();
                return null;
            }
        }

        public static string GetRoomTypeByID(string roomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("TimMaLoaiPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", roomID));

                var result = command.ExecuteScalar().ToString();
                connection.Close();
                return result;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }

        public static Int64 GetRoomPriceByID(string roomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("TimGiaTheoMaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", roomID));

                var price = Convert.ToInt64(command.ExecuteScalar());
                connection.Close();
                return price;
            }
            catch
            {
                connection.Close();
                return -1;
            }
        }

        public static Int64 GetRoomPriceByType(string roomType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("TimGiaTheoLoaiPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", roomType));

                var result = Convert.ToInt64(command.ExecuteScalar());
                connection.Close();
                return result;
            }
            catch
            {
                connection.Close();
                return -1;
            }
        }

    }
}
