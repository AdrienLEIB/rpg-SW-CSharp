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
            Introduction();
            Map world = new Map(5, 30);
            Boolean indice = false;
            Console.WriteLine("Nom du joueur ?");
            string name = Console.ReadLine();
            int resultat = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
|  ,.------;:~~:-.      |   1- Un wookie
| /:.\`;;|||;:/;;:\     |   Avantage:
|:')\`:\||::/.-_':/)    |       +Def/hp
|`:`\\\ ;'||'.''/,.:\   |
|==`;.:`|;::/'/./';;=   |
|:-/-%%% | |%%%;;_- _:  |
|=// %wm)..(mw%`_ :`:\  |
|;;--', /88\ -,- :-~~|  |
|-;~~::'`~^~:`::`/`-=:) |
|(;':)%%%' `%%%.`:``:)\ |
|(\ %%%/dV##Vb`%%%%:`-. |
| |);/( ;~~~~ :)\`;;.``\|
| //\'/,/|;;|:(: |.|\;|\|
|/) |(/ | / \|\\`( )- ` |
|;):):)/.):|/) (`:`\\`-`|
|;%/ //;/(\`.':| ::`\\;`|
|;/~( \|./;)|.|):;\. \\-|
|/',:\//) ||`.|| (:\)):%|
|,|/;/(%;.||| (|(\:- ; :|
|_%__%:__;_:`_;_:_.\%_`_|

                                Continuer ->
");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"
|      .x%%%%%%x.         |     2 - Un contrebandier
|     ,%%%%%%%%%%%        |     Avangtage :
|    ,%%%'  )'  \%        |         * Gagne 4 fois plus d'argent par combat
|   ,%x%) __   _ Y        |         + money
|   :%%% ~=-. <=~|        |         
|   :%%::. .:,\  |        |
|   `;%:`\. `-' .'        |
|    ``x`. -===-;         |
|     / `:`.__.;          |
|  .d8b.  :: ..`.         |
| d88888b.  '  /8         |
|d888888888b. ( 8b       /|
|~   ~`888888b  `8b     /:|
|  ' ' `888888   `8. _ /:/|
|'      )88888b   8b |):X |
|   ~ - |888888   `8b/:/:\|
|       |888888    88\/~~;|
|       (888888b   88|  / |
|\       \888888   8-:   /|
|_\_______\88888_.'___\__/|

                                Continuer ->
");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"
|        .......       LS|          3 - Un Jedi
|      ::::::;;::.       |          Avantage :
|    .::;::::;::::.      |             * Attaque deux fois par combat
|   .::::::::::::::      |             * + Atk/Speed
|   ::`_```_```;:::.     |
|   ::=-) :=-`  ::::     |
| `::|  / :     `:::     |
|   '|  `~'     ;:::     |
|    :-:==-.   / :'      |
|    `. _    .'.d8:      |
| _.  |88bood88888._     |
|~  `-+8888888888P  `-. _|
|-'     ~~^^^^~~  `./8 ~ |
|8b /  /  |   \  \  `8   |
|P        `          8   |
|                    8b  |
|                    `8  |
|                     8b |
|         .           `8 |
|________/_\___________8_|

                                Continuer ->

");
;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n Quel héros souhaites-tu incarner? \n 1- Un wookie \n 2- Un contrebandier \n 3- Un Jedi");
            int heros_want = Program.AskChoice(1, 3);
            Console.Clear();
            Console.WriteLine(@"
             _     _
            /_|   |_\
           //||   ||\\
          // ||   || \\
         //  ||___||  \\
        /     |   |     \    _
       /    __|   |__    \  /_\
      / .--~  |   |  ~--. \|   |
     /.~ __\  |   |  /   ~.|   |
    .~  `=='\ |   | /   _.-'.  |
   /  /      \|   |/ .-~    _.-'
  |           +---+  \  _.-~  |
  `=----.____/  #  \____.----='
   [::::::::|  (_)  |::::::::]
  .=----~~~~~\     /~~~~~----=.
  |          /`---'\          |
   \  \     /       \     /  /
    `.     /         \     .'
      `.  /._________.\  .'
        `--._________.--'     Vous embarquez dans le faucon millenium direction l'etoile de la mort ...

                                    Continuer ->
");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

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
                    if (storm_result==2)
                    {
                        heros.x = 1;
                        heros.y = 1;
                        Console.WriteLine("Vous avez perdu contre un stormtrooper... Retour au spawn.Vous perdez 100 euros \n Continuer ->");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if(storm_result==1){
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
                    heros.hp = heros.hp_base * (heros.lvl+1);
                    Thread.Sleep(1500);
                }
                if (world.Plateau[heros.x,heros.y].Type == Case.Lieu.Boss)
                {
                    if(indice == false)
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

            if(resultat ==1)
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
        public static void Introduction()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\t\t\t Il y a bien longtemps, dans\n\t\t\t\t\t une galaxie très lointaine....");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine(@"

                                   _________________      ____         __________
                     .       .    /                 |    /    \    .  |          \
                         .       /    ______   _____| . /      \      |    ___    |     .     .
                                 \    \    |   |       /   /\   \     |   |___>   |
                               .  \    \   |   |      /   /__\   \  . |         _/             .
                     .     ________>    |  |   | .   /            \   |   |\    \_______    .
                          |            /   |   |    /    ______    \  |   | \           |
                          |___________/    |___|   /____/      \____\ |___|  \__________|    .
                      .     ____    __  . _____   ____      .  __________   .  _________
                           \    \  /  \  /    /  /    \       |          \    /         |      .
                            \    \/    \/    /  /      \      |    ___    |  /    ______|  .
                             \              /  /   /\   \ .   |   |___>   |  \    \
                       .      \            /  /   /__\   \    |         _/.   \    \
                               \    /\    /  /            \   |   |\    \______>    |   .
                                \  /  \  /  /    ______    \  |   | \              /          .
                     .       .   \/    \/  /____/      \____\ |___|  \____________/  
");
            Thread.Sleep(2500);
            Console.Clear();
            List<string>  scenario = new List<string>();
            string vide = "";
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);

            string line = "\t\t\t\t Les rebelles manquent de force.";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t Mon Mothma leader de l'alliance ";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t prepare une attaque direct à l'";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t étoile de la mort & l'assasinat";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t du terrifiant Dark Vador...";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t Un jeune héros formé à Alderaan";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            line = "\t\t\t\t décide de participer au combat...";
            scenario.Add(line);
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);
            scenario.Add(vide);

            afficheScenario(scenario);






            //Console.WriteLine("\n Les rebelles manquent de force. \n Mon Mothma leader de l'alliance \n prepare une attaque direct à l' \n étoile de la mort & l'assasinat \n du terrifiant Dark Vador... \n Un jeune héros formé à Alderaan \n décide de participer au combat..");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void afficheScenario(List<String> sce)
        {
            while(sce.Count >5)
            {
                Thread.Sleep(1000);
                Console.Clear();
                for (int i = 0; i < 6; i++)
                {

                Console.WriteLine(sce[i]);
                                        
                }
                sce.RemoveAt(0);                
            }
            
        }
    }

}
