﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICA2.Models
{
    public class pizzamodel
    {
        public string pizzaname { get; set; }
        

        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }

        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }

        public bool Ham { get; set; }
        public bool Beef { get; set; }


        public float BasePrice { get; set; } = 10;
    }
}
