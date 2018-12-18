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
            hp_base = 150;
            atk_base = 75;
            def_base = 50;
            speed_base = 75;
            money = money + 1000;


            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
            hp = (hp_base * (lvl + 1));
        }
    }
}
