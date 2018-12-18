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
                id = 1;
                value = 1500;
                prix = 100;

            }
            if( n== "fer")
            {
                name = n;
                id = 1;
                value = 500;
                prix = 25;
            }
            else
            {
                name = n;
                id = 1;
                value = 0;
                prix = 0;
            }
            //id = 1;
        }

    }
}
