using DAO;
using System.Data;

namespace BUS
{
    public class RoomStatusBUS
    {
        public static DataTable GetRoomStatusList()
        {
            return RoomStatusDAO.GetRoomStatusList();
        }
    }
}
