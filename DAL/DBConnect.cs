    using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DBConnect
    {
        // Kết Nối
        public static SqlConnection Connection()
        {
            String StringConnect = @"Data Source=DESKTOP-2MKPB58;Initial Catalog=SQLDBUI;Persist Security Info=True;User ID=sa;Password=sa";
            //String StringConnect = @"Data Source = 192.168.1.2,1433; Initial Catalog = SQLDBUI; User ID = sa; Password = sa";
            SqlConnection con = new SqlConnection(StringConnect);
            con.Open();
            return con;

        }
        //Đóng Kết Nối
        public static void CloseConnect(SqlConnection con)
        {
            con.Close();
        }
        // Lấy DataTable
        public static DataTable GetDataTable(string query,SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool ExcuteNonQuery(String query,SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

           
        }
    }
}
