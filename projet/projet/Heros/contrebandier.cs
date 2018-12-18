using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class contrebandier:Joueur
    {
        public contrebandier(string n):base(n)
        {
            hp = 150;
            atk = 75;
            def = 50;
            speed = 75;
            money = money + 1000;

            hp_base = hp;
            atk_base = atk;
            def_base = def;
            speed_base = speed;


        }
    }
}
