using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RoomDAO : DBConnection
    {
        public static DataTable GetRoomList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("LietKeDanhMucPhong", connection);
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

        public static DataTable GetAvailableRoomList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "SELECT MaPhong FROM Phong\n" +
                    "WHERE MaTinhTrang = 'PHTR'\n" +
                    "AND MaLoaiPhong IS NOT NULL";

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

        public static int GetMaxCustomerInRoom()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var query = "SELECT GiaTri FROM ThamSo WHERE MaThamSo = 'KHTD'";
                var command = new SqlCommand(query, connection);
                var result = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return result;
            }
            catch
            {
                connection.Close();
                return -1;
            }
        }

        public static string GetRoomStatusByID(string roomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("TimTinhTrangPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", roomID));

                var status = command.ExecuteScalar().ToString();
                connection.Close();
                return status;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }

        public static DataTable FindRoom(string id, string type, Int64 price, string status)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("TraCuuPhong", connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@MaPhong", id));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", type));
                command.Parameters.Add(new SqlParameter("@MaTinhTrang", status));

                if (price != -1)
                {
                    command.Parameters.Add(new SqlParameter("@DonGia", price));
                }

                command.ExecuteNonQuery();
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();
                return dt;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }

        public static bool UpdateRoom(RoomDTO room)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("SuaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", room.RoomID));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", room.RoomTypeID));
                command.Parameters.Add(new SqlParameter("@MaTinhTrang", room.RoomStatusID));

                if (!string.IsNullOrWhiteSpace(room.RoomNote))
                {
                    command.Parameters.Add(new SqlParameter("GhiChu", room.RoomNote));
                }

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public static bool DeleteRoom(string RoomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"DELETE Phong WHERE MaPhong = '{RoomID}'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public static bool InsertRoom(RoomDTO room)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", room.RoomID));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", room.RoomTypeID));
                command.Parameters.Add(new SqlParameter("@MaTinhTrang", room.RoomStatusID));

                if (!string.IsNullOrWhiteSpace(room.RoomNote))
                {
                    command.Parameters.Add(new SqlParameter("GhiChu", room.RoomNote));
                }

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public static bool CheckRoomByID(string RoomID)
        {
            bool result = false;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"SELECT * FROM Phong WHERE MaPhong = {RoomID}";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
            }
            return result;
        }

        public static bool CheckRentedRoomByID(string RoomID)
        {
            bool result = false;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"SELECT * FROM Phong " +
                    $"WHERE MaPhong = {RoomID} " +
                    $"AND MaTinhTrang = 'PHTH'";

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
            }
            return result;
        }
    }
}