using System;

namespace DTO
{
    public class RoomLeaseDTO
    {
        public int LeaseID { get; set; }
        public string RoomID { get; set; }
        public string BillID { get; set; }
        public string LeaseDate { get; set; }
        public string RoomTypeID { get; set; }
        public Int64 RoomPrice { get; set; }
        public Int64 RoomCost { get; set; }
        public RoomLeaseDTO() { }
    }
}
