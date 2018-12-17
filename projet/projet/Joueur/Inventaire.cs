﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Inventaire
    {
        
        public List<Item> item;
        public int taille;
        public Inventaire()
        {
            item = new List<Item>();
            Item test = new arme();
            item.Add(test);
        }
        public void addInventaire(Item i)
        {
            item.Add(i);  
        }
        public void triInventaire()
        {
            for (int i = 0; i < item.Count; i++)
            {
                for (int j = 0; j < item.Count; j++)
                {
                    if (item[i].id > item[j].id)
                    {
                        Item item_save = item[j];
                        item[j] = item[i];
                        item[i] = item_save;
                    }
                }
            }
        }
        public  void affInventaire()
        {
            triInventaire();
            int nb = 1;
            Console.WriteLine("Armures :");
            for (int i = 0; i < item.Count; i++)
            {
                if(item[i].id==1)
                    {
                    Console.WriteLine(nb + " - " + item[i].name);
                    nb++;
                    }
            }
            Console.WriteLine("Armes :");
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 2)
                {
                    Console.WriteLine(nb + " - " + item[i].name);
                    nb++;
                }
            }
            Console.WriteLine("Chaussures :");
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 3)
                {
                    Console.WriteLine(nb + " - " + item[i].name);
                    nb++;
                }
            }
            UseInventaire();
        }
        public void UseInventaire()
        {
            Console.ReadLine();
        }
    }
}