using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_RegisterSubject
    {
        static SqlConnection con;
        public static List<DTO_RegisterSubject> loadregister(string id)
        {
            string query = string.Format("exec loadregister '{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_RegisterSubject> listregisster = new List<DTO_RegisterSubject>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_RegisterSubject Subject = new DTO_RegisterSubject();
                Subject.Studentid = dt.Rows[i]["studentid"].ToString();
                Subject.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Subject.Subjectname = dt.Rows[i]["subjectname"].ToString();
                listregisster.Add(Subject);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listregisster;
        }
        public static bool CheckDup(DTO_RegisterSubject DTORegisterSubject)
        {
            string query = string.Format("exec checkdupscore '{0}','{1}'", DTORegisterSubject.Studentid,DTORegisterSubject.Subjectid);
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
        public static bool InsertScore(DTO_RegisterSubject DTORegisterSubject)
        {

            string query = string.Format("exec insertscore '{0}','{1}'", DTORegisterSubject.Studentid, DTORegisterSubject.Subjectid);
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
        public static bool EditScore(DTO_RegisterSubject DTORegisterSubject)
        {

            string query = string.Format("exec updatescore '{0}','{1}'", DTORegisterSubject.Subjectid, DTORegisterSubject.Studentid);
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
        public static bool DeleteScore(DTO_RegisterSubject DTORegisterSubject)
        {

            string query = string.Format("exec deletescoreuser '{0}','{1}'", DTORegisterSubject.Studentid, DTORegisterSubject.Subjectid);
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
    } 
}
