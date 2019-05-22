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

                var query = "SELECT MaLoaiPhong FROM LoaiPhong";
                var command = new SqlCommand(query, connection);
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

        public static DataTable GetRoomPriceList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "SELECT DISTINCT(DonGia) FROM LoaiPhong ORDER BY DonGia";
                var command = new SqlCommand(query, connection);
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
                var query = $"SELECT MaLoaiPhong FROM Phong WHERE MaPhong = '{roomID}'";
                var command = new SqlCommand(query, connection);
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
                var query = $"SELECT DonGia FROM LoaiPhong WHERE MaLoaiPhong = '{roomType}'";
                var command = new SqlCommand(query, connection);
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
