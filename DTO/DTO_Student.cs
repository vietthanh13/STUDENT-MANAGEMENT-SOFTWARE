using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Student
    {
        private string userid;
        private string username;
        private string password;
        private string auth;
        private string studentid;
        private string firstname;
        private string lastname;
        private string dayofbirth;
        private string sex;
        private string placeofbirth;
        private string classid;
        private string classname;
        private string majorid;
        private string majorname;

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

        public string Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Dayofbirth
        {
            get { return dayofbirth; }
            set { dayofbirth = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Placeofbirth
        {
            get { return placeofbirth; }
            set { placeofbirth = value; }
        }
        public string Classid
        {
            get { return classid; }
            set { classid = value; }
        }
        public string Majorid
        {
            get { return majorid; }
            set { majorid = value; }
        }
        public string Classname
        {
            get { return classname; }
            set { classname = value; }
        }
        
        public string Majorname
        {
            get { return majorname; }
            set { majorname = value; }
        }
        
    }
}
