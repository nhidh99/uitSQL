namespace DTO
{
    public class RoomStatusDTO
    {
        public string RoomStatusID { get; set; }
        public string RoomStatusName { get; set; }
        public RoomStatusDTO() { }

        public RoomStatusDTO(string RoomStatusID, string RoomStatusName)
        {
            this.RoomStatusID = RoomStatusID;
            this.RoomStatusName = RoomStatusName;
        }
    }
}
