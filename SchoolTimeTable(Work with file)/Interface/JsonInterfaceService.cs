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
            string json = File.ReadAllText(path);
            List<Lesson> lessons = JsonSerializer.Deserialize<List<Lesson>>(json);
            return lessons;
        }

        public void Write(string path, List<Lesson> data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, json);
        }
    }
}
