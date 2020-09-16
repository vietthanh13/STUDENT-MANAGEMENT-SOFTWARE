using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Subject
    {
        static SqlConnection con;
        public static List<DTO_Subject> loadsubject()
        {
            string query = "exec loadsubject";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Subject> listsubject = new List<DTO_Subject>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Subject Subject = new DTO_Subject();
                Subject.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Subject.Subjectname = dt.Rows[i]["subjectname"].ToString();
                Subject.Credit = dt.Rows[i]["credit"].ToString();
                listsubject.Add(Subject);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listsubject;
        }
        public static bool CheckDup(DTO_Subject DTOSubject)
        {
            string query = string.Format("exec checkdupsubject '{0}'",DTOSubject.Subjectid);
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
        public static bool InsertSubject(DTO_Subject DTOSubject)
        {

            string query = string.Format("exec insertsubject N'{0}',N'{1}',N'{2}'",DTOSubject.Subjectid,DTOSubject.Subjectname,DTOSubject.Credit);
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
        public static bool EditSubject(DTO_Subject DTOSubject, string id)
        {
            string query = string.Format("exec editsubject N'{0}',N'{1}',N'{2}',N'{3}'", DTOSubject.Subjectid, DTOSubject.Subjectname, DTOSubject.Credit, id);
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
        public static bool EditSubjectIdSemester(DTO_Subject DTOSubject, string id) 
        {
            string query = string.Format("exec editsubjectidsemester '{0}'",id);
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
        public static bool EditSubjectIdScore(DTO_Subject DTOSubject, string id) 
        {
            string query = string.Format("exec editsubjectidscore '{0}'",id);
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
        public static bool EditNullSubjectIdInSemester(DTO_Subject DTOSubject)
        {
            string query = string.Format("exec editnullsubjectidinsemester '{0}'",DTOSubject.Subjectid);
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
        public static bool EditNullSubjectIdInScore(DTO_Subject DTOSubject)
        {
            string query = string.Format("exec editnullsubjectinscore '{0}'",DTOSubject.Subjectid);
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
        public static bool DeleteSubject(DTO_Subject DTOSubject)
        {
            string query = string.Format("exec deletesubject '{0}','{1}','{2}'",DTOSubject.Subjectid,DTOSubject.Subjectname,DTOSubject.Credit);
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
        public static bool DeleteSemester(DTO_Subject DTOSubject,string id)
        {
            string query = string.Format("exec deletesemester '{0}'",id);
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
        public static bool DeleteScore(DTO_Subject DTOSubject,string id)
        {
            string query = string.Format("exec deletescore '{0}'",id);
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
        public static List<DTO_Subject> searchsubject(string id)
        {
            string query = string.Format("exec searchsubject '{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Subject> listsubject = new List<DTO_Subject>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Subject Subject = new DTO_Subject();
                Subject.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Subject.Subjectname = dt.Rows[i]["subjectname"].ToString();
                Subject.Credit = dt.Rows[i]["credit"].ToString();
                listsubject.Add(Subject);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listsubject;
        }
    }
}
