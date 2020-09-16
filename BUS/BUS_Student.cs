using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Student
    {
        public static List<DTO_Student> loadstudent()
        {

            return DAL_Student.loadstudent();
        }
        public static List<DTO_Student> studentnull()
        {

            return DAL_Student.studentnull();
        }
        public static bool CheckDup(DTO_Student DTOStudent)
        {
            return DAL_Student.CheckDup(DTOStudent);
        }
        public static List<DTO_Student> loadstudentnull()
        {

            return DAL_Student.loadstudentnull();
        }
        public static List<DTO_Student> loadstudentclass()
        {

            return DAL_Student.loadstudentclass();
        }
        public static bool InsertStudent(DTO_Student DTOStudent)
        {
            return DAL_Student.InsertStudent(DTOStudent);
        }
        public static bool UpdateStudent(DTO_Student DTOStudent,string id,string id1)
        {
            return DAL_Student.UpdateStudent(DTOStudent,id,id1);
        }
        public static bool DeleteStudent(DTO_Student DTOStudent,string id , string id1)
        {
            return DAL_Student.DeleteStudent(DTOStudent,id,id1);
        }
        public static bool DeleteStudentIdInScore(DTO_Student DTOStudent,string id1)
        {
            return DAL_Student.DeleteStudentIdInScore(DTOStudent,id1);
        }
        public static List<DTO_Student> searchstudent(string id)
        {

            return DAL_Student.searchstudent(id);
        }
    }
}
