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
            //Console.WriteLine("\n Main Menu: \n\t 1 - Create New Game \n\t 2 - Load Saved Game \n`\t 3 - About \n\t 4 - Exit");

            //Introduction();
           

            Map world = new Map(5, 30);
            Personnage heros = new Personnage("Adrien", Personnage.Role.Chewbacca);

            world.affMap(heros.x,heros.y);
            
            Console.ReadLine();

        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n Il y a bien longtemps, dans\n une galaxie très lointaine...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("\n STAR WARS");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("\n Les rebelles manquent de force. \n Mon Mothma leader de l'alliance \n prepare une attaque direct à l' \n étoile de la mort & l'assasinat \n du terrifiant Dark Vador... \n Un jeune héros formé à Alderaan \n décide de participer au combat..");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
