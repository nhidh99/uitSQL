using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class RoomBUS
    {
        public static DataTable GetRoomList()
        {
            return RoomDAO.GetRoomList();
        }

        public static DataTable GetAvailableRoomList()
        {
            return RoomDAO.GetAvailableRoomList();
        }

        public static bool InsertRoom(RoomDTO room)
        {
            if (RoomDAO.CheckRoomByID(room.RoomID) || string.IsNullOrWhiteSpace(room.RoomID))
            {
                return false;
            }
            return RoomDAO.InsertRoom(room);
        }

        public static bool DeleteRoom(string RoomID)
        {
            if (RoomDAO.CheckRentedRoomByID(RoomID))
            {
                return false;
            }
            return RoomDAO.DeleteRoom(RoomID);
        }

        public static bool UpdateRoom(RoomDTO room)
        {
            if (RoomDAO.CheckRentedRoomByID(room.RoomID))
            {
                return false;
            }
            return RoomDAO.UpdateRoom(room);
        }

        public static DataTable FindRoom(string id, string type, Int64 price, string status)
        {
            return RoomDAO.FindRoom(id, type, price, status);
        }
    }
}