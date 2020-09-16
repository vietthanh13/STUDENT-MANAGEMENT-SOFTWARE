using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Class
    {
        public static List<DTO_Class> loadclass()
        {
            // Load Class   
            return DAL_Class.loadclass();
        }
        public static bool InsertClass(DTO_Class DTOClass)
        {
            return DAL_Class.InsertClass(DTOClass);
        }
        public static bool CheckDup(DTO_Class DTOClass)
        {
            return DAL_Class.CheckDup(DTOClass);
        }
        public static bool EditClass(DTO_Class DTOClass, string id)
        {
            return DAL_Class.EditClass(DTOClass, id);
        }
        public static bool EditClassIdStudent(DTO_Class DTOClass,string id)
        {
            return DAL_Class.EditClassIdStudent(DTOClass,id);
        }
        public static bool EditClassIdSemester(DTO_Class DTOClass, string id)
        {
            return DAL_Class.EditClassIdSemester(DTOClass, id);
        }
        public static bool EditNullClassIdInStudent(DTO_Class DTOClass)
        {
            return DAL_Class.EditNullClassIdInStudent(DTOClass);
        }
        public static bool EditNullClassIdInSemester(DTO_Class DTOClass)
        {
            return DAL_Class.EditNullClassIdInSemester(DTOClass);
        }
        public static bool DeleteClass(DTO_Class DTOClass,string id)
        {
            return DAL_Class.DeleteClass(DTOClass,id);
        }
        public static bool DeleteSemester(DTO_Class DTOClass,string id)
        {
            return DAL_Class.DeleteSemester(DTOClass,id);
        }
        public static List<DTO_Class> searchclass(string id)
        {
            // Load Major
            return DAL_Class.searchclass(id);
        }
    }
}
