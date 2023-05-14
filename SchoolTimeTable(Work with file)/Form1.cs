using SchoolTimeTable_Work_with_file_.Interface;
using SchoolTimeTable_Work_with_file_.Processing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SchoolTimeTable_Work_with_file_.Core;
using System.IO;
using System.Text;
using System.Xml;
using System.Linq;

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

        private List<Lesson> lessons = new List<Lesson>();

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

            //this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
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
            int index = TimeTable.CurrentRow.Index;
            Lesson lesson = lessons[index];
            UpdataForm updataForm = new UpdataForm(lessonProcessing);
            updataForm.GetDataToUpform(lesson);
            updataForm.Show();
        }

        public void FillDataGridView()
        {
            var tablerecorder = new List<TableRecord>();
            foreach (var lesson in lessonProcessing.lessons)
                tablerecorder.Add(new TableRecord(lesson, subjectProcessing, groupprocessing));

            TimeTable.DataSource = tablerecorder.ToArray();
            
            // Додайте всі уроки до списку lessons
            lessons = lessonProcessing.lessons.ToList();
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

        ///Зчитування з файлу
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


        ///Створення 
        private string filepath = "";
        private void tXTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    if (!(fileService is TxtInterfaceServise))
                        fileService = new TxtInterfaceServise();

                }
            }
        }

        private void xMLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    if (!(fileService is XmlInterfaceServise))
                        fileService = new XmlInterfaceServise();
                }

            }
        }

        private void cSVToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Lesson file (.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    if (!(fileService is CsvInterfaceSarvice))
                        fileService = new CsvInterfaceSarvice();
                }

            }
        }

        private void jSONToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Lesson file (.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    if (!(fileService is JsonInterfaceService))
                        fileService = new JsonInterfaceService();
                }

            }
        }

        private void xLSXToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MS Excel Lesson file (.xlsx)|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    if (!(fileService is XlsxInterfaceService))
                        fileService = new XlsxInterfaceService();
                }

            }
        }

        //Збереження
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileService.Write(filepath, lessonProcessing.lessons);
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                fileService.Write(filepath, lessonProcessing.lessons);
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private bool dataChanged = false;

        //// Метод, який буде викликатися при зміні даних у DataGridView
        //private bool unsavedChanges = false;

        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Позначаємо, що є незбережені зміни
        //    unsavedChanges = true;
        //}

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (unsavedChanges)
        //    {
        //        // Якщо є незбережені зміни, запитуємо користувача про їх збереження
        //        var result = MessageBox.Show("Do you want to save changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);

        //        if (result == DialogResult.Cancel)
        //        {
        //            // Якщо користувач натиснув "Cancel", відміняємо закриття форми
        //            e.Cancel = true;
        //        }
        //        else if (result == DialogResult.Yes)
        //        {
        //            // Якщо користувач натиснув "Yes", зберігаємо дані та закриваємо форму
        //            saveDataForm();
        //        }
        //    }
        //}

        //private void saveDataForm()
        //{
        //    // Зберігаємо дані
        //    try
        //    {
        //        fileService.Write(filepath, lessonProcessing.lessons);
        //        MessageBox.Show("Data Saved");
        //        dataChanged = false; // Позначаємо, що зміни збережені
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

    }
}