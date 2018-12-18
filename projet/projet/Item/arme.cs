using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class arme:Item
    {

        public arme(string n):base(n)
        {
            if (n == "sabrelaser") { 
                id = 2;
                name = n;
                value = 5000;
                prix = 1000;
            }
            if( n== "pistoler laser")
            {
                id = 2;
                name = n;
                value = 500;
                prix = 50;
            }
            if(n=="coteau")
            {
                id = 2;
                name = n;
                value = 20;
            }
            else
            {
                id = 2;
                name = n;
                value = 0;
            }
        }
    }
}
