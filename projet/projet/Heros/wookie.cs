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
            heros = "wookie";
            hp_base = 250;
            atk_base = 100;
            def_base = 250;
            speed_base = 100;

            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
            hp = (hp_base * (lvl + 1));
        }

    }
}
