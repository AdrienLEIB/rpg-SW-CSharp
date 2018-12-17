using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Boss
    {
        public enum Planete {  };
        public string name;
        public float hp;
        public float atk;
        public float def;
        public float speed;
        public Boss(string n)
        {
            name = n;
            if (name == "Vador")
            {
                hp = 2000;
                atk = 2500;
                def = 2500;
                speed = 2500;
            }
            
        }
    }
}
