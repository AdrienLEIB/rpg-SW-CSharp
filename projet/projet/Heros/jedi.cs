﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class jedi:Joueur
    {
        public jedi(string n):base(n)
        {
            heros = "jedi";
            hp_base = 150;
            atk_base = 250;
            def_base = 100;
            speed_base = 250;


            atk = (atk_base * (lvl + 1)) + equip.equipement[1].value;
            def = (def_base * (lvl + 1)) + equip.equipement[0].value;
            speed = (speed_base * (lvl + 1)) + equip.equipement[2].value;
            hp = hp_base * (lvl + 1);
        }

        public override int Combat(Boss b)
        {
            int result = 0;
            Console.WriteLine("Un Dark Vador sauvage apparaît !");
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
            } while ((choice != 3) && (result == 0)); ;
            return result;
        }
        public  override int Combat_storm(Boss b)
        {
            int result = 0;
            int choice;
            Console.Clear();


            do
            {
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

            } while ((choice != 3) && (result == 0));
            return result;
        }
    }
}
