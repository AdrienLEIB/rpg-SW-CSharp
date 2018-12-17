using prolet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
        abstract class Personnage
    {
        public string name;
        public enum Role { Luke, Solo, Leia, R2D2, Chewbacca  };

        public Role role;

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
        
        public Personnage(string n)
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
        public void Deplacement(Map map)
        {
            int dep = 5;

                if ((map.Plateau[x,y].Type == Case.Lieu.Planet))
                {
                    Console.Write(x);
                    Console.Write(y);
                }

           
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
        
    }
}
