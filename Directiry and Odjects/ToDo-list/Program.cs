using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;



namespace ToDo_list
{
    class Program
    {
        static void Main(string[] args)
        {
           // ToDo todo = new ToDo();

            ToDo [] todolist = new ToDo [5]; // сосздаем массив задач
            string path= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tasks.json");//путь , где лежит файл с задачами
            
        /*    if ( File.Exists(path))// проверяем, имеется ли в текущей дирректории файл с задачами
                {
                Console.WriteLine(); 
            }

            /// При отсутствии файла с задачами выполняем:

            /*
             for (int i=0; i< todolist.Length; i++)
             {
                 todolist[i] = new ToDo("Task" + Convert.ToString(i++));
             } 
            

              ??? почему то когда происходит цикл, при последующем их выводе на экран программа начинает ругаться, что объекты [1] и [3] имеют ссылку null
            */

            
            todolist[0] = new ToDo("Task1"); // инициализируем 5 задач пока не выполненных
            todolist[1] = new ToDo("Task2");
            todolist[2] = new ToDo("Task3");
            todolist[3] = new ToDo("Task4");
            todolist[4] = new ToDo("Task5");

            //Выводим на экран список задач пользователя


            Console.WriteLine("Список задач:");

            for (int i = 0, numb_task = 1; i < 5 ; i++, numb_task++)
             {
                Console.WriteLine(numb_task +" - "+ todolist[i].Title); 
             }

            Console.WriteLine("Введите выполненные задачи");

            int check_task = 0; // номер выполненной задачи

            // спрашиваем номера выполненных задач и меняем статус выполнения у объекта
            do
            {
                Console.WriteLine("Введите номер выполненной задачи");
                try
                {
                    check_task = Convert.ToInt32(Console.ReadLine());
                    todolist[check_task - 1].IsDone = true;
                }
                catch { break; };
            }
            while (check_task > 0 && check_task <= 5);

          

            // выводим обновленный список задач

            Console.WriteLine("Список задач:");

            string json = "";
            File.WriteAllText(path, json);

            for (int i = 0, numb_task = 1; i < 5; i++, numb_task++)
            {

                if (todolist[i].IsDone == true) { Console.WriteLine(numb_task + " X " + todolist[i].Title); }
                else { 
                    Console.WriteLine(numb_task + " - " + todolist[i].Title);
                    json = JsonSerializer.Serialize(todolist[i]);
                    Console.WriteLine(  json); 
                    //Console.WriteLine(todolist[i].IsDone+todolist[i].Title);
                    File.AppendAllText(path, json + "\n");
                };
                
            }



            Console.ReadKey();

        }
    }
}
