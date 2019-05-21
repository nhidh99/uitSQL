using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class RoomBillDetailDTO
    {
        public int BillID { get; set; }
        public string CustomerPassportID { get; set; }
        public int CustomerTypeID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public RoomBillDetailDTO() { }
        public RoomBillDetailDTO(string CustomerPassportID, int CustomerTypeID, string CustomerName, string CustomerAddress)
        {
            this.CustomerPassportID = CustomerPassportID;
            this.CustomerTypeID = CustomerTypeID;
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
        }
    }
}
