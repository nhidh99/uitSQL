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
                return dt;
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
                return dt;
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

        public static bool UpdateMaxCustomerInRoom(int num)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "UPDATE ThamSo\n" +
                    $"SET GiaTri = {num}\n" +
                    "WHERE MaThamSo = 'KHTD'";

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
                return result;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
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
                return status;
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
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool CheckRoomByID(string RoomID)
        {
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
                    return true;
                }
                else return false;
            }

            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool CheckRentedRoomByID(string RoomID)
        {
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
                    return true;
                }
                else return false;
            }

            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}