using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Worker
    { public string name { get; set; }

        public profession Prof { get; set; }

        public string email { get; set; }
        public string phone { get; set; }

        public int salary;

        public int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 16 && value <= 70)
                {
                    age = value;
                }
            }
        }

        public Worker()
            {
            name="";
            Prof = profession.Undefened;
            email = "";
            phone = "";
            salary = 0;
            age = 0;

            }

        public Worker(string Name, profession prof, string mail, string Phone, int Salary, int Age)
        {
            name = Name;
            Prof = prof;
            email = mail;
            phone = Phone;
            salary = Salary;
            age=Age;

        }

        public void Info()
        {
            Console.WriteLine(name + " "+ Prof + " " + email + " " + phone + " " + salary + " " + age + " " + " years");
        }



    }

    enum profession
        {
        Engeneer,
        Technologist,
        Accountant,
        Programmer,
        Security,
        Lawyer,
        Designer,
        Marketer,
        Undefened
        }

}
