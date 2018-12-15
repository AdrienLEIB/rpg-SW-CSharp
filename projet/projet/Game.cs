using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace projet
{
    class Game
    {
        public Game()
        {
            //Introduction();
            Map world = new Map(5, 30);

            Console.WriteLine("Quel est t'on nom?");
            string name = Console.ReadLine();
            Personnage heros = new Personnage(name, Personnage.Role.Chewbacca);
            world.affMap(heros);
            while (true) {
               heros.Deplacement(world);
                Console.Clear();
                world.affMap(heros);
            }
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
