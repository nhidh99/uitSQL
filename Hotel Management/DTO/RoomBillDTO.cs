using System;

namespace DTO
{
    public class RoomBillDTO
    {
        public int BillID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string BillDate { get; set; }
        public Int64 BillCost { get; set; }
        public RoomBillDTO() { }
    }
}
