using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Stormtrooper:Boss
    {
        public Stormtrooper(Joueur j):base()
        {
            xp = (j.xp_save * j.lvl) / 4;
            atk = j.atk / 2;
            def = j.atk / 2;
            speed = j.speed / 2;
            hp = (j.hp_base*j.lvl) / 2;
        }
    }
}
