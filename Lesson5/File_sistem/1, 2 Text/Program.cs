using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1__2_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt",
                   str = "";

            Console.WriteLine("Введите строку для записи в файл");
            str = Console.ReadLine();
            File.WriteAllText(filename, str);
            Console.ReadKey();

            /////////////////////////////
            DateTime time = DateTime.Now;
            string str_time = time.ToString("HH:mm");
            File.AppendAllLines(filename, new[] { str_time });

            Console.WriteLine("В файле:" );
            string file_text = File.ReadAllText(filename);
            Console.WriteLine(  file_text);
            Console.ReadKey();
        }
    }
}
