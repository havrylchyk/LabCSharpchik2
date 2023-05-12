using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Core
{
    public class Group
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int NumberOfSstudents { get; set; }
        public string ClassTeacher { get; set; }

        public override string ToString()
        {
            return ClassName;
        }
    }
}
