using System.Collections.Generic;
using System.IO;
using SchoolTimeTable_Work_with_file_.Core;
using System.Text;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class GroupProcessing
    {

        public List<Group> Groups;

        public GroupProcessing()
        {
            Groups = new List<Group>();
        }
        public List<Group> GetInfo()
        {
            string filePath = "C:\\Users\\Lenovo\\Desktop\\group.txt";
            string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("windows-1251"));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Group group = new Group
                {
                    ClassName = data[0],
                    NumberOfSstudents = int.Parse(data[1]),
                    ClassTeacher = data[2]
                };
                Groups.Add(group);
            }

            return Groups;
        }
    }
}
