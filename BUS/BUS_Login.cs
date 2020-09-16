using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Login
    {
        public static bool CheckLogin(DTO_Login DTOLogin,string check)
        {
            return DAL_Login.CheckLogin(DTOLogin,check);
        }
        public static List<DTO_Login> LoadPass(string id)
        {
            // Load Pass
            return DAL_Login.LoadPass(id);
        }
        public static bool CheckAuth(DTO_Login DTOLogin)
        {
            return DAL_Login.CheckAuth(DTOLogin);
        }
    }
}
