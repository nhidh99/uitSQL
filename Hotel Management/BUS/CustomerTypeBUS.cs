using DAO;
using System.Data;

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