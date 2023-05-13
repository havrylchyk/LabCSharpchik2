using SchoolTimeTable_Work_with_file_.Processing;
using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolTimeTable_Work_with_file_
{
    public partial class AddForm : Form
    {
        private GroupProcessing groupProcessing;
        private SubjectProcessing subjectProcessing;
        public LessonProcessing lessonProcessing;

        public AddForm(GroupProcessing groupProcessing, LessonProcessing lessonProcessing, SubjectProcessing subjectProcessing)
        {            
            InitializeComponent();
            this.groupProcessing = groupProcessing;
            this.subjectProcessing = subjectProcessing;
            this.lessonProcessing = lessonProcessing;
            
            List<Group> groups = groupProcessing.GetInfo();
            foreach (Group group in groups)
            {
                comboBoxClass.Items.Add(group);
            }
            comboBoxClass.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            
            List<Subject> subject = subjectProcessing.GetInfo();
            foreach (Subject subjects in subject)
            {
                comboBoxSublect.Items.Add(subjects);
            }
            comboBoxSublect.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged_1);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           
        }
        private static int count = 1;
        private static int countid = 3000;
        private void Apply_button_Addform_Click(object sender, EventArgs e)
        {
            lessonProcessing.AddItem(new Lesson
            {
                Id = countid,
                SequenceNumber = count,
                Subject = subjectProcessing.GetSubject(((Subject)comboBoxSublect.SelectedItem).Id),
                Group = groupProcessing.GetGroup(((Group)comboBoxClass.SelectedItem).Id)
            });
            count++;
            countid++;
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
    }
}

