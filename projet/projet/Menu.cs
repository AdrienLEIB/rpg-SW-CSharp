using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Menu
    {
        public static int AskChoice(int min, int max)
        {
            // on transforme le string en int
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }
    }
}
