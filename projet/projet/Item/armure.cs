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
        public ArmureType type;
        public armure():base()
        {
            id = 1;
        }

    }
}
