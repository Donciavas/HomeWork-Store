﻿using Models.MainHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Goods
{
    public class Drinkables : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Drinkables(litrai)
        public float Volume { get; set; }

        public Drinkables(float volume = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Volume = volume;
        }
    }
}