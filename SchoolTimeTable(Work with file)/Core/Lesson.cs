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
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        [Browsable(false)]
        public int SubjectId { get; set; }
        [Browsable(false)]
        public int GroupId { get; set; }

        public Subject Subject { get; set; }
        
        public Group Group { get; set; }

    }
}
