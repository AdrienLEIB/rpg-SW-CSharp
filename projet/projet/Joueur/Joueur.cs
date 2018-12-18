using prolet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
        abstract class Joueur
    {
        public string name;


        public float lvl;
        public float xp;

        public float hp;
        public float atk;
        public float def;
        public float speed;
        public float money;
        public int x;
        public int y;
        public string symbole;
        public Inventaire inv;
        
        public Joueur(string n)
        {
            name = n;
            lvl = 0;
            xp = 0;
            money = 2000;
            x = 1;
            y = 1;
            symbole = "˅";
            inv = new Inventaire();

           
        }
        public void test()
        {
            Console.WriteLine(atk);
        }
        public void Deplacement(Map map)
        {
            int dep = 5;
            Boss vador = new Vador();


                if ((map.Plateau[x,y].Type == Case.Lieu.Planet))
                {
                    Console.Write(x);
                    Console.Write(y);
                }
                //if((map.Plateau[x,y].Type == Case.Lieu.Boss))
                //{
                //    result = Combat(vador);
                //x = 0;
                //y = 0;
                //}


                if ((x>=1)&&(x<4)  && (y >= 1) &&(y<29)) { 
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 3-Ouest \n 4-Inventaire");
                    dep = Program.AskChoice(0, 4);
                }
                if ((x == 0)&&(x<4) && (y >0) &&(y<29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est \n 3-Ouest \n 4-Inventaire");
                    dep = Program.AskChoice(1, 4);
                }

                if ((x > 0) && (x == 4) && (y > 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est \n 3-Ouest \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while (dep == 1);

                }
                if ((x > 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while (dep ==3);
                }

                if ((x > 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 3-Ouest \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while (dep == 2);
                }

                if ((x == 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while ((dep == 0) || (dep == 3));

                }
                if ((x == 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 1-Sud \n 3-Ouest \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while ((dep == 0) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 3-Ouest \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while ((dep == 1) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est \n 4-Inventaire");
                    do
                    {
                        dep = Program.AskChoice(0, 4);
                    } while ((dep == 1) || (dep == 3));

                }
                switch (dep)
                {
                    case 0:
                        x = x - 1;
                        symbole = "˄";
                        break;
                    case 1:
                        x = x + 1;
                        symbole = "˅";
                        break;
                    case 2:
                        y = y + 1;
                        symbole = "˃";
                        break;
                    case 3:
                        y = y - 1;
                        symbole = "˂";
                        break;
                    case 4:
                        inv.affInventaire();
                        break;
                }
        }
        public int Combat(Boss b)
        {
            int result = 0;
            Console.WriteLine("Un Dark Vador sauvage apparaît !");
            Console.Clear();
            int choice = 0;
            do
            {
                Console.WriteLine(@"                       .-.
                           .-.
                          |_:_|
                         /(_Y_)\
    .                   ( \/M\/ )
     '.               _.'-/'-'\-'._
       ':           _/.--'[[[[]'--.\_
         ':        /_'  : |:: | :  '.\
           ':     //   ./ |oUU| \.'  :\
             ':  _:'..' \_|___|_/ :   :|
               ':.  .' | _[___]_ |  :.':\
                [::\ |  :  | |  :   ; : \
                 '-'   \/ '.| |.' \  .;.' |
                  |\_    \  '-'   :       |
 
                  |  \    \ .:    :   |   |
 
                  |   \    | '.   :    \  |
                  /       \   :. .;       |
 
                 /     |   |  :__ /     :  \\
               |  |   |    \:   | \   |   ||
              /    \  : :  |:   /  | __ |   /|
          snd |     : : :_ / _ |  / '._\  '-- | _\
              / ___.-/ _ | -'   \  \
                             '-'");
                Console.WriteLine(b.hp + " PV");
                Console.WriteLine("Vous souhaitez : \n 1- Attaquer \n 2- Inventaire \n 3- Fuir");
                choice = Program.AskChoice(1, 3);
                switch (choice)
                {
                    case 1:
                        damage_boss(b);
                        damage_player(b);
                        break;
                    case 2:
                        inv.affInventaire();
                        break;
                    case 3:
                        break;
                }
                if (hp <= 0)
                {
                    result = 2;
                }
                if (b.hp <= 0)
                {
                    result = 1;
                }
                if ((hp <= 0) && (b.hp <= 0))
                {
                    if (speed >= b.speed)
                    {
                        result = 1;
                    }
                    if (speed < b.speed)
                    {
                        result = 2;
                    }
                }
            } while ((choice != 3) && (result == 0) );
            Console.WriteLine("gg");
            return result;
        }
        public void damage_boss(Boss boss)
        {
                if (atk > boss.def)
                {
                    boss.hp = boss.hp - (atk - boss.def);
                }
                if (atk <= boss.def)
                {
                    boss.hp = boss.hp - 1;
                }
        }
        public void damage_player(Boss boss)
        {
            if (boss.atk > def)
            {
                hp = hp - (boss.atk - def);
            }
            if (boss.atk <= def)
            {
                hp = hp - 1;
            }
        }
    }
}
