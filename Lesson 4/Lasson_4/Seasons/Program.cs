using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = 1;
            Console.WriteLine("Введите номер месяца");
           A: mounth = Convert.ToInt32(Console.ReadLine());
            if (1 <= mounth && mounth <= 12)
            {
                string time1 = Seas_year(Mounth(mounth));
                Console.WriteLine(time1);
                Console.ReadKey();
            }
            else { Console.WriteLine("Введите номер месяца от 1 до 12");
                goto A;
            }
        }


        static string Seas_year(Seasons time)
        {
            int numb = (int)time;
            switch (numb)
            {
                case 1:
                    return "Зима";
                    
                case 2:
                    return "Весна";
                    
                case 3:
                    return "Лето";
                    
                case 4:
                    return "Осень";
                    
            }

            return "";

        }

        static Seasons Mounth(int mounth)
        {
            switch (mounth)
            {
                case 1:
                case 2:
                case 12:
                    return Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                    break;
                default:
                    Console.WriteLine("Ведите номер месяца от 1 до 12");
                    return Seasons.Winter;  // Не понимаю, что можно вернуть в этом случае кроме значения из Season/ Хотя оно здесь неуместно. Но вернуть чтото требует метод
                    break;                    
                    
            }
            
        }

    }

    
    
    enum Seasons
    {
        Winter=1,
        Spring,
        Summer,
        Autumn

     }


}
