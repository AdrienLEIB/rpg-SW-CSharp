using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Plateau[i, j] = new Case(largeur,longueur);
                    
                }
            }
        }
        public  void affMap()
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < Plateau.GetLength(0); i++)
            {
                for (int j = 0; j < Plateau.GetLength(1); j++)
                {
                    // Quadrillage
                    Console.ForegroundColor = ConsoleColor.White;
                    symbole = null;
                    if( ((i==0) && (j > 0) && (j < Plateau.GetLength(1) - 1)) || ((i==Plateau.GetLength(0)-1)&&(j>0) && (j < Plateau.GetLength(1) - 1)))
                    {
                        symbole = "-";
                    }
                    if((j==0) || (j== Plateau.GetLength(1) - 1))
                    {
                        symbole = "|";
                    }

                    // Les planetes
                    if((j==3) && (i==3))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(symbole);
                        continue;
                    }
                    if((j==6)&&(i==1))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == 8) && (i == 2))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(symbole);
                        continue;
                    }

                    if ((j == 10) && (i == 3))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == 13) && (i == 3))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == 14) && (i == 1))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == 20) && (i == 2))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(symbole);
                        continue;
                    }
                    // Etoile de la mort
                    if ((j==Plateau.GetLength(1) - 2) && (i==1))
                    {
                        symbole = "╗";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if((j == Plateau.GetLength(1) - 3) && (i == 1))
                    {
                        symbole = "═";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if((j == Plateau.GetLength(1) - 4) && (i == 1))
                    {
                        symbole = "╔";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == Plateau.GetLength(1) - 2) && (i == 2))
                    {
                        symbole = "║";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == Plateau.GetLength(1) - 4) && (i == 2))
                    {
                        symbole = "║";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == Plateau.GetLength(1) - 4) && (i == 3))
                    {
                        symbole = "╚";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == Plateau.GetLength(1) - 3) && (i == 3))
                    {
                        symbole = "═";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if ((j == Plateau.GetLength(1) - 2) && (i == 3))
                    {
                        symbole = "╝";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(symbole);
                        continue;
                    }
                    if (symbole==null)
                    {
                    symbole= " ";
                    }
                    Console.Write(symbole);
                }
                Console.WriteLine();
            }
        }
    }
}
