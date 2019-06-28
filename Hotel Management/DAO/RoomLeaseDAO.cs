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
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateForeignCustomerTaxPercent(int num)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "UPDATE ThamSo\n" +
                    $"SET GiaTri = CAST({num} AS FLOAT) / 100\n" +
                    "WHERE MaThamSo = 'PTNN'";

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

        public static bool UpdateOverCustomerTaxPercent(int num)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = "UPDATE ThamSo\n" +
                    $"SET GiaTri = CAST({num} AS FLOAT) / 100\n" +
                    "WHERE MaThamSo = 'PTK3'";

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
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connection.Close();
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
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                connection.Close();
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

        public static int GetOverCustomerTaxPercent()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var query = "SELECT GiaTri * 100 FROM ThamSo WHERE MaThamSo = 'PTK3'";
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

        public static int GetForeignCustomerTaxPercent()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var query = "SELECT GiaTri * 100 FROM ThamSo WHERE MaThamSo = 'PTNN'";
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
    }
}