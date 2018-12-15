using prolet;
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
                    Plateau[i, j] = new Case(i,j);
                    
                }
            }
        }
        public  void affMap(Personnage heros)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
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
                    if(Plateau[i, j].Type == Case.Symbole.Planet)
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = Plateau[i,j].color;

                    }

                    // Etoile de la mort

                    if (Plateau[i,j].Type == Case.Symbole.Boss_tr)
                    {
                        symbole = "╗";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if(Plateau[i, j].Type == Case.Symbole.Boss_t)
                    {
                        symbole = "═";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if(Plateau[i, j].Type == Case.Symbole.Boss_tl)
                    {
                        symbole = "╔";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if (Plateau[i, j].Type == Case.Symbole.Boss_m)
                    {
                        symbole = "║";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if (Plateau[i, j].Type == Case.Symbole.Boss_bl)
                    {
                        symbole = "╚";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if (Plateau[i, j].Type == Case.Symbole.Boss_b)
                    {
                        symbole = "═";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if (Plateau[i, j].Type == Case.Symbole.Boss_br)
                    {
                        symbole = "╝";
                        Console.ForegroundColor = Plateau[i, j].color;
                    }
                    if (Plateau[i, j].Type == Case.Symbole.Vide)
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
