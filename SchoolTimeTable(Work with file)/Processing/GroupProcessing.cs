using System.Collections.Generic;
using System.IO;
using SchoolTimeTable_Work_with_file_.Core;
using System.Text;
using System;
using System.Linq;

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
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data", "group.txt");
            string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("windows-1251"));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Group group = new Group
                {
                    Id = int.Parse(data[0]),
                    ClassName = data[1],
                    NumberOfSstudents = int.Parse(data[2]),
                    ClassTeacher = data[3]
                };
                Groups.Add(group);
            }

            return Groups;
        }

        public Group GetGroup(int id)
        {
            return Groups.FirstOrDefault(group => group.Id == id);
        }
    }
}
