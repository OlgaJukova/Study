using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 51, 0, 8, 90, -7, 56, 5, 7};
            int n =-10 ,
                n1 = 0,// счетчик количества итерраций сдвига массива на 1
                n2 = 0;// вспомогательная переменная для пересмотра количества сдвигов, если n превышает длину массива

            Console.Write("Исходный массив:     ");
            for (int z = 0; z < mas.Length; z++)
            {
                Console.Write(mas[z] + " ");
            };

                       
            
           if (n >= 0)
            {

                if (n > mas.Length)  { n2 = n - mas.Length; }   else { n2 = n; }; // уменьшаем количество итерраций, если n больше длины массива

                n1 = 1; // счетчик количества итерраций сдвига массива на 1
                int x = 0;
                while (n1 <= n2)
                {
                     x = mas[mas.Length - 1]; //запоминаем последний элемент массива
                    for (int i = (mas.Length-1); i >0 ; i--)
                    {
                        mas[i] = mas[i - 1];


                    };
                    n1++;
                    mas[0] = x;
                };
                

                Console.WriteLine("\n");
                Console.Write("Со cдвигом на "+n+":      ");

                for (int j=0; j < mas.Length; j++)
                {
                    Console.Write(mas[j]+" ");
                };
                Console.ReadLine();
            };


            if (n < 0)
            {
                int nAbs = Math.Abs(n); // вычисляем абсолютное число сдвигов влево
                if (nAbs > mas.Length) { n2 = nAbs - mas.Length; } else { n2 = nAbs; }; // уменьшаем количество итерраций, если n больше длины массива

                n1 = 1; // счетчик количества итерраций сдвига массива на 1
                int x = 0;
                while (n1 <= n2)
                {
                    x = mas[0]; //запоминаем первый элемент массива
                    for (int i =0 ; i < (mas.Length - 1) ; i++)
                    {
                        mas[i] = mas[i + 1];


                    };
                    n1++;
                    mas[(mas.Length - 1)] = x;
                };


                Console.WriteLine("\n");
                Console.Write("Со cдвигом на " + n + ":      ");

                for (int j = 0; j < mas.Length; j++)
                {
                    Console.Write(mas[j] + " ");
                };
                Console.ReadLine();
            };









        }
    }
}
