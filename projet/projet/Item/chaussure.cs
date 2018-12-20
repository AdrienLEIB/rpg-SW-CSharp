using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class chaussure:Item
    {
        public enum ChaussureType { basket, converse}
        public ChaussureType type;
        public chaussure(string n):base(n)
        {
            if(n=="basket")
            {
                name = n;
                value = 200;
                prix = 10;
            }
            else if(n=="converse")
            {
                name = n;
                value = 500;
                prix = 20;
            }
            else
            {
                name = n;
                value = 0;
                prix = 0;
            }
            id = 2;
        }
    }
}
