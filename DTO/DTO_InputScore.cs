using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_InputScore
    {
        private string studentid;
        private string classid;
        private string subjectid;
        private string subjectname;
        private string semester;
        private string score1;
        private string score2;
        public string Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }
        public string Classid
        {
            get { return classid; }
            set { classid = value; }
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
        public string Score1
        {
            get { return score1; }
            set { score1 = value; }
        }
        public string Score2
        {
            get { return score2; }
            set { score2 = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

    }
}
