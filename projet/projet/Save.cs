using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using prolet;
using System.IO;
namespace projet
{
    class Save
    {
        public Joueur heros;
        public Save()
        {
            Map world = new Map(5, 30);
            int resultat = 0;
            Boss Vador = new Vador();
            string name;
            bool indice;
            string type_heros;
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamReader sr = new StreamReader(path + @"\load_heros.txt", true))
            {
                int count = 0;
                string l1;
                sr.ReadLine();
                string[] tab = new string[4];
                while ((l1 = sr.ReadLine()) != null)
                {
                    tab[count] = l1;
                    count++;


                }
                name = tab[0];
                indice = bool.Parse(tab[2]);
                type_heros = tab[1];

            }
            if (type_heros == "jedi")
            {
                heros = new jedi(name);
            }
            else if (type_heros == "wookie")
            {
                heros = new wookie(name);
            }
            else if(type_heros == "contrebandier")
            {
                heros = new contrebandier(name);
            }
            else
            {
                Console.WriteLine("Erreur aucun heros");
            }

            heros.loadSave();

            while ((resultat == 0))
            {
                world.affMap(heros);
                heros.Deplacement(world);

                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Indice)
                {
                    if (indice == false)
                    {
                        indice = heros.Indice();
                    }
                    else
                    {
                        Console.WriteLine("Vous avez déjà obtenu l'indice");
                    }
                }
                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Planet)
                {
                    Boss storm = new Stormtrooper(heros);
                    int storm_result = heros.Combat_storm(storm);
                    if (storm_result == 2)
                    {
                        heros.x = 1;
                        heros.y = 1;
                        Console.WriteLine("Vous avez perdu contre un stormtrooper... Retour au spawn.Vous perdez 100 euros \n Continuer ->");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (storm_result == 1)
                    {
                        Console.WriteLine("Vous avez gagné !");
                        Console.WriteLine("Il va falloir que J'avertisse Maitre Vador de la force de ce petit gamin... \n Continuer ->");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Spawn)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                                     /~\
                                    |oo )
                                    _\=/_
                    ___            /  _  \
                   / ()\          //|/.\|\\
                 _|_____|_        \\ \_/  ||
                | | === | |        \|\ /| ||
                |_|  O  |_|        # _ _/ #
                 ||  O  ||          | | |
                 ||__*__||          | | |
                |~ \___/ ~|         []|[]
                /=\ /=\ /=\         | | |
________________[_]_[_]_[_]________/_]_[_\_________________________
");
                    Console.Write("Vous etes sur la planete des revolutionnaires, vous recupèrez vos pv");
                    heros.hp = heros.hp_base * (heros.lvl + 1);
                    Thread.Sleep(1500);
                }
                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Boss)
                {
                    if (indice == false)
                    {
                        Console.WriteLine(@"
    .          __---__
  .     .   .-'...:...'-.               .          .
           / .  . : .__ .\
    .     /........./  \ .\  .   .                            .
         / :  :   :| () | :\                  .        .
        :...........\__/....:         .
 .      |___________________|              .                     .
        |...................|               .  
  .     :  :  :   :   :   : :                          .
      .  \................./      .            .
          \  .  . : .  .  /   .                                .
.      .   \._........._./  .        .                   .
              -..___..-                .         .
Vous ne pouvez pas entrer dans l'étoile de la mort sans indices !

                                Continuer ->
");
                        Console.ReadLine();
                    }
                    else
                    {
                        resultat = heros.Combat(Vador);
                    }

                }
                if (world.Plateau[heros.x, heros.y].Type == Case.Lieu.Shop)
                {
                    Shop shop = new Shop(heros);
                    shop.affShop();
                }
                Console.Clear();
                //world.affMap(heros);
            }

            if (resultat == 1)
            {
                Console.Clear();
                Console.WriteLine(@"
           _.-'~~~~~~`-._
          /      ||      \
         /       ||       \
        |        ||        |
        | _______||_______ |
        |/ ----- \/ ----- \|
       /  (     )  (     )  \
      / \  ----- () -----  / \
     /   \      /||\      /   \
    /     \    /||||\    /     \
   /       \  /||||||\  /       \
  /_        \o========o/        _\
    `--...__|`-._  _.-'|__...--'
            |    `'    |             
");
                Console.Write(heros.name + " je suis ton Pere ....");
                Thread.Sleep(2500);
                Console.Clear();
                Console.WriteLine(@"
 _______ .__   __.  _______  
|   ____||  \ |  | |       \ 
|  |__   |   \|  | |  .--.  |
|   __|  |  . `  | |  |  |  |
|  |____ |  |\   | |  '--'  |
|_______||__| \__| |_______/ 
                             
");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(@"

.______    _______ .______       _______   __    __  
|   _  \  |   ____||   _  \     |       \ |  |  |  | 
|  |_)  | |  |__   |  |_)  |    |  .--.  ||  |  |  | 
|   ___/  |   __|  |      /     |  |  |  ||  |  |  | 
|  |      |  |____ |  |\  \----.|  '--'  ||  `--'  | 
| _|      |_______|| _| `._____||_______/  \______/ ");
            }
        }
    }
}
