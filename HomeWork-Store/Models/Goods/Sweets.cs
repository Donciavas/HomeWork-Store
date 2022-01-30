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
        public float Carbohydrates { get; set; }

        public Sweets(float carbohydrates, decimal price, float barcode, float weight) : base(price, barcode, weight)
        {
            Carbohydrates = carbohydrates;
        }
    }
}