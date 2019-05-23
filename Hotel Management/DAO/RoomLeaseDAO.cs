using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RoomLeaseDAO : DBConnection
    {
        public static bool InsertRoomLease(RoomLeaseDTO lease)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemPhieuThuePhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", lease.RoomID));
                command.Parameters.Add(new SqlParameter("@NgayThue", lease.LeaseDate));
                command.Parameters.Add(new SqlParameter("@LoaiPhong", lease.RoomTypeID));
                command.Parameters.Add(new SqlParameter("@DonGia", lease.RoomPrice));
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException)
            {
                connection.Close();
                return false;
            }
        }

        public static bool InsertRoomLeasePayment(string roomID, Int64 price)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemThongTinThanhToan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", roomID));
                command.Parameters.Add(new SqlParameter("@ThanhTien", price));
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException)
            {
                connection.Close();
                return false;
            }
        }

        public static DataTable GetRentedRoomList(string date)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("LietKePhongThue", connection);
                command.Parameters.Add(new SqlParameter("@NgayThanhToan", date));
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (SqlException)
            {
                connection.Close();
                return null;
            }
        }

        public static int GetLastLeaseIDOfRoom(string RoomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "SELECT TOP 1 MaPhieu FROM PhieuThue\n" +
                    $"WHERE MaPhong = '{RoomID}'\n" +
                    "ORDER BY MaPhieu DESC";

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

    }
}