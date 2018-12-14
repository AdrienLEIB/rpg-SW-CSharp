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
        public void Deplacement()
        {

            Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 3-Ouest");
            int dep = Program.AskChoice(0, 3);
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
