using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_RegisterSubject
    {
        public static List<DTO_RegisterSubject> loadregister(string id)
        {
            // Load Class
            return DAL_RegisterSubject.loadregister(id);
        }
        public static bool CheckDup(DTO_RegisterSubject DTORegisterSubject)
        {
            return DAL_RegisterSubject.CheckDup(DTORegisterSubject);
        }
        public static bool InsertScore(DTO_RegisterSubject DTORegisterSubject)
        {
            return DAL_RegisterSubject.InsertScore(DTORegisterSubject);
        }
        public static bool EditScore(DTO_RegisterSubject DTORegisterSubject)
        {
            return DAL_RegisterSubject.EditScore(DTORegisterSubject);
        }
        public static bool DeleteScore(DTO_RegisterSubject DTORegisterSubject)
        {
            return DAL_RegisterSubject.DeleteScore(DTORegisterSubject);
        }
    }
}
