using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _8._1_папки
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = @"D:\VisualStudio\01";
            //FileInfo file = new FileInfo(ad);
            if (Directory.Exists(ad))
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(ad);
                foreach (string dirname in dirs)
                {
                    Console.WriteLine(dirname);
                }
                //FileInfo file = new FileInfo(ad);
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(ad);
                //string[] files = FileInfo.Name(ad);
                foreach (string filename in files)
                {
                    Console.WriteLine(filename);
                }
            }
            else
            {
                Console.WriteLine("Папка не найдена");
            }
            Console.ReadKey();
        }
    }
}
