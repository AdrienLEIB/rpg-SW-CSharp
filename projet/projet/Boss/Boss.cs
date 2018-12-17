using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    abstract class Boss
    {

        public float hp;
        public float atk;
        public float def;
        public float speed;
        public Boss()
        {
        
            
        }
        public static void damage(Personnage heros, Boss boss)
        {

            if (heros.atk > boss.def)
            {
                boss.hp = boss.hp - (heros.atk - boss.def);
            }
            if (heros.atk <= boss.def)
            {
                boss.hp = boss.hp - 1;
            }

        }
    }
}
