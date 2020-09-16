using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Login
    {
        static SqlConnection con;
        public static bool CheckLogin(DTO_Login DTOLogin, string check )
        {
            string query = string.Format("exec checklogin '{0}','{1}','{2}'", DTOLogin.Username, DTOLogin.Password, check);
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

        public static List<DTO_Login> LoadPass(string id)
        {
            string query = string.Format("exec checkdecode '{0}'",id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List
            List<DTO_Login> listpass = new List<DTO_Login>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Login pass = new DTO_Login();
                pass.Username = dt.Rows[i]["username"].ToString();
                pass.Password = dt.Rows[i]["passwords"].ToString();
                listpass.Add(pass);
            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listpass;
        }


        public static bool CheckAuth(DTO_Login DTOLogin)
        {
            string query = string.Format("exec checkauth '{0}','{1}'", DTOLogin.Username,DTOLogin.CheckStatus);
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
    }
}
