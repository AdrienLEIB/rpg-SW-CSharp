using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class armure:Item
    {
        public enum ArmureType { diamant, fer}

        public armure(string n):base(n)
        {
            if(n == "diamant")
            {
                name = n;
                value = 1500;
                prix = 100;

            }
            else if( n== "fer")
            {
                name = n;
                value = 500;
                prix = 25;
            }
            else
            {
                name = n;
                value = 0;
                prix = 0;
            }
            id = 0;
        }

    }
}
