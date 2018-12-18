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
            else if( n== "pistolet laser")
            {
                id = 2;
                name = n;
                value = 500;
                prix = 50;
            }
            else if(n=="couteau")
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
