using System;
using System.Collections.Generic;
using prolet;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace projet
{
    class Shop
    {
        public List<Item> item;

        public Shop(Joueur heros)
        {
            item = new List<Item>();
            string name = "sabrelaser";
            Item sabrelaser = new arme(name);
            item.Add(sabrelaser);

            name = "pistolet laser";
            Item pistoletlaser = new arme(name);
            item.Add(pistoletlaser);

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
            
            affShop();
            Vente(heros);
        }
        public void affShop()
        {

            Console.Clear();
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

            Console.WriteLine(nb + " - Quitter");
        }
        public void Vente(Joueur heros)
        {

            Console.WriteLine("Vous avez : " + heros.money);
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
                        Console.WriteLine("Succes !");
                        Thread.Sleep(0200);
                    }
                    else
                    {
                        Console.WriteLine("Erreur vous n'avez pas assez");
                        Thread.Sleep(0200);
                    }
                }
            }
            if (o < (item.Count + 1))
            {
                affShop();
                Vente(heros);
            }
            else
            {
                
            }
            
        }
    }
}
