namespace DTO
{
    public class RoomDTO
    {
        public string RoomID { get; set; }
        public string RoomStatusID { get; set; }
        public string RoomTypeID { get; set; }
        public string RoomNote { get; set; }

        public RoomDTO() { }
        public RoomDTO(string RoomID, string RoomStatusID, string RoomTypeID, string RoomNote)
        {
            this.RoomID = RoomID;
            this.RoomStatusID = RoomStatusID;
            this.RoomTypeID = RoomTypeID;
            this.RoomNote = RoomNote;
        }
    }
}