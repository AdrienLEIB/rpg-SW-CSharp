using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class jedi:Joueur
    {
        public jedi(string n):base(n)
        {
            hp_base = 200;
            atk_base = 125;
            def_base = 75;
            speed_base = 100;


            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
            hp = (hp_base * (lvl + 1));
        }
    }
}
