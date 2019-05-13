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

        public object GetRoomPrice(string RoomType)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = connString;
            connection.Open();

            var command = new SqlCommand("TimGiaPhong", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaLoaiPhong", RoomType));

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

        public bool IsRentedRoom(string RoomID)
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

        public bool AddRoom(Dictionary<string, string> RoomData)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("ThemPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomData["RoomID"]));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", RoomData["RoomType"]));
                command.Parameters.Add(new SqlParameter("@TenTinhTrang", RoomData["RoomStatus"]));

                if (!string.IsNullOrWhiteSpace(RoomData["RoomNote"]))
                {
                    command.Parameters.Add(new SqlParameter("@GhiChu", RoomData["RoomNote"]));
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

        public bool EditRoom(Dictionary<string, string> RoomData)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connString;
                connection.Open();

                var command = new SqlCommand("SuaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhong", RoomData["RoomID"]));
                command.Parameters.Add(new SqlParameter("@MaLoaiPhong", RoomData["RoomType"]));
                command.Parameters.Add(new SqlParameter("@TenTinhTrang", RoomData["RoomStatus"]));

                if (!string.IsNullOrWhiteSpace(RoomData["RoomNote"]))
                {
                    command.Parameters.Add(new SqlParameter("@GhiChu", RoomData["RoomNote"]));
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
    }
}
