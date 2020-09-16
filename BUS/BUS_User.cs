using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_User
    {
        public static List<DTO_User> loaduser(string id)
        {
            // Load Class
            return DAL_User.loaduser(id);
        }
    }
}
