using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masks
{
    class Program
    {
        static void Main(string[] args)
        {
            int Office1 = 0b_01111_00, // режим работы первого офиса
                Office2 = 0b_11111_11,
                Office3 = 0b_11111_00,
                constantly = 0b_11111_11, //маска для работы всю неделю
                week = 0b_11111_00; //маска для работы в будни

            if ((Office1 & constantly) == constantly) { Console.WriteLine("Офис1 работает всю неделю"); }
            else if ((Office1 & week) == week) { Console.WriteLine("Офис1 работает по будням"); }
            else { Console.WriteLine("Офис1 работает по определенным дням"); };

            if ((Office2 & constantly) == constantly) { Console.WriteLine("Офис2 работает всю неделю"); }
            else if ((Office2 & week) == week) { Console.WriteLine("Офис2 работает по будням"); }
            else { Console.WriteLine("Офис2 работает по определенным дням"); };

            if ((Office3 & constantly) == constantly) { Console.WriteLine("Офис3 работает всю неделю"); }
            else if ((Office3 & week) == week) { Console.WriteLine("Офис3 работает по будням"); }
            else { Console.WriteLine("Офис3 работает по определенным дням"); };


            Console.ReadLine();
            // Здравствуйте, Артем. Я не очень поняла, что именно требуется в задании про расписание,  решила просто написать пример применения масок.
            
        }
    }
}
