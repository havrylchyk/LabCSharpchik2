using CsvHelper;
using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class CsvInterfaceSarvice : IFileService
    {
        public CsvInterfaceSarvice()
        {
            Filter = "CSV Product file (.csv)|*.csv";
        }
        public string Filter { get; set; }

        public List<Lesson> Read(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<Lesson>().ToList();
            }
        }

        public void Write(string path, List<Lesson> data)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }
    }
}
