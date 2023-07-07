using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo($@"D:\\c#\\sample.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("hello");
            Console.WriteLine("Written");

           
        } 
        public void DeleteFile()
        {
            FileInfo fi = new FileInfo($@"D:\\c#\\programsample.txt");
            fi.Delete();
        }
        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("D:\\c#\\sample.txt");
           // FileInfo fi2 = new FileInfo("D:\\c#\\temp\\" + "sample.txt");
           // fi1.CopyTo("D:\\c#\\temp\\" + "sample1.txt");
            fi1.MoveTo("D:\\c#\\temp\\sample.txt");
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\c#\\temp\\sample.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter the text which" + "You want to write ");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("D:\\c#\\temp\\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin); 
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            
            sr.Close();
            fs.Close();

        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("D:\\c#\\temp\\sample.txt");
            Console.WriteLine("File name is" + $"{ fi.Name}");
            Console.WriteLine("File length is" + $"{fi.Length}");
            Console.WriteLine("File Creation time is" + $"{fi.CreationTime.ToLongTimeString}");
            Console.WriteLine("File extension  is" + $"{fi.Extension}");
            Console.WriteLine("File exists is" + $"{fi.Exists}");
            Console.WriteLine("File Last access time is" + $"{fi.LastAccessTime}");

        }
    }
}
