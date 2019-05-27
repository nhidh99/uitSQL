using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class RoomBillBUS
    {
        public static bool InsertBill(RoomBillDTO bill)
        {
            return RoomBillDAO.InsertRoomBill(bill);
        }

        public static DataTable GetLeasePayment(string roomID, string date)
        {
            return RoomBillDAO.GetLeasePayment(roomID, date);
        }

        public static DataTable GetMonthRevenueReport(int month)
        {
            return RoomBillDAO.GetMonthRevenueReport(month);
        }
    }
}
