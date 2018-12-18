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
            hp = 200;
            atk = 125;
            def = 75;
            speed = 100;
        }
    }
}
