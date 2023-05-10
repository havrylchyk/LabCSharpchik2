using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTimeTable_Work_with_file_
{
    public interface IFileService
    {
        //string ShowOpenFileDialog();
        void ReadFile(string filePath);
        void WriteFile(string filePath, string content);
    }
}
