using DAO;
using System;
using System.Data;

namespace BUS
{
    public class RoomTypeBUS
    {
        public static DataTable GetRoomTypeList()
        {
            return RoomTypeDAO.GetRoomTypeList();
        }

        public static string GetRoomTypeByID(string RoomID)
        {
            return RoomTypeDAO.GetRoomTypeByID(RoomID);
        }

        public static Int64 GetRoomPriceByID(string RoomID)
        {
            return RoomTypeDAO.GetRoomPriceByID(RoomID);
        }

        public static Int64 GetRoomPriceByType(string RoomType)
        {
            return RoomTypeDAO.GetRoomPriceByType(RoomType);
        }

        public static DataTable GetRoomPriceList()
        {
            return RoomTypeDAO.GetRoomPriceList();
        }
    }
}
