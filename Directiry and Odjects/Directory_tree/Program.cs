using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            A: string path = ""; // переменная для пути
            Console.WriteLine("Введите пути к интересующей дирректории"); 
                path = Console.ReadLine();
                if (path == "")
                {
                    path = AppDomain.CurrentDomain.BaseDirectory; // Записываем ссылку на текущую дирректорию проекта}}
                }
    

            try
            {
                string[] Dir = Directory.GetFileSystemEntries(path); // проверяем, корректен ли введенный путь
                for (int i = 0; i < Dir.Length; i++)
                {
                    Console.WriteLine(Dir[i]);
                }
            }
            catch
            {
                Console.WriteLine("Повторите ввод");
                goto A;
            };

            string file_path = Path.Combine(path, "Directory_Tree.txt"); // путь к файлу, куда будет выводиться наше дерево
            File.WriteAllText(file_path, ""); // создаем или перезаписываем этот файл
            

            writing_to_file(path, file_path);// запускаем наш метод записи дерева
            Console.WriteLine("В файле:\n\n" + File.ReadAllText(file_path));


            

           

            Console.ReadKey();          

        }


        static void writing_to_file(string path1, string file_path1) //  метод для записи в файл содержимого каталога по заданному пути
        {
            string[] Dir = Directory.GetFileSystemEntries(path1); // создаем массив путей из всего, что есть в каталоге

            File.AppendAllLines(file_path1, Dir);
            Console.WriteLine(  "Родительский каталог" + Directory.GetParent(path1));
           // string parent_dir = Convert.ToString(Directory.GetParent(path1));

             while (Directory.GetParent(path1) != null)
                {
                    writing_to_file(Convert.ToString(Directory.GetParent(path1)), file_path1);
                }
                
        }




    }
}
