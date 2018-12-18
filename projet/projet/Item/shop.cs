using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prolet;
namespace projet
{
    class Shop
    {
        public List<Item> item;

        public Shop(Joueur heros)
        {
            string name = "sabrelaser";
            Item sabrelaser = new arme(name);
            item.Add(sabrelaser);

            name = "pistole laser";
            Item pistolerlaser = new arme(name);
            item.Add(pistolerlaser);

            name = "diamant";
            Item diamant = new armure(name);
            item.Add(diamant);

            name = "fer";
            Item fer = new armure(name);
            item.Add(fer);

            name = "converse";
            Item converse = new chaussure(name);
            item.Add(converse);

            name = "basket";
            Item basket = new chaussure(name);
            item.Add(basket);

            Vente(heros);
        }
        public void affShop()
        {
            int nb = 1;
            Console.WriteLine("Armures :");
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 1)
                {
                    Console.WriteLine(nb + " - " + item[i].name + ", Prix :" + item[i].prix);
                    nb++;
                }
            }
            Console.WriteLine("Armes :");
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 2)
                {
                    Console.WriteLine(nb + " - " + item[i].name + ", Prix :" + item[i].prix);
                    nb++;
                }
            }
            Console.WriteLine("Chaussures :");
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 3)
                {
                    Console.WriteLine(nb + " - " + item[i].name + ", Prix :" + item[i].prix);
                    nb++;
                }
            }

            Console.WriteLine(nb + 1 + " - Quitter");
        }
        public void Vente(Joueur heros)
        {
            int o = Program.AskChoice(0, (item.Count+1));

            for (int i = 0; i < item.Count; i++)
            {
                if (i==o)
                {
                    float money_save = heros.money - item[i].prix;
                    if(money_save >=0)
                    {
                        heros.money = money_save;
                        heros.inv.addInventaire(item[i]);
                    }
                    else
                    {
                        Console.WriteLine("Erreur vous n'avez pas assez");
                    }
                }
            }
            
        }
    }
}
