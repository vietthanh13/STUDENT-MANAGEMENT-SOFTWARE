using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Score
    {
        static SqlConnection con;
        public static List<DTO_Score> loadscore(string id)
        {
            string query = string.Format("exec loadscore '{0}'", id);
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Score> listscore = new List<DTO_Score>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Score Score = new DTO_Score();
                Score.Studentid = dt.Rows[i]["studentid"].ToString();
                Score.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Score.Subjectname = dt.Rows[i]["subjectname"].ToString();
                Score.Credit = dt.Rows[i]["credit"].ToString();
                Score.Score1 = dt.Rows[i]["score1"].ToString();
                Score.Score2 = dt.Rows[i]["score2"].ToString();
                Score.Semester = dt.Rows[i]["semester"].ToString();
                listscore.Add(Score);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listscore;
        }
    }
}
