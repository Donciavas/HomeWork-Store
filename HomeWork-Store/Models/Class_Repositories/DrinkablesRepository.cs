using Models.Functionalities;
using Models.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CSV_Repositories
{
    public class DrinkablesRepository
    {
        public List<Drinkables> DrinkablesList { get; set; }

        public DrinkablesRepository()
        {
            DrinkablesList = new List<Drinkables>();
        }
        public List<Drinkables> LoadDrinkablesCSVData()
        {
            var handler = new CSV_Handler();
            DrinkablesList = handler.ReadDrinkablesCSVData("Drinkables");
            return DrinkablesList;
        }
        public void AddDrinkablesToCSV(Drinkables drinkables)
        {
            var handler = new CSV_Handler();
            handler.WriteDrinkablesDataToCSV("Drinkables", drinkables);
        }
    }
}