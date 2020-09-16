using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Semester
    {
        public static List<DTO_Semester> loadsemester()
        {
            // Load Semester
            return DAL_Semester.loadsemester();
        }
        public static bool InsertSemester(DTO_Semester DTOSemester)
        {
            return DAL_Semester.InsertSemester(DTOSemester);
        }
        public static bool CheckDup(DTO_Semester DTOSemester)
        {
            return DAL_Semester.CheckDup(DTOSemester);
        }
        public static bool EditSemester(DTO_Semester DTOSemester, string id1,string id2)
        {
            return DAL_Semester.EditSemester(DTOSemester, id1,id2);
        }
        public static bool DeleteSemester(DTO_Semester DTOSemester, string id1,string id2)
        {
            return DAL_Semester.DeleteSemester(DTOSemester, id1,id2);
        }
        public static List<DTO_Semester> searchsemester(string id)
        {
            return DAL_Semester.searchsemester(id);
        }
    }
}
