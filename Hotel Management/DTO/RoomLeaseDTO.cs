using System;

namespace DTO
{
    class RoomLeaseDTO
    {
        public int LeaseID { get; set; }
        public string RoomID { get; set; }
        public string BillID { get; set; }
        public string LeaseDate { get; set; }
        public string RoomTypeID { get; set; }
        public Int64 RoomPrice { get; set; }
        public Int64 RoomCost { get; set; }

        public RoomLeaseDTO() { }
        public RoomLeaseDTO(string RoomID, string BillID,
            string LeaseDate, string RoomTypeID, Int64 RoomPrice, Int64 RoomCost)
        {
            this.RoomID = RoomID;
            this.BillID = BillID;
            this.LeaseDate = LeaseDate;
            this.RoomTypeID = RoomTypeID;
            this.RoomPrice = RoomPrice;
            this.RoomCost = RoomCost;
        }
    }
}
