using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functionalities
{
    public class BarcodeAuthenticator
    {
        public string ItemIdentifier(float barcode)
        {
            string returningName = "";
            switch (barcode)
            {
                case 12300001:
                    returningName = "Cola";
                    break;
                case 12300002:
                    returningName = "Water";
                    break;
                case 12300003:
                    returningName = "Cocktail";
                    break;
                case 12300004:
                    returningName = "Aperitivo";
                    break;

                case 12300011:
                    returningName = "Rhubarb";
                    break;
                case 12300012:
                    returningName = "Potato";
                    break;
                case 12300013:
                    returningName = "Tomato";
                    break;
                case 12300014:
                    returningName = "Cauliflower";
                    break;

                case 12300021:
                    returningName = "Insects";
                    break;
                case 12300022:
                    returningName = "Pork";
                    break;
                case 12300023:
                    returningName = "Beef";
                    break;
                case 12300024:
                    returningName = "Lab Meat";
                    break;

                case 12300031:
                    returningName = "Chocolate";
                    break;
                case 12300032:
                    returningName = "Wafers";
                    break;
                case 12300033:
                    returningName = "Lava Cake";
                    break;
                case 12300034:
                    returningName = "Confetti";
                    break;
            }
            return returningName;
        }
    }
}