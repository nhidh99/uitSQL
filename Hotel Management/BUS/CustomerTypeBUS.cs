using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerTypeBUS
    {
        public static DataTable GetCustomerTypeList()
        {
            return CustomerTypeDAO.GetCustomerTypeList();
        }

        public static string GetCustomerTypeByID(int typeID)
        {
            return CustomerTypeDAO.GetCustomerTypeByID(typeID);
        }
    }
}