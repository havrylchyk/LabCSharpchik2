using SchoolTimeTable_Work_with_file_.Interface;
using SchoolTimeTable_Work_with_file_.Processing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SchoolTimeTable_Work_with_file_.Core;

namespace SchoolTimeTable_Work_with_file_
{
    public partial class Form1 : Form
    {
        private IFileService fileService;

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

            fileService = new XlsxInterfaceService();
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
        
        private void Update_TimeTable_btn_Click(object sender, EventArgs e)
        {
            UpdataForm updateForm = new UpdataForm(groupprocessing, lessonProcessing, subjectProcessing);
            //викликаємо метод для отримання даниз з Form1 до UpdateForm
            //updateForm.GiveDataToForm(transferUpDateObject);
            updateForm.Show();
        }

        public void FillDataGridView()
        {
            var tablerecorder = new List<TableRecord>();
            foreach (var lesson in lessonProcessing.lessons)
                tablerecorder.Add(new TableRecord(lesson, subjectProcessing, groupprocessing));

            TimeTable.DataSource = tablerecorder.ToArray();
        }
        
        public void RefreshTable()
        {
            TimeTable.ClearSelection();
            FillDataGridView();
        }
        
        void saveData()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = fileService.Filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                try
                {
                    fileService.Write(fileName, lessonProcessing.lessons);
                    MessageBox.Show("Data Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        void openData()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = fileService.Filter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lessonProcessing.lessons = fileService.Read(dialog.FileName);
                TimeTable.ClearSelection();
            }
            FillDataGridView();
        }
        
        private void Delete_Lesson_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = TimeTable.CurrentRow.Index;//Отримуємо індекс
                lessonProcessing.lessons.Remove(lessonProcessing.lessons[index]);//Видаляємо урок зі списку
                RefreshTable();
            }
            catch (Exception ex)//У разі винекнені неполадок видасть інформацію про помилку
            {
                MessageBox.Show("Some error " + ex.Message + "-" + ex.Source);
            }
        }

        ///Запис до файлу
        private void jSONToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!(fileService is JsonInterfaceService))
                fileService = new JsonInterfaceService();
            saveData();
        }    

        private void cSVToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            if (!(fileService is CsvInterfaceSarvice))
                fileService = new CsvInterfaceSarvice();
            saveData();
        }

        private void tXTToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            if (!(fileService is TxtInterfaceServise))
                fileService = new TxtInterfaceServise();
            saveData();
        }

        private void xLSXToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!(fileService is XlsxInterfaceService))
                fileService = new XlsxInterfaceService();
            saveData();
        }

        private void xMLToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!(fileService is XmlInterfaceServise))
                fileService = new XmlInterfaceServise();
            saveData();
        }

        ///Запис до файлу
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(fileService is JsonInterfaceService))
                fileService = new JsonInterfaceService();
            openData();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(fileService is CsvInterfaceSarvice))
                fileService = new CsvInterfaceSarvice();
            openData();
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(fileService is TxtInterfaceServise))
                fileService = new TxtInterfaceServise();
            openData();
        }

        private void xLSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(fileService is XlsxInterfaceService))
                fileService = new XlsxInterfaceService();
            openData();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(fileService is XmlInterfaceServise))
                fileService = new XmlInterfaceServise();
            openData();
        }
      
    }
}
