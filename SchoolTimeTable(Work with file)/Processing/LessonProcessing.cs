using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class LessonProcessing
    {
        public List<Lesson> lessons = new List<Lesson>();

        public List<TableRecord> recordsToUpdate;

        public event Action OnAddition; // делеагат(поле, яка зберігає ссилку на метод), який визивається при додаванні об'єкта

        public LessonProcessing()
        {

        }

        public LessonProcessing(List<TableRecord> records)
        {
            recordsToUpdate = records;
        }

        public List<TableRecord> GetData()
        {
            return recordsToUpdate;
        }

        public void AddItem(Lesson lesson)
        {
            lessons.Add(lesson);
            OnAddition?.Invoke();
        }
        public void UpdataItem(Lesson lesson)
        {
            lessons.Add(lesson);
            OnAddition?.Invoke();
        }
        //public Lesson GetByGUID(Guid id)
        //{
        //    return lessons.FirstOrDefault(lesson => lesson.Id == id);
        //}
    }
}