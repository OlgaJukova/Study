using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            bool finish = false;
            init();
            render();
           
            

             while (true)
             {
                user_step();
                render();
                if (win(simb_user)) { Console.WriteLine("Вы выиграли"); finish = true; break; };
                if (is_end()) { Console.WriteLine("Поле заполнено"); finish = true; break; };
                bot_step();
                render();
                if (win(simb_bot)) { Console.WriteLine("Вы выиграли"); finish = true; break; };
                if (is_end()) { Console.WriteLine("Поле заполнено"); finish = true; break; };

               

            }; 



            Console.WriteLine("");

            Console.ReadKey();

        }


        static byte size_v = 5;
        static byte size_g = 5;
        static byte length_chain = 4;
        static char simb_user = 'X';
        static char simb_bot= 'O';
        static char simb_field = '.';

        static char  [,] field = new char[size_v, size_g];

        static Random random = new Random();


        static void init()
        { for (int i=0; i<size_v; i++)
            {
                for (int j = 0; j < size_v; j++)
                {
                    field[i, j] = simb_field;
                }
            }
        }



        static void render()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            for (int i = 0; i < size_v; i++)
            {
                Console.Write("|");
                for (int j = 0; j < size_v; j++)
                {
                    Console.Write(field[i, j]+"|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }

        static bool is_end()
        {
            for (int i = 0; i < size_v; i++)
            {
                for (int j = 0; j < size_v; j++)
                {
                    if (field[i, j] == simb_field) 
                    { 
                        return false; 
                       // break;
                    }
                }
            }

            return true;
        }

        private static void user_step()
        {

            int v = 0, g = 0;
            do
            {
                Console.WriteLine("Введите координаты");
                 v = Int32.Parse(Console.ReadLine())-1;
                 g = Int32.Parse(Console.ReadLine()) - 1;               
            }
            while ( !(check(v, g)));
            set(v, g, simb_user);

         }





        private static void bot_step()
        {
            int v = 0, g = 0;
            do
            {                
                v = random.Next(0,size_v);
                g = random.Next(0, size_g);
            }
            while (!(check(v, g)));
            set(v, g, simb_bot);


        }

        static bool check(int v, int g)
        {
            if (v < 0 || v > size_v-1 || g < 0 || g > size_g-1)
            {    
                return false;
            }
            else return (field[v, g ] == simb_field);

            return true;// ;

            }

        static void set(int v, int g, char simb)
        {
            field[v, g] = simb;
        }

        private static bool exist_element(int v, int g)
        {
            char simb =' ';
            try { simb = field[v, g]; }
            catch { return false; };
            return true;

        }

        private static bool win(char simb)
        {
            for (int i=0; i<size_v; i++)
            {
                for (int j=0; j < size_g; j++)
                {
                    if (check(i,j,simb)==4) { return true; }
                }
            }

            return false;
        }




        private static int check(int v, int g, char simb) 
        {
            int chain = 0;
            if (check_vert(v, g, simb) > chain) { chain = check_vert(v, g, simb); };
            if (check_goriz(v, g, simb) > chain) { chain = check_goriz(v, g, simb); };
            if (check_diag1(v, g, simb) > chain) { chain = check_diag1(v, g, simb); };
            if (check_diag2(v, g, simb) > chain) { chain = check_diag2(v, g, simb); };
            return chain;
        }


        private static int check_vert(int v, int g ,char simb)
        {
            int chain = 0;
            for ( int i=v ; i <(v+length_chain); i++)
            {
                if (exist_element(i, g)) 
                {
                    if (field[i, g] == simb) { chain++; } else { break; }
                }

                else { break; }
            }

            return chain;
        }

        private static int check_goriz(int v, int g, char simb)
        {
            int chain = 0;
            for (int i = g; i < (g + length_chain); i++)
            {
                if (exist_element(v, i))
                {
                    if (field[v, i] == simb) { chain++; } else { break; }
                }

                else { break; }
            }

            return chain;
        }


        private static int check_diag1(int v, int g, char simb)
        {
            int chain = 0;
            for (int i = v ; i < (g + length_chain); i++, g++)
            {
                if (exist_element(i, g))
                {
                    if (field[i, g] == simb) { chain++; } else { break; }
                }

                else { break; }
            }

            return chain;
        }

        private static int check_diag2(int v, int g, char simb)
        {
            int chain = 0;
            for (int j = g; j > (g - length_chain); j++, v++)
            {
                if (exist_element(v, j))
                {
                    if (field[v, j] == simb) { chain++; } else { break; }
                }

                else { break; }
            }

            return chain;
        }













    }
}
