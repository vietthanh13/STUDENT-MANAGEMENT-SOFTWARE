using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Semester
    {
        static SqlConnection con;
        public static List<DTO_Semester> loadsemester()
        {
            string query = "exec loadsemester";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Semester> listsemester = new List<DTO_Semester>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Semester Semester = new DTO_Semester();
                Semester.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Semester.Classid = dt.Rows[i]["classid"].ToString();
                Semester.Semester = dt.Rows[i]["semester"].ToString();
                listsemester.Add(Semester);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listsemester;
        }
       
        public static bool CheckDup(DTO_Semester DTOSemester)
        {
            string query = string.Format("exec checkdupsemester '{0}','{1}'", DTOSemester.Subjectid,DTOSemester.Classid);
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
        public static bool InsertSemester(DTO_Semester DTOSemester)
        {

            string query = string.Format("exec insertsemester N'{0}',N'{1}',N'{2}'", DTOSemester.Subjectid, DTOSemester.Classid, DTOSemester.Semester);
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
        public static bool EditSemester(DTO_Semester DTOSemester, string id1,string id2)
        {
            string query = string.Format("exec editsemester N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", DTOSemester.Subjectid, DTOSemester.Classid, DTOSemester.Semester,id1,id2);
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
        public static bool DeleteSemester(DTO_Semester DTOSemester, string id1, string id2)
        {
            string query = string.Format("exec delsemester '{0}','{1}','{2}','{3}','{4}'", DTOSemester.Subjectid, DTOSemester.Classid, DTOSemester.Semester, id1, id2);
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
        public static List<DTO_Semester> searchsemester(string id)
        {
            string query = string.Format("exec searchsemester '{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Semester> search = new List<DTO_Semester>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Semester Semester = new DTO_Semester();
                Semester.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Semester.Classid = dt.Rows[i]["classid"].ToString();
                Semester.Semester = dt.Rows[i]["semester"].ToString();
                search.Add(Semester);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return search;
        }
    }
}
