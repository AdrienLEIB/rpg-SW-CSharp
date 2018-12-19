using prolet;
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
    public static bool Indice()
        {
            string mdp = "";
            bool indice = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ____
                 _.' :  `._
             .-.'`.  ;   .'`.-.
    __      / : ___\ ;  /___ ; \      __
  ,'_ ''--.:__;'.-.';: :'.-.':__;.--'' _`,
  :' `.t''--.. ' <@.`; _  ',@>` ..--''j.' `;
       `:-.._J '-.-'L__ `--' L_..-;'
         '-.__ ;  .-'  '-.  : __.-'
             L ' /.------.\ ' J
              '-.   '--'   .-'
             __.l'-:_JL_;-';.__
          .- j / '.;  ;''''  / .'\'-.
           .' /:`. '-.:     .-' .';  `.
     .-'  / ;  ' -. '-..-'.- '  :    ' -.
 
   .+ '-.  : :      ' -.__.- '      ;-._   \
   ; \  `.; ;                    : : '+. ;
  :  ; ; ;                    : ;  : \:
 : `.'-; ;  ;                  :  ;   ,/;
  ; -: ;  :                ;  : .-''  :
  :\     \  : ;             : \.-'      :
   ;`.    \  ; :            ;.'_..--  / ;
   :  '-.  ' -:  ;          :/.'      .'  :
     \       .-`.\        / t - ''  ':-+.   :
      `.  .-'    `l    __/ /`. :  ; ; \  ;
        \   .-' .-' -.- '  .' .'j \  /   ;/
         \ / .- '   /.     .'.' ;_:'    ;
          :-'' -.`./ -.'     /    `.___.'
                \ `t._ / 
                '-.t-._:'

");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Un indice à l'enigme, chaque planete dans l'odre croissant est...");
                mdp = Console.ReadLine();
            if(mdp =="vador")
            {
                Console.Clear();
                Console.WriteLine(" Reusis, vous avez. Repartir avec la carte vous pouvez");
                Thread.Sleep(1000);
                indice = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Echoué vous avez. Revenir plus tard vous devez");
                Thread.Sleep(1000);
                indice = false;
            }
            return indice;
        }
    }
}
