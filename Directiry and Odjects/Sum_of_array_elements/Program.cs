using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_array_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = { {"34","4","-9","17" },
                                {"54","hj","1","25" },
                                {"-90","43","-9","87" },
                                {"-140","2","-1","-5" }};

            int sum = 0;
            sum = Sum(array);
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        static int Sum(string [,] array)
        {
            int sum = 0,// инициализируем переменную под сумму
                element = 0;// инициализируем переменную под промежуточный элемент массива
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    try { element = Convert.ToInt32(array[i, j]); } 
                    catch 
                    { 
                        Console.WriteLine("Ошибка считывания элемента на позиции "+(i+1)+", "+(j+1));
                        goto A;                           ;
                    };

                    sum += element;
                }

            }
            return sum;
        }
    }
}
