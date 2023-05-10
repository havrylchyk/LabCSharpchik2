using SchoolTimeTable_Work_with_file_.Interface;
using SchoolTimeTable_Work_with_file_.Processing;
using System;
using System.Windows.Forms;
using System.Linq;
using SchoolTimeTable_Work_with_file_.Core;
using System.Collections.Generic;

namespace SchoolTimeTable_Work_with_file_
{
    public partial class Form1 : Form
    {

        public static Form1 Instance;

        

        public LessonProcessing lessonProcessing;
        public GroupProcessing groupprocessing;
        public SubjectProcessing subjectProcessing;
        public CallScheduleProcessing callscheduleProcessing;
        public CsvInterfaceSarvice csvInterfaceSarvice;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            groupprocessing = new GroupProcessing();
            subjectProcessing = new SubjectProcessing();
            lessonProcessing = new LessonProcessing();
            callscheduleProcessing = new CallScheduleProcessing();

            lessonProcessing.OnAddition += FillDataGridView;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ///Розклад дзвінків
            dataGridViewCall.DataSource = callscheduleProcessing.GetInfo();
        }

        private void Add_lesson_btn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(groupprocessing, lessonProcessing, subjectProcessing);//створення об'єкту форми для додавання
            addForm.Show();//виводимо вікно форми для додавання
            FillDataGridView();
        }

        public void FillDataGridView()
        {
            var tablerecorder = new List<TableRecord>();
            foreach (var lesson in lessonProcessing.lessons)
                tablerecorder.Add(new TableRecord(lesson, subjectProcessing, groupprocessing));
            
            TimeTable.DataSource = tablerecorder.ToArray();
        }

        private void Delete_Lesson_btn_Click(object sender, EventArgs e)
        {
            if (TimeTable.SelectedRows.Count > 0)
            {
                var index = TimeTable.SelectedRows[0].Index;
                //lessonProcessing.DeleteLesson(index);
                FillDataGridView();
            }
        }
    }
}
