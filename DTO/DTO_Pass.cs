    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace DTO
    {
        public class DTO_Pass
        {
            private string username;
            private string password;
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
        }
    }
