using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_
{
    public interface IFileService
    {
        List<Lesson> Read(string path);
        void Write(string path, List<Lesson> data);
        string Filter { get; set; }
    }
}
