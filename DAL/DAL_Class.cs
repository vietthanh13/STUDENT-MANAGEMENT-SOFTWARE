using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Class
    {
        static SqlConnection con;
        public static List<DTO_Class> loadclass()
        {
            string query = "exec loadclass";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          
            
            List<DTO_Class> listclass = new List<DTO_Class>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Class Class = new DTO_Class();
                Class.Classid = dt.Rows[i]["classid"].ToString();
                Class.Classname = dt.Rows[i]["classname"].ToString();
                Class.Trainsystem = dt.Rows[i]["trainsystem"].ToString();
                Class.Yearofaddmission = dt.Rows[i]["yearofaddmission"].ToString();
                Class.Wholesalenumber = dt.Rows[i]["wholesalenumber"].ToString();
                Class.Majorid = dt.Rows[i]["majorid"].ToString();
                Class.Majorname = dt.Rows[i]["majorname"].ToString();
                listclass.Add(Class);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listclass;
        }

        public static bool CheckDup(DTO_Class DTOClass)
        {
            string query = string.Format("exec checkdupclass '{0}'",DTOClass.Classid);
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
        public static bool InsertClass(DTO_Class DTOClass)
        {

            string query = string.Format("exec insertclass N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'", DTOClass.Classid, DTOClass.Classname, DTOClass.Trainsystem, DTOClass.Yearofaddmission, DTOClass.Wholesalenumber, DTOClass.Majorid);
            con = DBConnect.Connection();
            try
            {
                DBConnect.ExcuteNonQuery(query,con);
                DBConnect.CloseConnect(con);
                return true;
            }
            catch(Exception ex)
            {
                DBConnect.CloseConnect(con);
                return false;
            }
        }
        public static bool EditClass(DTO_Class DTOClass, string id)
        {
            string query = string.Format("exec editclass N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}'", DTOClass.Classid, DTOClass.Classname, DTOClass.Trainsystem, DTOClass.Yearofaddmission, DTOClass.Wholesalenumber, DTOClass.Majorid,id);
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
        public static bool EditClassIdStudent(DTO_Class DTOClass, string id) // update khóa ngoại Classid = null trong Student
        {
            string query = string.Format("exec editclassidinstudent '{0}'", id);
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
        public static bool EditClassIdSemester(DTO_Class DTOClass, string id) // update khóa ngoại Classid = null trong Semester
        {
            string query = string.Format("exec editclassidsemester '{0}'", id);
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
        public static bool EditNullClassIdInStudent(DTO_Class DTOClass) // update khóa ngoại classid trong Student điều kiện = null
        {
            string query = string.Format("editnullclassidinstudent '{0}'", DTOClass.Classid);
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
        public static bool EditNullClassIdInSemester(DTO_Class DTOClass) // update khóa ngoại classid trong Semester điều kiện = null
        {
            string query = string.Format("exec editnullclassidinsemester '{0}'",DTOClass.Classid);
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
        public static bool DeleteClass(DTO_Class DTOClass,string id)
        {
            // string query = string.Format("exec deleteclass '{0}','{1}','{2}','{3}','{4}','{5}'",DTOClass.Classid,DTOClass.Classname,DTOClass.Trainsystem,DTOClass.Yearofaddmission,DTOClass.Wholesalenumber ,DTOClass.Majorid,id);
            string query = string.Format("exec deleteclass '{0}'", id);
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
        public static bool DeleteSemester(DTO_Class DTOClass,string id)
        {
            string query = string.Format("exec deletesemester1 '{0}'",id);
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
        public static List<DTO_Class> searchclass(string id)
        {
            string query = string.Format("exec searchclass '{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Class> listclass = new List<DTO_Class>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Class Class = new DTO_Class();
                Class.Classid = dt.Rows[i]["classid"].ToString();
                Class.Classname = dt.Rows[i]["classname"].ToString();
                Class.Trainsystem = dt.Rows[i]["trainsystem"].ToString();
                Class.Yearofaddmission = dt.Rows[i]["yearofaddmission"].ToString();
                Class.Wholesalenumber = dt.Rows[i]["wholesalenumber"].ToString();
                Class.Majorid = dt.Rows[i]["majorid"].ToString();
                Class.Majorname = dt.Rows[i]["majorname"].ToString();
                listclass.Add(Class);

            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listclass;
        }

    }
}
