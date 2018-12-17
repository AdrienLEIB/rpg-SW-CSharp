using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class arme:Item
    {
        public enum ArmeType { sabrelaser, pistolerlaser}
        public ArmeType type;

        public arme():base()
        {
            id = 2;
            name = "sabre laser";
            value = 100;
        }
    }
}
