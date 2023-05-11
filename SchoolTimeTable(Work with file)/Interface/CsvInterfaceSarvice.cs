using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class CsvInterfaceSarvice : IFileService
    {
        public string Filter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Lesson> Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(string path, List<Lesson> data)
        {
            throw new NotImplementedException();
        }
    }
}
