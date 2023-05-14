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
        private List<Lesson> lessons;

        List<Group> groups = new List<Group>();
        List<Subject> subject = new List<Subject>();

        private GroupProcessing groupProcessing;
        private SubjectProcessing subjectProcessing;
        public LessonProcessing lessonProcessing;

        public UpdataForm(List<TableRecord> records)
        {
            InitializeComponent();
            recordsToUpdate = records;

        }

        public UpdataForm(List<Lesson> lessons)
        {
            InitializeComponent();
            this.lessons = lessons;
        }
        
        public UpdataForm(List<TableRecord> records, GroupProcessing groupProcessing, LessonProcessing lessonProcessing, SubjectProcessing subjectProcessing)
        {
            InitializeComponent();
            this.recordsToUpdate = records;
            this.groupProcessing = groupProcessing;
            this.lessonProcessing = lessonProcessing;
            this.subjectProcessing = subjectProcessing;

            groups = groupProcessing.GetInfo();
            foreach (Group group in groups)
            {
                comboBoxClass_Upform.Items.Add(group);
            }
            comboBoxClass_Upform.SelectedIndexChanged += new EventHandler(comboBoxClass_Upform_SelectedIndexChanged);

            subject = subjectProcessing.GetInfo();
            foreach (Subject subjects in subject)
            {
                comboBoxSubject_Upform.Items.Add(subjects);
            }
            comboBoxSubject_Upform.SelectedIndexChanged += new EventHandler(comboBoxSubject_Upform_SelectedIndexChanged);
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Group selectedGroup = (Group)comboBoxClass_Upform.SelectedItem;
        //    Amount_of_Student_textBox_Upform.Text = selectedGroup.NumberOfSstudents.ToString();
        //    Class_theacher_textBox_Upform.Text = selectedGroup.ClassTeacher;
        //}

        //private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    Subject selectedsubject = (Subject)comboBoxSubject_Upform.SelectedItem;
        //    Id_of_Subject_textBox_Upform.Text = selectedsubject.Id.ToString();
        //    Tutor_textBox_Upform.Text = selectedsubject.Tutor;
        //}

        public void GetDataToUpform(Lesson lesson)
        {
            SequenceNumtextBox_Upform.Text = lesson.SequenceNumber.ToString();
          
        }

        private void Apply_button_Upform_Click(object sender, EventArgs e)
        {

        }

        private void Closebutton_Upform_Click(object sender, EventArgs e) { Close(); }

        private void comboBoxSubject_Upform_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject selectedsubject = (Subject)comboBoxSubject_Upform.SelectedItem;
            Id_of_Subject_textBox_Upform.Text = selectedsubject.Id.ToString();
            Tutor_textBox_Upform.Text = selectedsubject.Tutor;
        }

        private void comboBoxClass_Upform_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup = (Group)comboBoxClass_Upform.SelectedItem;
            Amount_of_Student_textBox_Upform.Text = selectedGroup.NumberOfSstudents.ToString();
            Class_theacher_textBox_Upform.Text = selectedGroup.ClassTeacher;
        }
    }
}