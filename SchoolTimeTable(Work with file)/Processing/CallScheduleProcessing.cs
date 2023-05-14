using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class CallScheduleProcessing
    {
        public List<CallSchedule> CallSchedules;

        public CallScheduleProcessing()
        {
            CallSchedules = new List<CallSchedule>();
        }
        public List<CallSchedule> GetInfo()
        {
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data", "callschedule.txt");
            string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("windows-1251"));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                CallSchedule callSchedule = new CallSchedule
                {
                    Id = int.Parse(data[0]),
                    Start = TimeSpan.Parse(data[1]),
                    Finish = TimeSpan.Parse(data[2])
                };
                CallSchedules.Add(callSchedule);
            }

            return CallSchedules;
        }
    }
}

