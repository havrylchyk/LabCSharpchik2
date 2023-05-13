using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class SubjectProcessing
    {
        public List<Subject> Subjects;

        public SubjectProcessing()
        {
            Subjects = new List<Subject>();
        }
        public List<Subject> GetInfo()
        {
            string filePath = "C:\\Users\\Lenovo\\Desktop\\Subject.txt";
            string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("windows-1251"));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Subject subjects = new Subject
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Tutor = data[2]
                };
                Subjects.Add(subjects);
            }

            return Subjects;
        }

        public Subject GetSubject(int id)
        {
            return Subjects.FirstOrDefault(subject => subject.Id == id);
        }
    }
}
