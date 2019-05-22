namespace DTO
{
    public class RoomLeaseDetailDTO
    {
        public int LeaseID { get; set; }
        public string CustomerPassportID { get; set; }
        public int CustomerTypeID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public RoomLeaseDetailDTO() { }
        public RoomLeaseDetailDTO(string CustomerPassportID, int CustomerTypeID, string CustomerName, string CustomerAddress)
        {
            this.CustomerPassportID = CustomerPassportID;
            this.CustomerTypeID = CustomerTypeID;
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
        }
    }
}
