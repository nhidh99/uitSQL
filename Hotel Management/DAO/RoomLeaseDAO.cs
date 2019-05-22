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

        public static int GetLastLeaseIDOfRoom(string RoomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("TimMaPhieuGanNhat", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
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