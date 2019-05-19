using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management
{
    class SqlExecuter
    {
        public string connString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=QuanLiKhachSan;Integrated Security=True";

        public DataTable GetRoomData()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKeDanhMucPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetRoomTypeData()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKeLoaiPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetRoomStatusData()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKeTinhTrangPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetRoomPriceData()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKeDonGiaPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetAvailableRoomData()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKePhongTrong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetAvailableCustomerType()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

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

        public DataTable GetFoundRoom(Dictionary<string,string> room)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TraCuuPhong", connection);
            command.CommandType = CommandType.StoredProcedure;

            if (room["ID"] != "Tất cả phòng")
            {
                command.Parameters.Add(new SqlParameter("@MaPhong", room["ID"]));
            }

            if (room["Type"] != "Tất cả loại phòng")
            {
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", room["Type"]));
            }

            if (room["Price"] != "Tất cả đơn giá")
            {
                command.Parameters.Add(new SqlParameter("DonGia", room["Price"]));
            }

            if (room["Status"] != "Tất cả tình trạng")
            {
                command.Parameters.Add(new SqlParameter("@TenTinhTrang", room["Status"]));
            }

            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetRentRoom(string BillDate)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("LietKePhongThue", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@NgayThanhToan", BillDate));
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetPayInformation(string RoomID, string BillDate)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimChiTietThanhToan", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
            command.Parameters.Add(new SqlParameter("@NgayThanhToan", BillDate));
            command.ExecuteNonQuery();
            connection.Close();

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public object GetMaxCustomersInRoom()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimSoKhachToiDa", connection);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public object GetRoomPriceByType(string RoomType)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimGiaTheoLoaiPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaLoaiPhong", RoomType));

            var price = command.ExecuteScalar();
            connection.Close();
            return price;
        }

        public object GetRoomPriceByRoomID(string RoomID)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimGiaTheoMaPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));

            var price = command.ExecuteScalar();
            connection.Close();
            return price;
        }

        public object GetRoomStatus(string RoomID)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimTinhTrangPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));

            var status = command.ExecuteScalar();
            connection.Close();
            return status;
        }

        public object GetRoomType(string RoomID)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimMaLoaiPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));

            var status = command.ExecuteScalar();
            connection.Close();
            return status;
        }

        public bool CheckRentedRoom(string RoomID)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("KiemTraPhongThue", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
            bool isRented = ((int)command.ExecuteScalar() == 1);
            connection.Close();
            return isRented;
        }

        public object GetLastNoteIDByRoomID(string RoomID)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimMaPhieuGanNhat", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
            var result = command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public bool DeleteRoom(string RoomID)
        {
            try
            {
                var connection = new SqlConnection();
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("XoaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddRoom(Dictionary<string, string> room)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", room["ID"]));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", room["Type"]));
                command.Parameters.Add(new SqlParameter("@TenTinhTrang", room["Status"]));

                if (!string.IsNullOrWhiteSpace(room["Note"]))
                {
                    command.Parameters.Add(new SqlParameter("@GhiChu", room["Note"]));
                }
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

        public bool EditRoom(Dictionary<string, string> room)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("SuaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", room["ID"]));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", room["Type"]));
                command.Parameters.Add(new SqlParameter("@TenTinhTrang", room["Status"]));

                if (!string.IsNullOrWhiteSpace(room["Note"]))
                {
                    command.Parameters.Add(new SqlParameter("@GhiChu", room["Note"]));
                }
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

        public bool AddNoteRoom(Dictionary<string, string> room)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemPhieuThuePhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", room["ID"]));
                command.Parameters.Add(new SqlParameter("@NgayThue", room["Date"]));
                command.Parameters.Add(new SqlParameter("@LoaiPhong", room["Type"]));
                command.Parameters.Add(new SqlParameter("@DonGia", room["Price"]));
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

        public bool AddCustomerInNoteRoom(int NoteID, Dictionary<string,string> customer)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemChiTietPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhieu", NoteID));
                command.Parameters.Add(new SqlParameter("@CMND", customer["PassportID"]));
                command.Parameters.Add(new SqlParameter("@TenKhach", customer["Name"]));
                command.Parameters.Add(new SqlParameter("@TenLoaiKhach", customer["Type"]));
                command.Parameters.Add(new SqlParameter("@DiaChi", customer["Address"]));
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

        public bool AddBill(Dictionary<string,string> payer, string TotalPrice)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemHoaDonThanhToan", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TenKhach", payer["Name"]));
                command.Parameters.Add(new SqlParameter("@DiaChi", payer["Address"]));
                command.Parameters.Add(new SqlParameter("@NgayHoaDon", payer["BillDate"]));
                command.Parameters.Add(new SqlParameter("@TriGia", TotalPrice));

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

        public bool PayRoom(string RoomID, string TotalPrice)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemThongTinThanhToan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomID));
                command.Parameters.Add(new SqlParameter("@ThanhTien", TotalPrice));

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
    }
}
