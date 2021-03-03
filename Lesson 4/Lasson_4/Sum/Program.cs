using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        A: string str = ""; //создаем строку для ввода с клавиатуры 
            while (str == "") 
            { 
            Console.WriteLine("Введите строку чисел через пробел");
            str = Console.ReadLine();
            }
            int sum = 0;
            try {  sum = Sum(str); } catch { goto A; };
            Console.WriteLine(sum);
            Console.ReadKey();
            }
                 
            
        static int Sum(string str)
        {

            int sum = 0;            
                       
                string str1 = ""; // создаем промежуточную строку для записи числа
                int i = 0;
                for (; i < str.Length; i++)
                {
                    if (str[i] != ' ')
                    {
                        str1 += str[i];
                    }
                    else
                    {
                        sum += Convert.ToInt32(str1);
                        str1 = "";
                    }

                }

                if (str1 != "")
                {
                    sum += Convert.ToInt32(str1);
                    str1 = "";
                    
                };

                return  sum;
                }

        




        
    
    }
}
