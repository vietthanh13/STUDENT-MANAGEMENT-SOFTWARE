using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Major
    {
        public static List<DTO_Major> loadmajor()
        {
            // Load Major
            return DAL_Major.loadmajor();
        }
        public static bool CheckDup(DTO_Major DTOMajor)
        {
            return DAL_Major.CheckDup(DTOMajor);
        }
        public static bool InsertMajor(DTO_Major DTOMajor)
        {
            return DAL_Major.InsertMajor(DTOMajor);
        }
        public static bool EditMajor(DTO_Major DTOMajor,string id)
        {
            return DAL_Major.EditMajor(DTOMajor,id);
        }
        public static bool EditMajorIdInClass(DTO_Major DTOMajor, string id)
        {
            return DAL_Major.EditMajorIdInClass(DTOMajor, id);
        }
        public static bool EditNullMajorIdInClass(DTO_Major DTOMajor)
        {
            return DAL_Major.EditNullMajorIdInClass(DTOMajor);
        }
    }
}
