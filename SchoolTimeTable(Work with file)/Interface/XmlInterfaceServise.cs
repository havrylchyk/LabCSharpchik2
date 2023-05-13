using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class XmlInterfaceServise
    {
        
        public XmlInterfaceServise()
        {
            Filter = "XML Product file (xml)|*.xml";
        }
        public string Filter { get; set; }

        public List<Lesson> Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(string path, List<Lesson> data)
        {
            XDocument xdoc = new XDocument();
            xdoc.Declaration = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Add(new XElement("products"));

            foreach (var item in data)
            {
                xdoc.Root.Add(new XElement("product",
                    new XAttribute("id", item.Id),
                    new XElement("name", item.SequenceNumber),
                    new XElement("price", item.Subject.Id),
                    new XElement("name", item.Subject.Tutor),
                    new XElement("name", item.Group.Id),
                    new XElement("name", item.Group.ClassName),
                    new XElement("name", item.Group.NumberOfSstudents),
                    new XElement("name", item.Group.ClassTeacher)));
            }

            xdoc.Save(path);
        }
    }
}
