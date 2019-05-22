using DAO;
using DTO;

namespace BUS
{
    public class RoomLeaseBUS
    {
        public static bool InsertRoomLease(RoomLeaseDTO lease)
        {
            return RoomLeaseDAO.InsertRoomLease(lease);
        }

        public static int GetLastLeaseIDOfRoom(string RoomID)
        {
            return RoomLeaseDAO.GetLastLeaseIDOfRoom(RoomID);
        }
    }
}