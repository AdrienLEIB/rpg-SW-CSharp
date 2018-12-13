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
        public Map(int largeur, int longueur)
        {
            Plateau = new Case[largeur, longueur];

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    Plateau[i, j] = new Case();
                    
                }
            }
        }
        public  void affMap()
        {
            for (int i = 0; i < Plateau.GetLength(0); i++)
            {
                for (int j = 0; j < Plateau.GetLength(1); j++)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.Write("▲");
                }
                Console.WriteLine();
            }
        }
    }
}
