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
        public chaussure():base()
        {
            id = 3;
        }
    }
}
