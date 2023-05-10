using System;

namespace SchoolTimeTable_Work_with_file_.Core
{
    public class CallSchedule
    {
        public int Id { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan Finish { get; set; }

        //public override string ToString()
        //{
        //    return $"{Id} {Start.ToString("hh\\:mm")} {Finish.ToString("hh\\:mm")}";
        //}
    }
}