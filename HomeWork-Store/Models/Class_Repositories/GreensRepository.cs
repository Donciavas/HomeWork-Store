using Models.Functionalities;
using Models.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CSV_Repositories
{
    public class GreensRepository
    {
        public List<Greens> GreensList { get; set; }

        public GreensRepository()
        {
            GreensList = new List<Greens>();
        }
        public List<Greens> LoadGreensCSVData()
        {
            var handler = new CSV_Handler();
            GreensList = handler.ReadGreensCSVData("Greens");
            return GreensList;
        }
        public void AddGreensToCSV(Greens greens)
        {
            var handler = new CSV_Handler();
            handler.WriteGreensDataToCSV("Greens", greens);
        }
    }
}