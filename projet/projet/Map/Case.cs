﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolet
{
    class Case
    {
        public enum Lieu { Planet, Hero, Shop, Boss,Spawn,Vide, Indice}
        // public Monster m;
       // public Equipement Item;
        public Case Hero;
        public Lieu Type;
        public ConsoleColor color;
        public string symbole;


        public Case(int L, int l)
        {
            //On declare d'abbord le type étant null
            Type = Lieu.Vide;
            symbole = "";
            // Les planetes
            if ((l == 1) && (L == 1))
            {
                Type = Lieu.Spawn;
                color = ConsoleColor.Green;
                symbole = "Օ";
            }
            if ((l == 3) && (L == 3))
            {
                Type = Lieu.Planet;
                color = ConsoleColor.Blue;
                symbole = "Օ";
            }
            if ((l == 6) && (L == 0))
            {
                Type = Lieu.Shop;
                color = ConsoleColor.DarkGray;
                symbole = "Օ";
            }

            if ((l == 10) && (L == 3))
            {
                Type = Lieu.Planet;
                color = ConsoleColor.DarkYellow;
                symbole = "Օ";
            }
            if ((l == 13) && (L == 1))
            {
                Type = Lieu.Planet;
                color = ConsoleColor.DarkRed;
                symbole = "Օ";
            }
            //if ((l == 14) && (L == 1))
            //{
            //    Type = Lieu.Planet;
            //    color = ConsoleColor.DarkCyan;
            //    symbole = "Օ";
            //}
            if ((l == 20) && (L == 2))
            {
                Type = Lieu.Indice;
                color = ConsoleColor.DarkMagenta;
                symbole = "Օ";
            }

            //EtoLle de la mort
           if ((l == 29) && (L == 1))
            {
                Type = Lieu.Boss;
                symbole = "╗";
                color = ConsoleColor.DarkRed;

            }
            if ((l == 28) && (L == 1))
            {
                Type = Lieu.Boss;
                symbole = "═";
                color = ConsoleColor.DarkRed;
            }
            if ((l == 27) && (L == 1))
            {
                Type = Lieu.Boss;
                color = ConsoleColor.DarkRed;
                symbole = "╔";
            }
            if (((l == 29) && (L == 2)) || ((l ==27) && (L == 2)))
            {
                Type = Lieu.Boss;
                color = ConsoleColor.DarkRed;
                symbole = "║";
            }

            if ((l == 29) && (L == 3))
            {
                Type = Lieu.Boss;
                color = ConsoleColor.DarkRed;
                symbole = "╝";
            }
            if ((l == 28) && (L == 3))
            {
                Type = Lieu.Boss;
                color = ConsoleColor.DarkRed;
                symbole = "═";
            }
            if ((l == 27) && (L == 3))
            {
                symbole = "╚";
                Type = Lieu.Boss;
                color = ConsoleColor.DarkRed;
            }

        }
    }

}
