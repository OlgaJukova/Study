using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Введите ваше имя"); 
            username = Console.ReadLine();
           //while (String.IsNullOrEmpty(username))
           while (username=="") // проверяем, ввел ли пользователь имя
            {
                Console.WriteLine("Введите ваше имя");// запрашиваем опять, если не ввел
                username = Console.ReadLine();
            }
          Console.WriteLine($"Привет, {username}, сегодня {DateTime.Today}" ); // выводим на экран

        }
    }
}
