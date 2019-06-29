using DAO;
using DTO;
using System;
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

        public static bool InsertCustomerType(string customerType)
        {
            if (CustomerTypeDAO.CheckCustomerType(customerType))
            {
                return false;
            }
            return CustomerTypeDAO.InsertCustomerType(customerType);
        }

        public static bool DeleteCustomerType(string customerType)
        {
            return CustomerTypeDAO.DeleteCustomerType(customerType);
        }

        public static bool UpdateCustomerType(string oldType, string newType)
        {
            if (CustomerTypeDAO.CheckCustomerType(newType))
            {
                return false;
            }
            return CustomerTypeDAO.UpdateCustomerType(oldType, newType);
        }
    }
}