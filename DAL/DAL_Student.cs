using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Student
    {
        static SqlConnection con;
        public static List<DTO_Student> loadstudent()
        {
            string query = "exec loadstudent";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Student> liststudent = new List<DTO_Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Student Student = new DTO_Student();
                Student.Userid = dt.Rows[i]["userid"].ToString();
                Student.Username = dt.Rows[i]["username"].ToString();
                Student.Password = dt.Rows[i]["passwords"].ToString();
                Student.Auth = dt.Rows[i]["auth"].ToString();
                Student.Studentid = dt.Rows[i]["studentid"].ToString();
                Student.Firstname = dt.Rows[i]["firstname"].ToString();
                Student.Lastname = dt.Rows[i]["lastname"].ToString();
                Student.Dayofbirth = dt.Rows[i]["dayofbirth"].ToString();
                Student.Sex = dt.Rows[i]["sex"].ToString();
                Student.Placeofbirth = dt.Rows[i]["placeofbirth"].ToString();
                Student.Classid = dt.Rows[i]["classid"].ToString();
                //Student.Classname = dt.Rows[i]["classname"].ToString();
                Student.Majorid = dt.Rows[i]["majorid"].ToString();
                Student.Majorname = dt.Rows[i]["majorname"].ToString();
                liststudent.Add(Student);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return liststudent;
        }
        public static List<DTO_Student> studentnull()
        {
            string query = "exec loadnullstudent";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Student> listnullstudent = new List<DTO_Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Student Student = new DTO_Student();
                Student.Userid = dt.Rows[i]["userid"].ToString();
                Student.Studentid = dt.Rows[i]["studentid"].ToString();
                Student.Firstname = dt.Rows[i]["firstname"].ToString();
                Student.Lastname = dt.Rows[i]["lastname"].ToString();
                Student.Dayofbirth = dt.Rows[i]["dayofbirth"].ToString();
                Student.Sex = dt.Rows[i]["sex"].ToString();
                Student.Placeofbirth = dt.Rows[i]["placeofbirth"].ToString();
                Student.Classid = dt.Rows[i]["classid"].ToString();
                //Student.Classname = dt.Rows[i]["classname"].ToString();
                //Student.Majorid = dt.Rows[i]["majorid"].ToString();
                // Student.Majorname = dt.Rows[i]["majorname"].ToString();
                listnullstudent.Add(Student);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listnullstudent;
        }
        public static bool CheckDup(DTO_Student DTOStudent)
        {
            string query = string.Format("exec checkdupstudent '{0}','{1}'", DTOStudent.Userid,DTOStudent.Studentid);
            con = DBConnect.Connection();
            SqlCommand cmd = new SqlCommand(query, con);
            //create a reader
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                return true; // có
            }
            else
            {

                return false;// chưa có;
            }
            DBConnect.CloseConnect(con);
        }
        public static List<DTO_Student> loadstudentnull()
        {
            string query = string.Format("exec loadstudentnull");
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Student> liststudentnull = new List<DTO_Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Student Student = new DTO_Student();
                Student.Userid = dt.Rows[i]["userid"].ToString();
                Student.Username = dt.Rows[i]["username"].ToString();
                liststudentnull.Add(Student);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return liststudentnull;
        }
        public static List<DTO_Student> loadstudentclass()
        {
            string query = "exec loadstudentclass";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Student> loadclassstudent = new List<DTO_Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Student Student = new DTO_Student();
                Student.Classid = dt.Rows[i]["classid"].ToString();
                Student.Classname = dt.Rows[i]["classname"].ToString();
                Student.Majorname = dt.Rows[i]["majorname"].ToString();
                loadclassstudent.Add(Student);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return loadclassstudent;
        }
        public static bool InsertStudent(DTO_Student DTOStudent)
        {

            string query = string.Format("exec insertstudent N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}'", DTOStudent.Userid, DTOStudent.Studentid, DTOStudent.Firstname, DTOStudent.Lastname, DTOStudent.Dayofbirth, DTOStudent.Sex, DTOStudent.Placeofbirth, DTOStudent.Classid);

            con = DBConnect.Connection();
            try
            {
                DBConnect.ExcuteNonQuery(query, con);
                DBConnect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DBConnect.CloseConnect(con);
                return false;
            }
        }
        public static bool UpdateStudent(DTO_Student DTOStudent,string id,string id1)
        {

            string query = string.Format("exec updatestudent N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}'", DTOStudent.Userid, DTOStudent.Studentid, DTOStudent.Firstname, DTOStudent.Lastname, DTOStudent.Dayofbirth, DTOStudent.Sex, DTOStudent.Placeofbirth, DTOStudent.Classid,id,id1);

            con = DBConnect.Connection();
            try
            {
                DBConnect.ExcuteNonQuery(query, con);
                DBConnect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DBConnect.CloseConnect(con);
                return false;
            }
        }
        public static bool DeleteStudent(DTO_Student DTOStudent,string id,string id1)
        {

            string query = string.Format("exec deletestudent N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}'", DTOStudent.Userid, DTOStudent.Studentid, DTOStudent.Firstname, DTOStudent.Lastname, DTOStudent.Dayofbirth, DTOStudent.Sex, DTOStudent.Placeofbirth, DTOStudent.Classid,id,id1);

            con = DBConnect.Connection();
            try
            {
                DBConnect.ExcuteNonQuery(query, con);
                DBConnect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DBConnect.CloseConnect(con);
                return false;
            }
        }
        public static bool DeleteStudentIdInScore(DTO_Student DTOStudent,string id1)
        {

            string query = string.Format("exec deletestudentidinsore '{0}'", id1);

            con = DBConnect.Connection();
            try
            {
                DBConnect.ExcuteNonQuery(query, con);
                DBConnect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DBConnect.CloseConnect(con);
                return false;
            }
        }
        public static List<DTO_Student> searchstudent(string id)
        {
            string query = string.Format("exec searchstudent '{0}'",id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Student> liststudent = new List<DTO_Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Student Student = new DTO_Student();
                Student.Userid = dt.Rows[i]["userid"].ToString();
                Student.Username = dt.Rows[i]["username"].ToString();
                Student.Password = dt.Rows[i]["passwords"].ToString();
                Student.Auth = dt.Rows[i]["auth"].ToString();
                Student.Studentid = dt.Rows[i]["studentid"].ToString();
                Student.Firstname = dt.Rows[i]["firstname"].ToString();
                Student.Lastname = dt.Rows[i]["lastname"].ToString();
                Student.Dayofbirth = dt.Rows[i]["dayofbirth"].ToString();
                Student.Sex = dt.Rows[i]["sex"].ToString();
                Student.Placeofbirth = dt.Rows[i]["placeofbirth"].ToString();
                Student.Classid = dt.Rows[i]["classid"].ToString();
                //Student.Classname = dt.Rows[i]["classname"].ToString();
                Student.Majorid = dt.Rows[i]["majorid"].ToString();
                Student.Majorname = dt.Rows[i]["majorname"].ToString();
                liststudent.Add(Student);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return liststudent;
        }
    }
}
