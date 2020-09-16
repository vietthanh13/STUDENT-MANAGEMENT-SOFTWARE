using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_User
    {
        static SqlConnection con;
        public static List<DTO_User> loaduser(string id)
        {
            String query = string.Format("loaduseruser N'{0}'",id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_User> listuser = new List<DTO_User>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_User User = new DTO_User();
                User.Studentid = dt.Rows[i]["studentid"].ToString();
                User.Firstname = dt.Rows[i]["firstname"].ToString();
                User.Lastname = dt.Rows[i]["lastname"].ToString();
                User.Dayofbirth = dt.Rows[i]["dayofbirth"].ToString();
                User.Placeofbirth = dt.Rows[i]["placeofbirth"].ToString();
                User.Sex = dt.Rows[i]["sex"].ToString();
                User.Classid = dt.Rows[i]["classid"].ToString();
                User.Majorname = dt.Rows[i]["majorname"].ToString();
                listuser.Add(User);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listuser;
        }
    }
}
