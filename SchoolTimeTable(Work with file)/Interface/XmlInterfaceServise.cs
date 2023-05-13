using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class XmlInterfaceServise : IFileService
    {

        public XmlInterfaceServise()
        {
            Filter = "XML Product file (xml)|*.xml";
        }
        public string Filter { get; set; }

        public List<Lesson> Read(string path)
        {
            List<Lesson> lessons = new List<Lesson>();

            XDocument xdoc = XDocument.Load(path);
            foreach (XElement element in xdoc.Root.Elements("Lessons"))
            {
                Lesson lesson = new Lesson()
                {
                    Id = (int)element.Attribute("id"),
                    SequenceNumber = (int)element.Element("name"),
                    Subject = new Subject()
                    {
                        Id = (int)element.Element("subjectid"),
                        Name = (string)element.Element("subjectname"),
                        Tutor = (string)element.Element("tutorname")
                    },
                    Group = new Group()
                    {
                        Id = (int)element.Element("groupid"),
                        ClassName = (string)element.Element("groupname"),
                        NumberOfSstudents = (int)element.Element("numberOfSstudents"),
                        ClassTeacher = (string)element.Element("classTeacher")
                    }
                };
                lessons.Add(lesson);
            }

            return lessons;
        }

        public void Write(string path, List<Lesson> data)
        {
            XDocument xdoc = new XDocument();
            xdoc.Declaration = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Add(new XElement("Lesson"));

            foreach (var item in data)
            {
                xdoc.Root.Add(new XElement("Lessons",
                    new XAttribute("id", item.Id),
                    new XElement("name", item.SequenceNumber),
                    new XElement("subjectid", item.Subject.Id),
                    new XElement("tutorname", item.Subject.Tutor),
                    new XElement("subjectname", item.Subject.Name),
                    new XElement("groupid", item.Group.Id),
                    new XElement("groupname", item.Group.ClassName),
                    new XElement("numberOfSstudents", item.Group.NumberOfSstudents),
                    new XElement("classTeacher", item.Group.ClassTeacher)));
            }

            xdoc.Save(path);
        }
    }
}
