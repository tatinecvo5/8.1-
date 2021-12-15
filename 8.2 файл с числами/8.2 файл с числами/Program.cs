using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8._2_файл_с_числами
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i] = random.Next(0, 10);
               // Console.Write("{0} ", array[i]);
                string path = "Log/Log.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(array[i]);
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.Write(sr.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
