using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class LessonProcessing
    {
        public List<Lesson> lessons = new List<Lesson>();

        public event Action OnAddition; // делеагат(поле, яка зберігає ссилку на метод), який визивається при додаванні об'єкта
        
        public LessonProcessing() { }
      
        public List<Lesson> GetData()
        {
            return lessons;
        }

        public void AddItem(Lesson lesson)
        {
            lessons.Add(lesson);
            OnAddition?.Invoke();
        }
        public void UpdataItem(Lesson lesson)
        {
            var updata = lessons.Find(x => x.Id == lesson.Id);
            updata.Subject = lesson.Subject;
            updata.Group = lesson.Group;
            OnAddition?.Invoke();
        }
    }
}