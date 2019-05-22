using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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