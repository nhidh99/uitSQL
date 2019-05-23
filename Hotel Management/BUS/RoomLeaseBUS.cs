using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class RoomLeaseBUS
    {
        public static bool InsertRoomLease(RoomLeaseDTO lease)
        {
            return RoomLeaseDAO.InsertRoomLease(lease);
        }

        public static bool InsertRoomLeasePayment(string roomID, Int64 price)
        {
            return RoomLeaseDAO.InsertRoomLeasePayment(roomID, price);
        }

        public static int GetLastLeaseIDOfRoom(string RoomID)
        {
            return RoomLeaseDAO.GetLastLeaseIDOfRoom(RoomID);
        }

        public static DataTable GetRentedRoomList(string date)
        {
            return RoomLeaseDAO.GetRentedRoomList(date);
        }
    }
}