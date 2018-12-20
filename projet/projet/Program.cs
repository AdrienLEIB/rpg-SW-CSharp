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
                    Console.Clear();
                    Save save = new Save();
                    break;
                case 3:
                    Console.WriteLine("Ce jeu a été crée par  Adrien Leib");
                    Console.ReadLine();
                    break;
                case 4:

                    break;

            }

            


        }
        public static int AskChoice(int min, int max)
        {
            // on transforme le string en int
            //int result = int.Parse(Console.ReadLine());

            int.TryParse(Console.ReadLine(), out int result);
            while (result > max || result < min)
            {
               int.TryParse(Console.ReadLine(), out result);
                
            }
            return result;

        }
    }
}
