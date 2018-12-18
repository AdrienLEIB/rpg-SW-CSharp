using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace projet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Main Menu: \n\t 1 - Create New Game \n\t 2 - Load Saved Game \n`\t 3 - About \n\t 4 - Exit");
            
            int want = Program.AskChoice(1, 4);
            switch (want)
            {
                case 1:
                    Game new_game = new Game();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:

                    break;

            }

            


        }
        public static int AskChoice(int min, int max)
        {
            // on transforme le string en int
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
                
            }
            return result;

        }
    }
}
