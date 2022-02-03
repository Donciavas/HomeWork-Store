using Models.MainHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Goods
{
    public class Sweets : Item
    {
        // - Vaikinės prekės klasės:
        //			                - Saldainiai(cukrus)
        public float Sugars { get; set; }

        public Sweets(float sugars = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Sugars = sugars;
        }
    }
}