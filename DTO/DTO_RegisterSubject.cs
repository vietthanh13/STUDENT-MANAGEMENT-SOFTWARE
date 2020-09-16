using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_RegisterSubject
    {
        private string studentid;
        private string subjectid;
        private string subjectname;
        public string Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }
        public string Subjectid
        {
            get { return subjectid; }
            set { subjectid = value; }
        }
        public string Subjectname
        {
            get { return subjectname; }
            set { subjectname = value; }
        }
    }
}
