using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Major
    {
        //Connection
       static SqlConnection con;
        public static List<DTO_Major> loadmajor()
        {
            string query = "exec loadmajor";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            // List
            List<DTO_Major> listmajor = new List<DTO_Major>();
            for (int i=0; i < dt.Rows.Count;i++)
            {
                DTO_Major major = new DTO_Major();
                    major.Majorid = dt.Rows[i]["majorid"].ToString();
                    major.Majorname = dt.Rows[i]["majorname"].ToString();
                listmajor.Add(major);
            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listmajor;
        }
        public static bool CheckDup(DTO_Major DTOMajor)
        {
            string query = string.Format("exec checkdupmajor '{0}'",DTOMajor.Majorid);
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
        public static bool InsertMajor(DTO_Major DTOMajor)
        {
            string query = string.Format("exec insertmajor N'{0}',N'{1}'",DTOMajor.Majorid,DTOMajor.Majorname);
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
        public static bool EditMajor(DTO_Major DTOMajor,string id)
        {
            //string query = string.Format("exec dbo.updatemajor '{0}','{1}','{2}'", DTOMajor.Majorid, DTOMajor.Majorname,id);
            string query = string.Format("exec dbo.updatemajor N'{0}',N'{1}',N'{2}'",DTOMajor.Majorid,DTOMajor.Majorname, id);
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
        public static bool EditMajorIdInClass(DTO_Major DTOMajor, string id) // update khóa ngoại majorid = null trong Class
        {
            string query = string.Format("exec dbo.editmajoridinclass '{0}'", id);
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
        public static bool EditNullMajorIdInClass(DTO_Major DTOMajor) // update khóa ngoại majorid trong Class điều kiện = null
        {
            string query = string.Format("exec dbo.editnullmajoridinclass '{0}'",DTOMajor.Majorid);
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
