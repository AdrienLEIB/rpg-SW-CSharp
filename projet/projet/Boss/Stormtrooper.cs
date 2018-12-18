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
            atk = j.atk / 2;
            def = j.atk / 2;
            speed = j.speed / 2;
            hp = j.hp / 2;
        }
    }
}
