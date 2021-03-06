﻿using prolet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace projet
{
    class Map
    {
        public string Nom;
        public Case[,] Plateau;
        public string symbole;

        public Map(int largeur, int longueur)
        {
            Plateau = new Case[largeur, longueur];

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    Plateau[i, j] = new Case(i,j);
                    
                }
            }
        }
        public  void affMap(Joueur heros)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(" Legende :");
            Console.Write("Shop :");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", Rogue One :");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", Centre Pokemon :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", Planet :");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Օ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", Boss :");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("═");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 32; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            for (int i = 0; i < Plateau.GetLength(0); i++)
            {
                symbole = null;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int j = 0; j < Plateau.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    symbole = null;
                    //Pos perso
                    if((i==heros.x) && (j==heros.y))
                    {
                        Console.Write(heros.symbole);
                        continue;
                    }


                    // Les planetes
                    if(Plateau[i, j].Type == Case.Lieu.Planet)
                    {
                        symbole = Plateau[i, j].symbole;
                        Console.ForegroundColor = Plateau[i,j].color;

                    }
                    if (Plateau[i, j].Type == Case.Lieu.Shop)
                    {
                        symbole = Plateau[i, j].symbole;
                        Console.ForegroundColor = Plateau[i, j].color;

                    }
                    if (Plateau[i, j].Type == Case.Lieu.Spawn)
                    {
                        symbole = Plateau[i, j].symbole;
                        Console.ForegroundColor = Plateau[i, j].color;

                    }
                    if (Plateau[i, j].Type == Case.Lieu.Indice)
                    {
                        symbole = Plateau[i, j].symbole;
                        Console.ForegroundColor = Plateau[i, j].color;

                    }

                    // Etoile de la mort

                    if (Plateau[i,j].Type == Case.Lieu.Boss)
                    {
                        symbole = Plateau[i, j].symbole;
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                   
                    if (Plateau[i, j].Type == Case.Lieu.Vide)
                    {
                    symbole= " ";
                    }
                    Console.Write(symbole);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");
            }
            for (int i = 0; i < 32; i++)
            {
                Console.Write("-");
            }
        }

    }
}
