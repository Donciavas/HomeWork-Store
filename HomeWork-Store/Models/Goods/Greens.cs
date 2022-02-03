using Models.MainHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Goods
{
    public class Greens : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Greens(skaidulinės medžiagos)
        public float Fibers { get; set; }

        public Greens(float fibers = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Fibers = fibers;
        }
    }
}