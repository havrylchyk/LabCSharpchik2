using SchoolTimeTable_Work_with_file_.Core;
using System.ComponentModel;

namespace SchoolTimeTable_Work_with_file_.Processing
{
    public class TableRecord
    {
        [DisplayName("Номер уроку")]
        public int NummerOfLesson => Lesson.SequenceNumber;
        public Subject Subject => subjectProcessing.GetByGUID(Lesson.Subject);
        public Group Group => groupProcessing.GetByGUID(Lesson.Group);

        private Lesson Lesson { get; set; }
        private SubjectProcessing subjectProcessing;
        private GroupProcessing groupProcessing;

        public TableRecord(Lesson lesson, SubjectProcessing subjectProcessing, GroupProcessing groupProcessing)
        {
            Lesson = lesson;
            this.subjectProcessing = subjectProcessing;
            this.groupProcessing = groupProcessing;
        }
    }
}
