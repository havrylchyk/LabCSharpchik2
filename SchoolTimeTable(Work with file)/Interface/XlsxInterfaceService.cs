using OfficeOpenXml;
using SchoolTimeTable_Work_with_file_.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_.Interface
{
    public class XlsxInterfaceService : IFileService
    {
        public XlsxInterfaceService()
        {
            Filter = "MS Excel Product file (.xlsx)|*.xlsx";
        }
        public string Filter { get; set; }

        public List<Lesson> Read(string path)
        {
            List<Lesson> lessons = new List<Lesson>();

            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Lesson"];

                // отримуємо номер останнього рядка з даними
                int lastRow = worksheet.Dimension.End.Row;

                for (int row = 1; row <= lastRow; row++)
                {
                    Lesson lesson = new Lesson()
                    {
                        Id = worksheet.Cells[row, 1].GetValue<int>(),
                        SequenceNumber = worksheet.Cells[row, 2].GetValue<int>(),
                        Subject = new Subject()
                        {
                            Id = worksheet.Cells[row, 3].GetValue<int>(),
                            Name = worksheet.Cells[row, 4].GetValue<string>(),
                            Tutor = worksheet.Cells[row, 5].GetValue<string>(),
                        },
                        Group = new Group()
                        {
                            Id = worksheet.Cells[row, 6].GetValue<int>(),
                            ClassName = worksheet.Cells[row, 7].GetValue<string>(),
                            NumberOfSstudents = worksheet.Cells[row, 8].GetValue<int>(),
                            ClassTeacher = worksheet.Cells[row, 9].GetValue<string>()
                        }
                    };
                    lessons.Add(lesson);
                }
            }
            return lessons;
        }

        public void Write(string path, List<Lesson> data)
        {
            using (var package = new ExcelPackage(path))
            {
                var sheet = package.Workbook.Worksheets.Add("Lesson");
                for (int i = 0; i < data.Count; i++)
                {
                    sheet.Cells[i + 1, 1].Value = data[i].Id;
                    sheet.Cells[i + 1, 2].Value = data[i].SequenceNumber;
                    sheet.Cells[i + 1, 3].Value = data[i].Subject.Id;
                    sheet.Cells[i + 1, 4].Value = data[i].Subject.Name;
                    sheet.Cells[i + 1, 5].Value = data[i].Subject.Tutor;
                    sheet.Cells[i + 1, 6].Value = data[i].Group.Id;
                    sheet.Cells[i + 1, 7].Value = data[i].Group.ClassName;
                    sheet.Cells[i + 1, 8].Value = data[i].Group.NumberOfSstudents;
                    sheet.Cells[i + 1, 9].Value = data[i].Group.ClassTeacher;
                }
                package.Save();
            }

        }
    }
}

