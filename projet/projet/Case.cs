using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Case
    {
        public enum Planet { Desert, Plaine, Lac, Foret };
        public enum Symbole { Planet, Hero, Shop, Boss,Bordure_h, Bordure_v}
        // public Monster m;
       // public Equipement Item;
        public Case Hero;
        public Symbole[,] symb;



        public Case(int L, int l)
        {
            for (int i = 0; i < L; i++)
            {
                for (int j= 0; j < l; j++)
                {
                    if((i==0) || (i==L-1))
                    {
                        //symb[i,j] = Symbole.Bordure_h;
                    }
                    if((j==0) || (j==l))
                    {
                       // symb[i,j] = Symbole.Bordure_v;
                    }
                }
            }
        }
    }

}
