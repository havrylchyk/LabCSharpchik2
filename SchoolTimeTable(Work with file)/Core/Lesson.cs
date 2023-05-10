using SchoolTimeTable_Work_with_file_.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Core
{
    public class Lesson 
    {
        [Browsable(false)]
        public Guid Id { get; } = Guid.NewGuid();
        public int SequenceNumber { get; set; }
        [Browsable(false)]
        public Guid Subject { get; set; }
        [Browsable(false)]
        public Guid Group { get; set; }

        //public string ToTxt()
        //{
        //    return $"{SequenceNumber},{Subject}";
        //}
    }
}
