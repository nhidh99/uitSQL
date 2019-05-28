using DAO;
using DTO;
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

        public static int CountRoomWithType(string roomTypeID)
        {
            return RoomTypeDAO.CountRoomWithTypeID(roomTypeID);
        }

        public static bool InsertRoomType(RoomTypeDTO roomType)
        {
            if (RoomTypeDAO.CheckRoomTypeID(roomType.RoomTypeID))
            {
                return false;
            }
            return RoomTypeDAO.InsertRoomType(roomType);
        }

        public static bool DeleteRoomType(string roomTypeID)
        {
            return RoomTypeDAO.DeleteRoomType(roomTypeID);
        }

        public static bool UpdateRoomType(RoomTypeDTO roomType)
        {
            return RoomTypeDAO.UpdateRoomType(roomType);
        }
    }
}