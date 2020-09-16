using System.Collections.Generic;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Subject
    {
        public static List<DTO_Subject> loadsubject()
        {
            // Load Subject
            return DAL_Subject.loadsubject();
        }
        public static bool InsertSubject(DTO_Subject DTOSubject)
        {
            return DAL_Subject.InsertSubject(DTOSubject);
        }
        public static bool CheckDup(DTO_Subject DTOSubject)
        {
            return DAL_Subject.CheckDup(DTOSubject);
        }
        public static bool EditSubject(DTO_Subject DTOSubject, string id)
        {
            return DAL_Subject.EditSubject(DTOSubject, id);
        }
        public static bool EditSubjectIdSemester(DTO_Subject DTOSubject, string id)
        {
            return DAL_Subject.EditSubjectIdSemester(DTOSubject, id);
        }
        public static bool EditSubjectIdScore(DTO_Subject DTOSubject, string id)
        {
            return DAL_Subject.EditSubjectIdScore(DTOSubject, id);
        }
        public static bool EditNullSubjectIdInSemester(DTO_Subject DTOSubject)
        {
            return DAL_Subject.EditNullSubjectIdInSemester(DTOSubject);
        }
        public static bool EditNullSubjectIdInScore(DTO_Subject DTOSubject)
        {
            return DAL_Subject.EditNullSubjectIdInScore(DTOSubject);
        }
        public static bool DeleteSubject(DTO_Subject DTOSubject)
        {
            return DAL_Subject.DeleteSubject(DTOSubject);
        }
        public static bool DeleteSemester(DTO_Subject DTOSubject,string id)
        {
            return DAL_Subject.DeleteSemester(DTOSubject,id);
        }
        public static bool DeleteScore(DTO_Subject DTOSubject,string id)
        {
            return DAL_Subject.DeleteScore(DTOSubject,id);
        }
        public static List<DTO_Subject> searchsubject(string id)
        {
            return DAL_Subject.searchsubject(id);
        }
    }
}
