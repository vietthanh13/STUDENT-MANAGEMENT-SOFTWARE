using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_InputScore
    {
        static SqlConnection con;
        public static List<DTO_InputScore> loadscore(string id)
        {
            //string query = "SELECT dbo.Score.studentid,dbo.Class.classid,dbo.Subjects.subjectid, dbo.Subjects.subjectname, dbo.Score.score1, dbo.Score.score2, dbo.Semester.semester FROM dbo.Class INNER JOIN dbo.Semester ON dbo.Class.classid = dbo.Semester.classid INNER JOIN dbo.Subjects ON dbo.Semester.subjectid = dbo.Subjects.subjectid INNER JOIN dbo.Score ON dbo.Subjects.subjectid = dbo.Score.subjectid where dbo.Class.classid ='"+id+"'";          
            //string query = "select distinct studentid,class.classid,score.subjectid,subjects.subjectname,score1,score2,semester from score,semester,class,subjects where class.classid = semester.classid and semester.subjectid = score.subjectid and subjects.subjectid = semester.subjectid and class.classid = '"+id+"'";
            string query = string.Format("exec searchscore '{0}'", id);
            // Mở kết nối
            con = DBConnect.Connection();
            // Truy Vấn
            DataTable dt = DBConnect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_InputScore> listscore = new List<DTO_InputScore>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_InputScore Score = new DTO_InputScore();
                Score.Studentid= dt.Rows[i]["studentid"].ToString();
                Score.Classid = dt.Rows[i]["classid"].ToString();
                Score.Subjectid = dt.Rows[i]["subjectid"].ToString();
                Score.Subjectname = dt.Rows[i]["subjectname"].ToString();
                Score.Score1 = dt.Rows[i]["score1"].ToString();
                Score.Score2 = dt.Rows[i]["score2"].ToString();
                Score.Semester = dt.Rows[i]["semester"].ToString();
                listscore.Add(Score);


            }
            //Đóng kết nối
            DBConnect.CloseConnect(con);
            return listscore;
        }
        public static bool EditScore(DTO_InputScore DTOInputScore, string id)
        {
            string query = string.Format("exec editscore N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'",DTOInputScore.Subjectid,DTOInputScore.Studentid,DTOInputScore.Score1,DTOInputScore.Score2,DTOInputScore.Subjectid,id);
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
