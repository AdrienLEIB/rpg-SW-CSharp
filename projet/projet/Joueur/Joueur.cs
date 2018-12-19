using prolet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace projet
{
        abstract class Joueur
    {
        public string name;
        public string heros;
        public bool indice;

        public float lvl;
        public float xp;
        public float xp_save;

        public float hp;
        public float atk;
        public float def;
        public float speed;
        public float money;
        public float atk_base;
        public float def_base;
        public float hp_base;
        public float speed_base;
        public int x;
        public int y;
        public string symbole;
        public Inventaire inv;
        public Equipement equip;
        public Joueur(string n)
        {
            name = n;
            indice = false;
            lvl = 0;
            xp = 0;
            xp_save = 10;
            money = 2000;
            x = 1;
            y = 1;
            symbole = "˅";
            inv = new Inventaire();
            equip = new Equipement();
            
        }
        public void Deplacement(Map map)
        {
            int dep = 5;
            Boss vador = new Vador();


                if ((x>=1)&&(x<4)  && (y >= 1) &&(y<29)) { 
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    dep = Program.AskChoice(0, 6);
                }
                if ((x == 0)&&(x<4) && (y >0) &&(y<29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    dep = Program.AskChoice(1, 6);
                }

                if ((x > 0) && (x == 4) && (y > 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while (dep == 1);

                }
                if ((x > 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 2-Est \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while (dep ==3);
                }

                if ((x > 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 1-Sud \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while (dep == 2);
                }

                if ((x == 0) && (x < 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller :  \n 1-Sud \n 2-Est \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while ((dep == 0) || (dep == 3));

                }
                if ((x == 0) && (x < 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 1-Sud \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while ((dep == 0) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y > 0) && (y == 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 3-Ouest \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while ((dep == 1) || (dep == 2));

                }
                if ((x > 0) && (x == 4) && (y == 0) && (y < 29))
                {
                    Console.WriteLine("\n Vous souhaitez aller : \n 0-Nord \n 2-Est \n 4-Inventaire \n 5-Information \n 6-Save");
                    do
                    {
                        dep = Program.AskChoice(0, 6);
                    } while ((dep == 1) || (dep == 3));

                }
                switch (dep)
                {
                    case 0:
                        x = x - 1;
                        symbole = "˄";
                        break;
                    case 1:
                        x = x + 1;
                        symbole = "˅";
                        break;
                    case 2:
                        y = y + 1;
                        symbole = "˃";
                        break;
                    case 3:
                        y = y - 1;
                        symbole = "˂";
                        break;
                    case 4:
                        inv.affInventaire();
                        int j = Program.AskChoice(0,inv.item.Count+1);
                        if(j<=inv.item.Count)
                        { 
                            Console.WriteLine("Voulez-vous vous équiper de " +inv.item[j-1].name  +  "\n 1- Oui \n 2- Nom");
                            int use = Program.AskChoice(1,2);
                            if (use==1)
                            {
                                equip.addEquip(inv.item[j-1]);
                                atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
                                def = (def_base * (lvl + 1)) + equip.equipement[0].value;
                                speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
                            }
                        }
                        
                        break;
                    case 5:
                        Console.Clear();
                        information();
                        Console.WriteLine(@"                                Continuer ->");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        save();
                        break;

                }
        }
        public virtual int Combat(Boss b)
        {
            int result = 0;
            Console.WriteLine("Un Dark Vador sauvage apparaît !");
            Thread.Sleep(1000);
            Console.Clear();
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(@"                       .-.
                           .-.
                          |_:_|
                         /(_Y_)\
    .                   ( \/M\/ )
     '.               _.'-/'-'\-'._
       ':           _/.--'[[[[]'--.\_
         ':        /_'  : |:: | :  '.\
           ':     //   ./ |oUU| \.'  :\
             ':  _:'..' \_|___|_/ :   :|
               ':.  .' | _[___]_ |  :.':\
                [::\ |  :  | |  :   ; : \
                 '-'   \/ '.| |.' \  .;.' |
                  |\_    \  '-'   :       |
 
                  |  \    \ .:    :   |   |
 
                  |   \    | '.   :    \  |
                  /       \   :. .;       |
 
                 /     |   |  :__ /     :  \\
               |  |   |    \:   | \   |   ||
              /    \  : :  |:   /  | __ |   /|
          snd |     : : :_ / _ |  / '._\  '-- | _\
              / ___.-/ _ | -'   \  \
                             '-'");
                Console.WriteLine(b.hp + " PV");
                Console.WriteLine("Vous souhaitez : \n 1- Attaquer \n 2- Inventaire \n 3- Fuir");
                choice = Program.AskChoice(1, 3);
                switch (choice)
                {
                    case 1:
                        damage_boss(b);
                        damage_player(b);
                        break;
                    case 2:
                        inv.affInventaire();
                        int j = Program.AskChoice(0, inv.item.Count + 1);
                        if (j <= inv.item.Count)
                        {
                            Console.WriteLine("Voulez-vous vous équiper de " + inv.item[j - 1].name + "\n 1- Oui \n 2- Nom");
                            int use = Program.AskChoice(1, 2);
                            if (use == 1)
                            {
                                equip.addEquip(inv.item[j - 1]);
                                atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
                                def = (def_base * (lvl + 1)) + equip.equipement[0].value;
                                speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
                            }
                        }
                        break;
                    case 3:
                        break;
                }
                if (hp <= 0)
                {
                    result = 2;
                }
                if (b.hp <= 0)
                {
                    result = 1;
                }
                if ((hp <= 0) && (b.hp <= 0))
                {
                    if (speed >= b.speed)
                    {
                        result = 1;
                    }
                    if (speed < b.speed)
                    {
                        result = 2;
                    }
                }
            } while ((choice != 3) && (result == 0) );;
            return result;
        }
        public virtual int Combat_storm(Boss b)
        {
            int result = 0;
            int choice;
            Console.Clear();


            do {
                Console.Clear();
                Console.WriteLine(@"
                         /__\ 
                        |<><>| 
                        (_/\_)   
                       /      \ 
                      //| __  \\  
                     // |/  \| || 
                    //__[][][] ||  
                   /|'  |\  /|.'| 
                        |_||_| \  
                        [ ][ ]   \
                        | || |     \ 
                        [_][_]        ");
                Console.WriteLine(b.hp + " PV");
            Console.WriteLine("Vous souhaitez : \n 1- Attaquer \n 2- Inventaire \n 3- Fuir");
            choice = Program.AskChoice(1, 3);
            
            switch (choice)
            {
                case 1:
                    damage_boss(b);
                    damage_player(b);
                    break;
                case 2:
                    inv.affInventaire();
                    int j = Program.AskChoice(0, inv.item.Count + 1);
                    if (j <= inv.item.Count)
                    {
                        Console.WriteLine("Voulez-vous vous équiper de " + inv.item[j - 1].name + "\n 1- Oui \n 2- Nom");
                        int use = Program.AskChoice(1, 2);
                        if (use == 1)
                        {
                            equip.addEquip(inv.item[j - 1]);
                            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
                            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
                            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
                        }
                    }
                        break;
                case 3:
                    break;
            }
            if (hp <= 0)
            {
                result = 2;
                money = money - 100;
            }
            if (b.hp <= 0)
            {
                result = 1;
                money = money + 100;
                experience();
            }
            if ((hp <= 0) && (b.hp <= 0))
            {
                if (speed >= b.speed)
                {
                    result = 1;
                    money = money + 100;
                }
                if (speed < b.speed)
                {
                    result = 2;
                    money = money - 100;
                }
            }
                
        } while ((choice != 3) && (result == 0) );
            return result;
        }
        public void damage_boss(Boss boss)
        {
                if (atk > boss.def)
                {
                    boss.hp = boss.hp - (atk - boss.def);
                }
                if (atk <= boss.def)
                {
                    boss.hp = boss.hp - 1;
                }
        }
        public void damage_player(Boss boss)
        {
            if (boss.atk > def)
            {
                hp = hp - (boss.atk - def);
            }
            if (boss.atk <= def)
            {
                hp = hp - 1;
            }
        }
        public void experience()
        {
            xp = xp + 10;
            while(xp >= (xp_save))
            {
                xp = xp_save  - xp;
                lvl = lvl + 1;
                xp_save = xp_save * (lvl + 1);
                atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
                def = (def_base * (lvl + 1)) + equip.equipement[0].value;
                speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
                hp = (hp_base * (lvl + 1));
            }
        }
        public void information()
        {
            Console.WriteLine("Nom " + name);
            Console.WriteLine("HP " +hp);
            Console.WriteLine("Level " + lvl);
            Console.WriteLine("Attaque "+ atk);
            Console.WriteLine("Defense " + def);
            Console.WriteLine("Speed " + speed);
            Console.WriteLine("XP " + xp);
            Console.WriteLine("Monnai " + money);
        }
        public  bool Indice()
        {
            string mdp = "";
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
            Console.WriteLine(" chaque première lettre de chaque planete dans l'odre croissant est !,");
            mdp = Console.ReadLine();
            if (mdp == "vador")
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
        public void save()
        {

            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter sw = new StreamWriter(path + @"\load_heros.txt", false))
            {
                sw.WriteLine();
                sw.WriteLine(name);
                sw.WriteLine(heros);
                sw.WriteLine(indice);
            }
            using (StreamWriter sw = new StreamWriter(path + @"\load_save.txt", false))
            {
                sw.WriteLine();
                sw.WriteLine(lvl);
                sw.WriteLine(xp);
                sw.WriteLine(xp_save);
                sw.WriteLine(x);
                sw.WriteLine(y);
                sw.WriteLine(symbole);
                sw.WriteLine(money);
                //sw.WriteLine(inv);
                //sw.WriteLine(equip);

            }
            using (StreamWriter sw = new StreamWriter(path + @"\load_inventaire.txt", false))
            {
                for (int i = 0; i < inv.item.Count; i++)
                {
                    sw.WriteLine(inv.item[i].name);
                }

            }
            using (StreamWriter sw = new StreamWriter(path + @"\load_equip.txt", false))
            {
                sw.WriteLine(equip.equipement[0].name);
                sw.WriteLine(equip.equipement[1].name);
                sw.WriteLine(equip.equipement[2].name);
            }
        }

        public void loadSave()
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamReader sr = new StreamReader(path + @"\load_save.txt"))
            {
                int count = 0;
                string l1;
                sr.ReadLine();
                string[] tab = new string[8];
                while ((l1 = sr.ReadLine()) != null)
                {
                    tab[count] = l1;
                    count++;
                    

                }
                lvl = float.Parse(tab[0]);
                xp = float.Parse(tab[1]);
                xp_save = float.Parse(tab[2]);
                x = int.Parse(tab[3]);
                y = int.Parse(tab[4]);
                symbole = tab[5];
                money = float.Parse(tab[6]);
            }
            using (StreamReader sr = new StreamReader(path + @"\load_inventaire.txt"))
            {
                int count = 0;
                string l1;
                string name;
                sr.ReadLine();
                while ((l1 = sr.ReadLine()) != null)
                {
                    name = l1;
                    if ((name == "couteau") || (name == "pistolet laser") || (name == "sabrelaser"))
                    {
                        Item item = new arme(name);
                        inv.addInventaire(item);
                    }
                    else if((name == "fer") || (name == "diamant"))
                    {
                        Item item = new armure(name);
                        inv.addInventaire(item);
                    }
                    else if((name =="basket") || (name == "converse"))
                    {
                        Item item = new chaussure(name);
                        inv.addInventaire(item);
                    }

                }
            }
            using (StreamReader sr = new StreamReader(path + @"\load_equip.txt"))
            {
                int count = 0;
                string l1;
                string name;
                sr.ReadLine();
                while ((l1 = sr.ReadLine()) != null)
                {
                    name = l1;
                    if ((name == "couteau") || (name == "pistolet laser") || (name == "sabrelaser"))
                    {
                        Item item = new arme(name);
                        equip.equipement[1] = item;
                    }
                    else if ((name == "fer") || (name == "diamant"))
                    {
                        Item item = new armure(name);
                        equip.equipement[2] = item;
                    }
                    else if ((name == "basket") || (name == "converse"))
                    {
                        Item item = new chaussure(name);
                        equip.equipement[3] = item;
                    }

                }
            }
            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
        }
    }
}
