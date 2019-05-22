using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RoomStatusDAO : DBConnection
    {
        public static DataTable GetRoomStatusList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"SELECT * FROM TinhTrang";
                var command = new SqlCommand(query, connection);
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
    }
}