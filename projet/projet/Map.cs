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
                    if((j==3) && (i==3))
                    {
                        symbole = "Օ";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(symbole);
                        continue;
                    }
                    if(symbole==null)
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
