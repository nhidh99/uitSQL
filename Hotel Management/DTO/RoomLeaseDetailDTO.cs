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
    }
}
