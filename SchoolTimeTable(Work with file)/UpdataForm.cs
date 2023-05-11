using SchoolTimeTable_Work_with_file_.Core;
using SchoolTimeTable_Work_with_file_.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SchoolTimeTable_Work_with_file_
{
    
    public partial class UpdataForm : Form
    {
        private List<TableRecord> recordsToUpdate;

        public UpdataForm(List<TableRecord> records)
        {
            InitializeComponent();
            recordsToUpdate = records;

            // Використовуйте дані з recordsToUpdate для заповнення полів форми
            foreach (TableRecord record in recordsToUpdate)
            {
                // Заповнення полів форми з використанням даних з record
            }
        }
        private GroupProcessing groupProcessing;
        private SubjectProcessing subjectProcessing;
        public LessonProcessing lessonProcessing;

        public UpdataForm(GroupProcessing groupProcessing, LessonProcessing lessonProcessing, SubjectProcessing subjectProcessing)
        {
            InitializeComponent();
            this.groupProcessing = groupProcessing;
            this.subjectProcessing = subjectProcessing;
            this.lessonProcessing = lessonProcessing;

            List<Group> groups = groupProcessing.GetInfo();
            foreach (Group group in groups)
            {
                comboBoxClass_Upform.Items.Add(group);
            }
            comboBoxClass_Upform.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            List<Subject> subject = subjectProcessing.GetInfo();
            foreach (Subject subjects in subject)
            {
                comboBoxSubject_Upform.Items.Add(subjects);
            }
            comboBoxSubject_Upform.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged_1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup = (Group)comboBoxClass_Upform.SelectedItem;
            //Amount_of_Student_textBox_Addform.Text = selectedGroup.NumberOfSstudents.ToString();
            //Class_theacher_textBox_Addform.Text = selectedGroup.ClassTeacher;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Subject selectedsubject = (Subject)comboBoxSubject_Upform.SelectedItem;
            Id_of_Subject_textBox_Upform.Text = selectedsubject.Id.ToString();
            Tutor_textBox_Upform.Text = selectedsubject.Tutor;
        }
        public void GetDataToUpform(TableRecord tableRecord)
        { 
            SequenceNumtextBox_Upform.Text = Convert.ToString(tableRecord.NummerOfLesson);
            //comboBoxSubject_Upform = tableRecord.Subject;
            Subject selectedsubject = (Subject)comboBoxSubject_Upform.SelectedItem;
            Id_of_Subject_textBox_Upform.Text = selectedsubject.Id.ToString();
            Tutor_textBox_Upform.Text = selectedsubject.Tutor;
        }
        private void Apply_button_Upform_Click(object sender, EventArgs e)
        {
            //lessonProcessing.AddItem(new Lesson
            //{
            //    SequenceNumber = count,
            //    Subject = ((Subject)comboBoxSublect.SelectedItem).Id,
            //    Group = ((Group)comboBoxClass.SelectedItem).Id
            //});
            //count++;
        }

      
        /*
* private void Apply_button_Upform_Click(object sender, EventArgs e)
{
   if (TextBoxContentVerification() == true)//перевірка даних на правильність
   {
       TransferUpDateObject transferUpDateObject = new TransferUpDateObject();//Створюємо об'кт класу TransferUpDateObject 
       //Вновисо дані до об'єкту
       transferUpDateObject.Index = index;
       transferUpDateObject.SubjectId = Int32.Parse(SequenceNumtextBox_Upform.Text);
       transferUpDateObject.Time = Time_of_Subgect_textBox_Upform.Text;
       transferUpDateObject.SubjectName = Name_of_subject_textBox_Upform.Text;
       transferUpDateObject.Teacher = Class_theacher_textBox_Upform.Text;
       transferUpDateObject.SubjectId = Int32.Parse(Id_of_Subject_textBox_Upform.Text);
       transferUpDateObject.ClassName = Class_textBox_Upform.Text;
       transferUpDateObject.StudentsAmount = Int32.Parse(Amount_of_Student_textBox_Upform.Text);
       transferUpDateObject.ClassTeacher = Class_theacher_textBox_Upform.Text;
       Form1.Instance.GetDataToUpDate(transferUpDateObject);//Звертаємось до методу для перезапису оновлених даних
       Close();
   }
}

public void GiveDataToForm(TransferUpDateObject transferUpDateObject)//Метод для отримання даних з Form1
{

   index = transferUpDateObject.Index;
   SequenceNumtextBox_Upform.Text = Convert.ToString(transferUpDateObject.SequenceNumb);
   Time_of_Subgect_textBox_Upform.Text = transferUpDateObject.Time;
   Name_of_subject_textBox_Upform.Text = transferUpDateObject.SubjectName;
   Tutor_textBox_Upform.Text = transferUpDateObject.Teacher;
   Id_of_Subject_textBox_Upform.Text = Convert.ToString(transferUpDateObject.SubjectId);
   Class_textBox_Upform.Text = transferUpDateObject.ClassName;
   Amount_of_Student_textBox_Upform.Text = Convert.ToString(transferUpDateObject.StudentsAmount);
   Class_theacher_textBox_Upform.Text = transferUpDateObject.ClassTeacher;

}
*/
        ///
        /*
         private void Apply_button_Addform_Click(object sender, EventArgs e)
        {
            lessonProcessing.AddItem(new Lesson
            {
                SequenceNumber = count,
                Subject = ((Subject)comboBoxSublect.SelectedItem).Id,
                Group = ((Group)comboBoxClass.SelectedItem).Id
            });     
            count++;
        }
        private void Closebutton_Click(object sender, EventArgs e) { Close(); }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup = (Group)comboBoxClass.SelectedItem;
            Amount_of_Student_textBox_Addform.Text = selectedGroup.NumberOfSstudents.ToString();
            Class_theacher_textBox_Addform.Text = selectedGroup.ClassTeacher;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Subject selectedsubject = (Subject)comboBoxSublect.SelectedItem;
            Id_of_Subject_textBox_Addform.Text = selectedsubject.Id.ToString();
            Tutor_textBox_Addform.Text = selectedsubject.Tutor;
        }
         */
    }
}
