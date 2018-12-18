using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class wookie:Joueur
    {
        public wookie(string n):base(n)
        {
            hp = 200;
            atk = 125;
            def = 75;
            speed = 100;

            hp_base = hp;
            atk_base = atk;
            def_base = def;
            speed_base = speed;
        }

    }
}
