using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class contrebandier:Personnage
    {
        public contrebandier(string n):base(n)
        {
            hp = 150;
            atk = 75;
            def = 50;
            speed = 75;
            money = money + 1000;
        }
    }
}
