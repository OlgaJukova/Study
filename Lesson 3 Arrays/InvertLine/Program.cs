using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertLine
{
    class Program
    {
        static void Main(string[] args)
        {

            String line = "";

            while (line.Length == 0)
            {
                Console.WriteLine("Ведите строку");
                line = Console.ReadLine();

                if (line.Length > 0)

                {
                    for (int j = line.Length - 1; j >= 0; j--)
                    {
                        Console.Write(line[j]);

                    }
                    Console.ReadLine();
                }
            }
            
        }
    }
}
