using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_list
{    [Serializable]
    class ToDo
    {

        public string Title { get; set; }  // Хранит наименование задачи

        public bool IsDone { get; set; } // Сведения о выполнении


       
        public ToDo()
        {
            Title = "";
            IsDone = false;

        }
       
        public ToDo(string str)
        {
            Title = str;
            IsDone = false;

        }


    }
}
