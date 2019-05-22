namespace DTO
{
    public class RoomBillDTO
    {
        public int BillID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string BillDate { get; set; }
        public string BillCost { get; set; }
        public RoomBillDTO() { }
        public RoomBillDTO(string CustomerName, string CustomerAddress, string BillDate, string BillCost)
        {
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.BillDate = BillDate;
            this.BillCost = BillCost;
        }
    }
}
