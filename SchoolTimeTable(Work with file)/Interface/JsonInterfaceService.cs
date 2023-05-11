using SchoolTimeTable_Work_with_file_.Core;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//
namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class JsonInterfaceService : IFileService
    {
        public JsonInterfaceService()
        {
            Filter = "JSON Product file (.json)|*.json";
        }
        public string Filter { get; set; }
        public List<Lesson> Read(string path)
        {
            string json = File.OpenText(path).ReadToEnd();
            List<Lesson> products = JsonSerializer.Deserialize<List<Lesson>>(json);
            return products;
        }

        public void Write(string path, List<Lesson> data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(path, json);
        }
    }
}
