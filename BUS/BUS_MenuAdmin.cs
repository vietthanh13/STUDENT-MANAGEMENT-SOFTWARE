using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_MenuAdmin
    {
        public static List<DTO_MenuAdmin> loaduser()
        {
            // Load Major
            return DAL_MenuAdmin.loaduser();
        }
        public static bool InsertUser(DTO_MenuAdmin DTOMenuAdmin)
        {
            return DAL_MenuAdmin.InsertUser(DTOMenuAdmin);
        }
        public static bool CheckDup(DTO_MenuAdmin DTOMenuAdmin)
        {
            return DAL_MenuAdmin.CheckDup(DTOMenuAdmin);
        }
        public static bool EditUser(DTO_MenuAdmin DTOMenuAdmin,string id)
        {
            return DAL_MenuAdmin.EditUser(DTOMenuAdmin,id);
        }
        public static bool DeleteUser(DTO_MenuAdmin DTOMenuAdmin, string id)
        {
            return DAL_MenuAdmin.DeleteUser(DTOMenuAdmin, id);
        }
        public static bool DeleteUserIdInStudent(DTO_MenuAdmin DTOMenuAdmin, string id)
        {
            return DAL_MenuAdmin.DeleteUserIdInStudent(DTOMenuAdmin, id);
        }
        public static bool UpdateEnable(DTO_MenuAdmin DTOMenuAdmin)
        {
            return DAL_MenuAdmin.UpdateEnable(DTOMenuAdmin);
        }
        public static bool UpdateDisable(DTO_MenuAdmin DTOMenuAdmin)
        {
            return DAL_MenuAdmin.UpdateDisable(DTOMenuAdmin);
        }
        public static List<DTO_MenuAdmin> searchuser(string id)
        {
            // Load Major
            return DAL_MenuAdmin.searchuser(id);
        }
    }
}
