using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            char [,] Field = new char[10, 10]; // создаем массив для игрового поля
            Random rand = new Random(); 


            for (int i = 0; i < Field.GetLength(0); i++)  // заполняем поле нулями
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Field[i, j] = 'o';
                }

            };


            int[,] Mark = new int[10, 10]; // массив для маркирования занятых позиций

            for (int i = 0; i < Mark.GetLength(0); i++)  // заполняем массив нулями
            {
                for (int j = 0; j < Mark.GetLength(1); j++)
                {
                    Mark[i, j] = 0;
                }

            };



            //строим 4-палубный корабль

            {
                bool poss = false;
                int direction = 0,
                    i = 0, j = 0;

                while (poss == false)
                {
                    direction = rand.Next(1, 4); // выбираем направление построения корабля 1-вправо, 2-вниз, 3 - влево, 4-вверх
                    i = rand.Next(0, 9); j = rand.Next(0, 9); // выбираем случайные координаты точки построения


                    switch (direction) //  проверяем, можно ли построить от заданной точки в заданном направлении 4-палубный корабль
                    {
                        case 1:
                            if (i + 3 <= 9) { poss = true; };
                            break;
                        case 2:
                            if (j + 3 <= 9) { poss = true; };
                            break;
                        case 3:
                            if (i - 3 >= 0) { poss = true; };
                            break;
                        case 4:
                            if (j - 3 >= 0) { poss = true; };
                            break;
                    }

                }

                switch (direction) // строим корабль
                {
                    case 1:
                        for (int n = i; n <= i + 3; n++)
                        { Field[n, j] = 'X';
                          Mark[n, j] = 1;// маркируем занятые позиции
                        };
                        break;
                    case 2:
                        for (int n = j; n <= j + 3; n++)
                        { Field[i, n] = 'X';
                          Mark[i, n] = 1;// маркируем занятые позиции
                        };
                        break;
                    case 3:
                        for (int n = i - 3; n <= i; n++)
                        { Field[n, j] = 'X';
                          Mark[n, j] = 1;// маркируем занятые позиции
                        };
                        break;
                    case 4:
                        for (int n = j - 3; n <= j; n++)
                        { Field[i, n] = 'X';
                          Mark[j, n] = 1;// маркируем занятые позиции
                        };
                        break;
                }

            
             
                    
            
            
            
            
            
            }

            //////////////////////////////////




            for (int i = 0; i < Field.GetLength(0); i++)  // вывод поля на экран
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Console.Write(Field[i,j]+" "); ;
                }
                Console.WriteLine();
            };


            Console.WriteLine();
            for (int i = 0; i < Mark.GetLength(0); i++)  // вывод mark на экран
            {
                for (int j = 0; j < Mark.GetLength(1); j++)
                {
                    Console.Write(Mark[i, j] + " "); ;
                }
                Console.WriteLine();
            };


            Console.ReadKey(true);


        }

        }
}
