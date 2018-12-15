using prolet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Personnage
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

        
        public Personnage(string n, Role r)
        {
            name = n;
            role = r;
            lvl = 0;
            xp = 0;
            money = 2000;
            x = 1;
            y = 1;
            symbole = "˅";
            if (role == Role.Luke)
            {
                hp = 200;
                atk = 125;
                def = 75;
                speed = 100;

            }
            if (role == Role.Solo)
            {
                hp = 150;
                atk = 75;
                def = 50;
                speed = 75;
                money = money + 1000;
            }
            if (role == Role.Leia)
            {
                hp = 200;
                atk = 75;
                def = 125;
                speed = 100;
            }
            if(role== Role.R2D2)
            {
                hp = 400;
                atk = 75;
                def = 75;
                speed = 110;
            }
            if(role==Role.Chewbacca)
            {
                hp = 300;
                atk = 75;
                def = 200;
                speed =75;
            }
        }
        public void Deplacement(Map map)
        {
            int dep = 5;

                if ((map.Plateau[x,y].Type == Case.Symbole.Planet))
                {
                    Console.Write(x);
                    Console.Write(y);
                }

           
                if ((x>=1)&&(x<4)  && (y >= 1) &&(y<29)) { 
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 3-Ouest");
                    dep = Program.AskChoice(0, 3);
                }
                if ((x == 0)&&(x<4) && (y >0) &&(y<29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est \n 3-Ouest");
                    dep = Program.AskChoice(1, 3);
                }

                if ((x > 0) && (x == 4) && (y > 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est \n 3-Ouest");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
                    } while (dep == 1);

                }
                if ((x > 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est ");
                    dep = Program.AskChoice(0, 2);
                }

                if ((x > 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 3-Ouest");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
                    } while (dep == 2);
                }

                if ((x == 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est ");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
                    } while ((dep == 0) || (dep == 3));

                }
                if ((x == 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 1-Sud \n 3-Ouest ");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
                    } while ((dep == 0) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 3-Ouest ");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
                    } while ((dep == 1) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est ");
                    do
                    {
                        dep = Program.AskChoice(0, 3);
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

                }
            }
        
    }
}
