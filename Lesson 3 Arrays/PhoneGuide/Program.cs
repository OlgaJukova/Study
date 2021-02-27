using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneGuide
{
    class Program
    {
        static void Main(string[] args)
        {
               string[,] PhoneGuide = { {"Иванов","8-905-345-4586" },
                                        {"Петров","8-905-376-9695" },
                                        {"Сидоров","8-903-765-0357" },
                                        {"Кузнецов","8-920-876-8694" },
                                        {"Степнов","8-904-456-8956" }};


            for (int i = 0; i < PhoneGuide.GetLength(0); i++)
            {
                Console.WriteLine(PhoneGuide[i,0]+" "+PhoneGuide[i,1]);     
            }
            Console.ReadLine();


            /* PhoneGuide[0] = new string[2] {"Иванов", };
             PhoneGuide[1] = new string[2];
             PhoneGuide[2] = new string[2];
             PhoneGuide[3] = new string[2];
             PhoneGuide[4] = new string[2];
             //PhoneGuide[0][0] = "Иванов"; PhoneGuide [0][1]="8-905-656-3487"; */

            // int[,] a = new int[5,2];


            

        }
    }
}
