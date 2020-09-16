using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_MenuAdmin
    {
        static SqlConnection con;
        public static List<DTO_MenuAdmin> loaduser()
        {
            string query = "exec loaduser";
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_MenuAdmin> listuser = new List<DTO_MenuAdmin>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_MenuAdmin MenuAdmin = new DTO_MenuAdmin();
                MenuAdmin.Userid = dt.Rows[i]["userid"].ToString();
                MenuAdmin.Username = dt.Rows[i]["username"].ToString();
                MenuAdmin.Password = dt.Rows[i]["passwords"].ToString();
                MenuAdmin.Auth = dt.Rows[i]["auth"].ToString();
                MenuAdmin.CheckStatus = dt.Rows[i]["checkstatus"].ToString();
                listuser.Add(MenuAdmin);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listuser;
        }
        public static bool CheckDup(DTO_MenuAdmin DTOMenuAdmin)
        {
            string query = string.Format("exec checkdupuser '{0}'",DTOMenuAdmin.Username);
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
        public static bool InsertUser(DTO_MenuAdmin DTOMenuAdmin)
        {

            string query = string.Format("exec insertuser '{0}','{1}','{2}','{3}'",DTOMenuAdmin.Username,DTOMenuAdmin.Password,DTOMenuAdmin.Auth,DTOMenuAdmin.CheckStatus = "Enable");
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
        public static bool EditUser(DTO_MenuAdmin DTOMenuAdmin, string id)
        {
            string query = string.Format("exec updateuser '{0}','{1}','{2}','{3}'",DTOMenuAdmin.Username,DTOMenuAdmin.Password,DTOMenuAdmin.Auth,id);
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
        public static bool DeleteUser(DTO_MenuAdmin DTOMenuAdmin,string id)
        {
            string query = string.Format("exec deleteuser '{0}','{1}','{2}','{3}'", DTOMenuAdmin.Username, DTOMenuAdmin.Password, DTOMenuAdmin.Auth, id);
            con = DBConnect.Connection();
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
        public static bool DeleteUserIdInStudent(DTO_MenuAdmin DTOMenuAdmin, string id)
        {
            string query = string.Format("exec deleteuseridinstudent '{0}'", id);
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
        public static bool UpdateEnable(DTO_MenuAdmin DTOMenuAdmin)
        {
            string query = string.Format("exec updateenable '{0}'", DTOMenuAdmin.Userid);
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
        public static bool UpdateDisable(DTO_MenuAdmin DTOMenuAdmin)
        {
            string query = string.Format("exec updatedisable '{0}'", DTOMenuAdmin.Userid);
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
        public static List<DTO_MenuAdmin> searchuser(string id)
        {
            string query = string.Format("exec searchuser '%{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_MenuAdmin> listuser = new List<DTO_MenuAdmin>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_MenuAdmin MenuAdmin = new DTO_MenuAdmin();
                MenuAdmin.Userid = dt.Rows[i]["userid"].ToString();
                MenuAdmin.Username = dt.Rows[i]["username"].ToString();
                MenuAdmin.Password = dt.Rows[i]["passwords"].ToString();
                MenuAdmin.Auth = dt.Rows[i]["auth"].ToString();
                MenuAdmin.CheckStatus = dt.Rows[i]["checkstatus"].ToString();
                listuser.Add(MenuAdmin);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listuser;
        }

    }
}
