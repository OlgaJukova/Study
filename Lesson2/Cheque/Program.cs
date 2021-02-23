using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque
{
    class Program
    {
        static void Main(string[] args)
        {
            byte box = 3,//касса
                 kol1 = 2,// количество 1 продукта
                 kol2 = 3;
            float price1 = 30.3f,
                  price2 = 60.0f,
                  sum1 = 0.0f,
                  sum2 = 0.0f;

            sum1 = kol1 * price1;
            sum2 = kol2 * price2;

            DateTime data = DateTime.Now;
            string cashiername = "Иванов",
                   product1 = "хлеб",
                   product2 = "молоко";

            


            Console.WriteLine(
                "              ООО Билла                      \n"+
                "                Москва                       \n"+
                "             ИНН 12837246645                 \n"+
                "                Москва                       \n"+
                "             Супермаркет 123                 \n"+
                "             Проспект Мира, 1                \n"+
                "  Касса Кассир            Дата     Время     \n"+
                "   "+box+"   "+cashiername+"         "+data+"       \n\n\n"+
                " Позиция            Цена     Кол.      Сумма \n\n"+
                " "+product1+"               "+price1+"      "+kol1+"        "+sum1+"\n"+
                " "+product2+"               "+ price2+"      "+ kol2+"        "+sum2+"\n\n"+
                "**********************************************\n"




                );
            Console.ReadLine();
        
        
        
        
        }
    }
}
