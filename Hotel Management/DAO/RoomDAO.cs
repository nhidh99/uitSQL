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

                var command = new SqlCommand("XoaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
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

                var command = new SqlCommand("KiemTraMaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
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

                var command = new SqlCommand("KiemTraPhongThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
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