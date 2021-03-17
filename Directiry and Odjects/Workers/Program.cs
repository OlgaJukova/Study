using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker[] workers = new Worker[5];

            workers[0]= new Worker("Ivanov Ivan", profession.Accountant,"ii@mail.ru", "8-903-764-74-83", 50000, 55 );
            workers[1] = new Worker("Petrov Petr", profession.Designer, "pp@mail.ru", "8-903-455-85-34", 60000, 18);
            workers[2] = new Worker("Kuznecov Alexey", profession.Lawyer, "ka@mail.ru", "8-950-844-55-33", 70000, 46);
            workers[3] = new Worker("Suhova Svetlana", profession.Marketer, "ss@mail.ru", "8-960-456-35-55", 40000, 20);
            workers[4] = new Worker("Sidorov Ivan", profession.Security, "si@mail.ru", "8-905-454-56-23", 40000, 60);


            Console.WriteLine("Workers of the company are over 40 yeears old:");
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].age >= 40)
                {
                    workers[i].Info();
                }  


            }
            Console.ReadKey();
        }
    }
}
