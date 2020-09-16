using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_MenuAdmin
    {
        private string userid;
        private string username;
        private string password;
        private string auth;
        private string checkstatus;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Auth
        {
            get { return auth; }
            set { auth = value; }
        }
        public string CheckStatus
        {
            get { return checkstatus; }
            set { checkstatus = value; }
        }
    }
}
