using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bin_file
{
    class Program
    {
        static void Main(string[] args)
        {
            A:  string str = "";
            Console.WriteLine("Введите набор чисел через пробел");
            str = Console.ReadLine();
            string[] arr_str = str.Split(' ');
            byte[] arr_numb = new byte[arr_str.Length];

            
            for (int i = 0; i < arr_numb.Length; i++)
            {
                try { arr_numb[i] = Convert.ToByte(arr_str[i]); } catch { Console.WriteLine( "Ошибка ввода"); goto A;  };
            }

            File.WriteAllBytes("Numbers.bin", arr_numb);

            Console.WriteLine("Чтение из файла:");

            byte[] from_file = File.ReadAllBytes("Numbers.bin");

            for (int j = 0; j< from_file.Length; j++)
            {
                Console.Write(from_file[j]+" ");

            }
                Console.ReadKey();




        }

        
        
    }
}
