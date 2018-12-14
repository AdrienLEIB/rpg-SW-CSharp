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

        
        public Personnage(string n, Role r)
        {
            name = n;
            role = r;
            lvl = 0;
            xp = 0;
            money = 2000;
            x = 1;
            y = 1;
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
    }
}
