using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Subject
    {
        private string subjectid;
        private string subjectname;
        private string credit;
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
        public string Credit
        {
            get { return credit; }
            set { credit = value; }
        }
    }
}
