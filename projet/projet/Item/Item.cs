﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    abstract class Item
    {
        public string name;
        public string description;
        public float value;
        public int id;
        public float prix;
        public Item(string n)
        {
            name = n;
        }
    }
}
