using System;

namespace DTO
{
    class RoomTypeDTO
    {
        public string RoomTypeID { get; set; }
        public Int64 RoomTypePrice { get; set; }

        public RoomTypeDTO() { }
        public RoomTypeDTO(string roomTypeID, Int64 roomTypePrice)
        {
            this.RoomTypeID = roomTypeID;
            this.RoomTypePrice = roomTypePrice;
        }
    }
}
