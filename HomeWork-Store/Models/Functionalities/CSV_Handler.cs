using Models.Goods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functionalities
{
    public class CSV_Handler
    {
        #region SWEETS
        public void WriteSweetsDataToCSV(string coordinates, Sweets sweets) 
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{sweets.Sugars}, " +
                                                      $"{sweets.Price}, " +
                                                      $"{sweets.Barcode}, " +
                                                      $"{sweets.Weight}";
            File.AppendAllText(path, DataString);

        }
        public List<Sweets> ReadSweetsCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{CSVCoordinates}.csv";
            
            var CSVLineReader = new StreamReader(path);

            
            var sweetsRepository = new List<Sweets>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                sweetsRepository.Add(ItemParserSweets(valueCache));
            }
            return sweetsRepository;
        }
        public Sweets ItemParserSweets(string[] valueCache)
        {
            var sweetsParcel = new Sweets();
            sweetsParcel.Sugars = float.Parse(valueCache[0].ToString());
            sweetsParcel.Price = decimal.Parse(valueCache[1].ToString());
            sweetsParcel.Barcode = float.Parse(valueCache[2].ToString());
            sweetsParcel.Weight = float.Parse(valueCache[3].ToString());

            return sweetsParcel;
        }
        #endregion


        #region MEATS
        public void WriteMeatsDataToCSV(string coordinates, Meats meats) 
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{meats.Proteins}, " +
                                                      $"{meats.Price}, " +
                                                      $"{meats.Barcode}, " +
                                                      $"{meats.Weight}";
            File.AppendAllText(path, DataString);

        }
        public List<Meats> ReadMeatsCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{CSVCoordinates}.csv";
            
            var CSVLineReader = new StreamReader(path);

            
            var meatsRepository = new List<Meats>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                meatsRepository.Add(ItemParserMeats(valueCache));
            }
            return meatsRepository;
        }
        public Meats ItemParserMeats(string[] valueCache)
        {
            var meatsParcel = new Meats();
            meatsParcel.Proteins = float.Parse(valueCache[0].ToString());
            meatsParcel.Price = decimal.Parse(valueCache[1].ToString());
            meatsParcel.Barcode = float.Parse(valueCache[2].ToString());
            meatsParcel.Weight = float.Parse(valueCache[3].ToString());

            return meatsParcel;
        }
        #endregion


        #region GREENS
        public void WriteGreensDataToCSV(string coordinates, Greens greens) 
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{greens.Fibers}, " +
                                                      $"{greens.Price}, " +
                                                      $"{greens.Barcode}, " +
                                                      $"{greens.Weight}";
            File.AppendAllText(path, DataString);

        }
        public List<Greens> ReadGreensCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{CSVCoordinates}.csv";
            
            var CSVLineReader = new StreamReader(path);

            
            var greensRepository = new List<Greens>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                greensRepository.Add(ItemParserGreens(valueCache));
            }
            return greensRepository;
        }
        public Greens ItemParserGreens(string[] valueCache)
        {
            var greensParcel = new Greens();
            greensParcel.Fibers = float.Parse(valueCache[0].ToString());
            greensParcel.Price = decimal.Parse(valueCache[1].ToString());
            greensParcel.Barcode = float.Parse(valueCache[2].ToString());
            greensParcel.Weight = float.Parse(valueCache[3].ToString());

            return greensParcel;
        }
        #endregion


        #region DRINKABLES
        public void WriteDrinkablesDataToCSV(string coordinates, Drinkables drinkables)  
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{drinkables.Volume}, " +
                                                      $"{drinkables.Price}, " +
                                                      $"{drinkables.Barcode}, " +
                                                      $"{drinkables.Weight}";
            File.AppendAllText(path, DataString);

        }
        public List<Drinkables> ReadDrinkablesCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\Models\CSV_DataBase\{CSVCoordinates}.csv";
            
            var CSVLineReader = new StreamReader(path);
            
            var drinkablesRepository = new List<Drinkables>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                drinkablesRepository.Add(ItemParserDrinkables(valueCache));
            }
            return drinkablesRepository;
        }
        public Drinkables ItemParserDrinkables(string[] valueCache)
        {
            var drinkablesParcel = new Drinkables();
            drinkablesParcel.Volume = float.Parse(valueCache[0].ToString());
            drinkablesParcel.Price = decimal.Parse(valueCache[1].ToString());
            drinkablesParcel.Barcode = float.Parse(valueCache[2].ToString());
            drinkablesParcel.Weight = float.Parse(valueCache[3].ToString());

            return drinkablesParcel;
        }
        #endregion

    }
}