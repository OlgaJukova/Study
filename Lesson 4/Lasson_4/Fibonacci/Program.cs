using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int n1 = 0, n2 = 1, n3 = 1, i = 1, n = 15;
                string str = "";

            (n1, n2, n3, n, i, str) = Fibonacci(0, 1, 1, 15, 1, str);

            Console.WriteLine(str);
            Console.ReadKey();

        }



        static (int n1, int n2, int n3,int n,int i, string str) Fibonacci( int n1, int n2, int n3, int n, int i,string str)
        {
            if (i <= n)
            {
                n3 = n2 + n1;
                str += (" " + Convert.ToString(n3));
                n1 = n2;
                n2 = n3;
                i++;
                return (n1, n2, n3, n,i, str) = Fibonacci(n1, n2, n3, n,i, str);
            } else
            {
               return  Fibonacci(n1, n2, n3, n, i, str);
            }


        }
    
    
    
    
    }
}
