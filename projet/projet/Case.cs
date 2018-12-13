using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Case
    {
        public enum CaseType { Desert, Plaine, Lac, Foret };

        // public Monster m;
       // public Equipement Item;
        public Case Hero;



        public Case()
        {

            Hero = null;
            Random r = new Random(DateTime.Now.Millisecond);
            if (r.Next() % 100 > 50)
            {
                Item = new potion("Soin", "Potion de soin", 1, 2, potion.PotionType.Heal);
            }
            else
            {
                Item = null;
            }
        }
    }

}
