using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RoomBillDAO : DBConnection
    {
        public static bool InsertRoomBill(RoomBillDTO bill)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemHoaDon", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TenKhach", bill.CustomerName));
                command.Parameters.Add(new SqlParameter("@DiaChi", bill.CustomerAddress));
                command.Parameters.Add(new SqlParameter("@NgayHoaDon", bill.BillDate));
                command.Parameters.Add(new SqlParameter("@TriGia", bill.BillCost));
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

        public static DataTable GetMonthRevenueReport(int month)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("BaoCaoDoanhThuThang", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Thang", month));
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

        public static DataTable GetLeasePayment(string roomID, string date)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("TimChiTietThanhToan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", roomID));
                command.Parameters.Add(new SqlParameter("@NgayThanhToan", date));
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

    }
}