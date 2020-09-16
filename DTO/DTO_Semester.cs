using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Semester
    {
        private string subjectid;
        private string classid;
        private string semester;

        public string Subjectid
        {
            get { return subjectid; }
            set { subjectid = value; }
        }
        public string Classid
        {
            get { return classid; }
            set { classid = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
    }
}
