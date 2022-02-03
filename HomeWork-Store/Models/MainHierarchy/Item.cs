using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MainHierarchy
{
    public class Item
    {
        // - Tėvinė klasė prekė (kaina, barcode, weight)
        public decimal Price { get; set; }
        public float Barcode { get; set; }
        public float Weight { get; set; }

        public Item(decimal price = 0m, float barcode = 0f, float weight = 0f)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;
        }
    }
}