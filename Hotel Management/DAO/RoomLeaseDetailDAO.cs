using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class RoomLeaseDetailDAO : DBConnection
    {
        public static bool InsertDetail(RoomLeaseDetailDTO detail)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("ThemChiTietPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaPhieu", detail.LeaseID));
                command.Parameters.Add(new SqlParameter("@CMND", detail.CustomerPassportID));
                command.Parameters.Add(new SqlParameter("@TenKhach", detail.CustomerName));
                command.Parameters.Add(new SqlParameter("@MaLoaiKhach", detail.CustomerTypeID));
                command.Parameters.Add(new SqlParameter("@DiaChi", detail.CustomerAddress));
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
    }
}
