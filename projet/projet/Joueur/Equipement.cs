using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Equipement
    {
        //TODO equipement
        public Item[] equipement;
        public Equipement()
        {
            equipement = new Item[3];
            string name = "vide";
            Item arme = new arme(name);
            addEquip(arme);

            Item armure = new armure(name);
            addEquip(armure);

            Item chaussure = new chaussure(name);
            addEquip(chaussure);

        }
        public void addEquip(Item item)
        {
            for (int i = 0; i < equipement.Length; i++)
            {
                if(i==(item.id))
                {
                    equipement[i] = item;
                }
            }
        }
    }
}
