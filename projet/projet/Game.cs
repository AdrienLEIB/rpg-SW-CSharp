using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using prolet;

namespace projet
{
    class Game
    {
        public Joueur heros;
        
        public Game()
        {
            //Introduction();
            Map world = new Map(5, 30);

            Console.WriteLine("Quel est t'on nom?");
            string name = Console.ReadLine();
            int resultat = 0;
            Console.Clear();
            Console.WriteLine("\n Quel héros souhaites-tu incarner? \n 1- Un wookie \n 2- Un contrebandier \n 3- Un Jedi");
            int heros_want = Program.AskChoice(1, 3);
            switch (heros_want)
            {
                case 1:
                    heros = new wookie(name);
                    break;
                case 2:
                    heros = new contrebandier(name);
                    break;
                case 3:
                    heros = new jedi(name);
                    break;
            }
            Boss Vador = new Vador();
            //world.affMap(heros);
            while ((resultat == 0))
            {
                world.affMap(heros);
                heros.Deplacement(world);
                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Planet)
                {
                    Boss storm = new Stormtrooper(heros);
                    heros.Combat_storm(storm);

                }
                if (world.Plateau[heros.x,heros.y].Type == Case.Lieu.Boss)
                {
                    resultat = heros.Combat(Vador);
                    
                }
                Console.Clear();
                //world.affMap(heros);
            }
            Console.WriteLine("GG");
            Console.ReadLine();
        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n Il y a bien longtemps, dans\n une galaxie très lointaine...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine(@"
                    8888888888  888    88888
                   88     88   88 88   88  88
                    8888  88  88   88  88888
                       88 88 888888888 88   88
                88888888  88 88     88 88    888888


                88  88  88   888    88888    888888
                88  88  88  88 88   88  88  88
                88 8888 88 88   88  88888    8888
                 888  888 888888888 88   88     88
                  88  88  88     88 88    8888888");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("\n Les rebelles manquent de force. \n Mon Mothma leader de l'alliance \n prepare une attaque direct à l' \n étoile de la mort & l'assasinat \n du terrifiant Dark Vador... \n Un jeune héros formé à Alderaan \n décide de participer au combat..");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void damage(Joueur heros,Boss boss)
        {

                if(heros.atk > boss.def)
                {
                    boss.hp = boss.hp - (heros.atk - boss.def);
                }     
                if(heros.atk <= boss.def )
                {
                    boss.hp = boss.hp - 1;
                }
            
        } 
    }

}
