using SchoolTimeTable_Work_with_file_.Interface;
using SchoolTimeTable_Work_with_file_.Processing;
using System;
using System.Windows.Forms;
using System.Linq;
using SchoolTimeTable_Work_with_file_.Core;
using System.Collections.Generic;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace SchoolTimeTable_Work_with_file_
{
    public partial class Form1 : Form
    {
        private IFileService fileService;
        //private List<LessonProcessing> lessons = new List<LessonProcessing>();

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

        private void jSONToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())//відкриваємо діалогове вікно
            //{
            //    saveFileDialog.Filter = "JSON files (*.json)|*.json";//фільтр для розширень файлів
            //    saveFileDialog.RestoreDirectory = true;

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)//коли файл обрано
            //    {
            //        var data = lessonProcessing.lessons.ToArray(); // отримуємо дані з DataGridView як масив
            //        var json = JsonConvert.SerializeObject(data, Formatting.Indented); // серіалізуємо масив у формат JSON

            //        File.WriteAllText(saveFileDialog.FileName, json); // записуємо JSON у файл

            //    }
            //}

            if (!(fileService is JsonInterfaceService))
                fileService = new JsonInterfaceService();
            saveData();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";//фільтр для розширень файлів
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)//коли файл вибрано
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))//відкриваємо потік для запису у файл
                    {
                        //for (int i = 0; i < DataScienceSalariesTable.Columns.Count; i++)//цикл для запису заголовків
                        //{
                        //    streamWriter.Write(DataScienceSalariesTable.Columns[i].HeaderText);
                        //    if (i != DataScienceSalariesTable.Columns.Count - 1)//якщо стовпець не останній то ставимо між ними кому
                        //        streamWriter.Write(",");
                        //}

                        streamWriter.WriteLine();

                        //for (int i = 0; i < DataScienceSalariesTable.Rows.Count; i++)//записуємо дані з рядків таблиці
                        //{
                        //    for (int j = 0; j < DataScienceSalariesTable.Columns.Count; j++)
                        //    {
                        //        //записуємо значення з комірки в рядку
                        //        streamWriter.Write(DataScienceSalariesTable.Rows[i].Cells[j].Value.ToString());
                        //        if (j != DataScienceSalariesTable.Columns.Count - 1)//якщо стовпець не останній то ставимо між ними кому
                        //            streamWriter.Write(",");
                        //    }

                        //    streamWriter.WriteLine();// перехід до наступного рядока
                        //}
                    }
                }
            }
        }

        private void cSVToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Update_TimeTable_btn_Click(object sender, EventArgs e)
        {
            UpdataForm updateForm = new UpdataForm(groupprocessing, lessonProcessing, subjectProcessing);
            //викликаємо метод для отримання даниз з Form1 до UpdateForm
            //updateForm.GiveDataToForm(transferUpDateObject);
            updateForm.Show();
        }
    }
}
