using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolet
{
    class Case
    {
        public enum Planet { Desert, Plaine, Lac, Foret };
        public enum Symbole { Planet, Hero, Shop, Boss_m, Boss_tl,Boss_t,Boss_tr,Boss_bl,Boss_b,Boss_br}
        // public Monster m;
       // public Equipement Item;
        public Case Hero;
        public Symbole Type;
        public ConsoleColor color;


        public Case(int L, int l)
        {
           

            // Les planetes
            if ((l == 3) && (L == 3))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.Red;
            }
            if ((l == 6) && (L == 1))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.Yellow;
            }
            if ((l == 8) && (L == 2))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.Green;
            }

            if ((l == 10) && (L == 3))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.DarkBlue;
            }
            if ((l == 13) && (L == 3))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.DarkMagenta;
            }
            if ((l == 14) && (L == 1))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.DarkCyan;
            }
            if ((l == 20) && (L == 2))
            {
                Type = Symbole.Planet;
                color = ConsoleColor.DarkGray;
            }
            //EtoLle de la mort
           if ((l == 29) && (L == 1))
            {
                Type = Symbole.Boss_tr;
                color = ConsoleColor.DarkRed;

            }
            if ((l == 28) && (L == 1))
            {
                Type = Symbole.Boss_t;
                color = ConsoleColor.DarkRed;
            }
            if ((l == 27) && (L == 1))
            {
                Type = Symbole.Boss_tl;
                color = ConsoleColor.DarkRed;
            }
            if (((l == 29) && (L == 2)) || ((l ==27) && (L == 2)))
            {
                Type = Symbole.Boss_m;
                color = ConsoleColor.DarkRed;
            }

            if ((l == 29) && (L == 3))
            {
                Type = Symbole.Boss_br;
                color = ConsoleColor.DarkRed;
            }
            if ((l == 28) && (L == 3))
            {
                Type = Symbole.Boss_b;
                color = ConsoleColor.DarkRed;
            }
            if ((l == 27) && (L == 3))
            {
                Type = Symbole.Boss_bl;
                color = ConsoleColor.DarkRed;
            }



        }
    }

}
