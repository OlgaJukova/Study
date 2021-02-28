using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Return_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = { { "Петров", "Федор","Иванович"},
                                { "Лопухина", "Зинаида","Ильинична"},
                                { "Проничкин", "Дмитрий","Юрьевич"},
            };

            /*for (int i = 0; i < names.GetLength(0); i++)
            {

                string FullName = GetFullName(names[i, 0], names[i, 1], names[i, 2]);
                Console.WriteLine(FullName);
                
            };

            Console.ReadKey();
        }


        static string GetFullName(string firstname, string secondname, string patronymic )
        {
            return firstname +" "+ secondname +" "+ patronymic;
        } */



            for (int i = 0; i < names.GetLength(0); i++)
            {
                string FullName1 = GetFullName(names[i, 0], names[i, 1], names[i, 2]);
                Console.WriteLine(FullName1);
            }

            Console.ReadKey();

        }

        static string GetFullName(params string[] str)
        {
            string FullName = "";
            for (int j = 0; j < str.Length; j++)
            {
                FullName += str[j]+" ";
            }
            return FullName;
        } 
    }
}