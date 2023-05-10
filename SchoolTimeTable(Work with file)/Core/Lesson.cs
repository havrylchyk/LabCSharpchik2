using SchoolTimeTable_Work_with_file_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Core
{
    public class Lesson 
    {
        public int SequenceNumber { get; set; }
        public Subject Subject { get; set; }
        public Group Group { get; set; }

        //public string ToTxt()
        //{
        //    return $"{SequenceNumber},{Subject}";
        //}
    }
}
