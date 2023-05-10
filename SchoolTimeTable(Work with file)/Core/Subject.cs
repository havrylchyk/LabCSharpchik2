﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Core
{
    public class Subject
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Tutor { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
