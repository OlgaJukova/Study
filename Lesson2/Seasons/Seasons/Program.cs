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
            int maxtemp=0, mintemp=0, medtemp=0; // введенные пользователем значения температур и их среднее знвчение
            string smaxtemp, smintemp; // строковое представление переменных
            byte i=0, j=0, z=0;// вспомогательные счетчики


            while (z < 1) // Цикл для проверки того, что максимальная температура больше минимальной
            {

                while (i < 1) //ввод максимального значения, пока оно не будет корректным
                {
                    Console.WriteLine("Введите максимальную суточную температуру");
                    smaxtemp = Console.ReadLine();
                    if (Int32.TryParse(smaxtemp, out maxtemp) && (maxtemp < 91) && (maxtemp > -91))
                    {
                       i = 1;
                    }
                }

                while (j < 1) //ввод минимального значения, пока оно не будет корректным
                {
                    Console.WriteLine("Введите минимальную суточную температуру");
                    smintemp = Console.ReadLine();
                    if (Int32.TryParse(smintemp, out mintemp) && (mintemp < 91) && (mintemp > -91))
                    {
                      j = 1;
                    }
                }

                if (maxtemp > mintemp)
                {
                    medtemp=(maxtemp + mintemp) / 2;
                    Console.WriteLine("Средняя суточная температура " + (medtemp));
                    z = 1;
                }
                else
                {
                    maxtemp = 0;
                    mintemp = 0;
                    i = 0;
                    j = 0;
                    Console.WriteLine("Минимальная температура больше максимальной, повторите ввод");
                }
            }
            
            //***************************************************************************************************************************
            //*************************************************************************************************************************** 
            //***************************************************************************************************************************
            // Запрашиваем месяц года
      

        byte numbmounth = 1; // Номер месяца
        bool zima = false;    
        string smn = "",  // строка ввода месяца
               mounth = "January";

        A:  Console.WriteLine("Введите порядковый номер текущего месяца");
        smn = Console.ReadLine();
            if (Byte.TryParse(smn, out numbmounth) && (numbmounth <= 12) && (numbmounth >= 1))
            {
                switch (numbmounth)
                {
                    case 1:
                        mounth = "January";
                        zima = true;
                        break;
                    case 2:
                        mounth = "February";
                        zima = true;
                        break;
                    case 3:
                        mounth = "March";
                        break;
                    case 4:
                        mounth = "April";
                        break;
                    case 5:
                        mounth = "May";
                        break;
                    case 6:
                        mounth = "June";
                        break;
                    case 7:
                        mounth = "July";
                        break;
                    case 8:
                        mounth = "August";
                        break;
                    case 9:
                        mounth = "September";
                        break;
                    case 10:
                        mounth = "October";
                        break;
                    case 11:
                        mounth = "November";
                        break;
                    case 12:
                        mounth = "December";
                        zima = true;
                        break;


                }

                Console.WriteLine(mounth);// вывод названия месяца
                if (numbmounth % 2 == 0) { Console.WriteLine("Месяц четный"); } else { Console.WriteLine("Месяц нечетный"); } // проверка четности номера месяца
                if (zima && (medtemp>0)) { Console.WriteLine("Дождливая зима"); zima = false; };
            }
            else { Console.WriteLine("Некорректно введен номер месяца"); goto A; }
        }
    }
        
        
        
        
        
        
        
        
        
        
        }
    

