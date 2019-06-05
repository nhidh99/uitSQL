using DAO;

namespace BUS
{
    public class LoginBUS
    {
        public static int Login(string username, string password)
        {
            return LoginDAO.Login(username, password);
        }
    }
}
