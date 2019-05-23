using DAO;
using DTO;

namespace BUS
{
    public class RoomLeaseDetailBUS
    {
        public static bool InsertDetail(RoomLeaseDetailDTO detail)
        {
            return RoomLeaseDetailDAO.InsertDetail(detail);
        }
    }
}