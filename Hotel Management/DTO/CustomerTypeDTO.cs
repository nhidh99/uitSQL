using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CustomerTypeDTO
    {
        public int CustomerTypeID { get; set; }
        public string CustomerTypeName { get; set; }
        public bool CustomerTypeAvailable { get; set; }

        public CustomerTypeDTO() { }
        public CustomerTypeDTO(string CustomerTypeName, bool CustomerTypeAvailable)
        {
            this.CustomerTypeName = CustomerTypeName;
            this.CustomerTypeAvailable = CustomerTypeAvailable;
        }
    }
}
