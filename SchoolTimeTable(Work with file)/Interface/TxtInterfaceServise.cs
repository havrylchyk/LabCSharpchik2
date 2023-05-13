using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class TxtInterfaceServise : IFileService
    {
        public TxtInterfaceServise()
        {
            Filter = "Product file (.txt)|*.txt";
        }
        public string Filter { get; set; }

        public List<Lesson> Read(string path)
        {
            StreamReader reader = null;
            List<Lesson> products = new List<Lesson>();

            try
            {
                reader = new StreamReader(path);
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    var items = line.Split(';');
                    products.Add(new Lesson
                    {
                        Id = int.Parse(items[0]),
                        SequenceNumber = int.Parse(items[1]),
                        Subject = new Subject
                        {
                            Id = int.Parse(items[2]),
                            Name = items[3],
                            Tutor = items[4]
                        },
                        Group = new Group
                        {
                            Id = int.Parse(items[5]),
                            ClassName = items[6],
                            NumberOfSstudents = int.Parse(items[7]),
                            ClassTeacher = items[8]
                        }
                    });
                }
            }
            catch
            {
                throw new ArgumentException("File read error!");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return products;
        }

        public void Write(string path, List<Lesson> data)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, true, Encoding.UTF8);
                foreach (var item in data)
                    writer.WriteLine($"{item.Id};{item.SequenceNumber};" +
                        $"{item.Subject.Id};{item.Subject.Name};{item.Subject.Tutor};" +
                        $"{item.Group.Id};{item.Group.ClassName};{item.Group.NumberOfSstudents};{item.Group.ClassTeacher}");
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (writer != null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }

    }
}

