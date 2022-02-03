using Models.CSV_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functionalities
{
    public class DataPrinting
    {
        #region DETAILED-CONSOLE-UI
        public static void PrintProductData_Sweets()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in sweetsRepository.LoadSweetsCSVData())
            {
                Console.WriteLine($"Product: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     contains: {item.Sugars} sugars");
                Console.WriteLine($" costs: {item.Price} Eur");
                Console.WriteLine($" barcode: {item.Barcode}");
                Console.WriteLine($"   weight: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Meats()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in meatsRepository.LoadMeatsCSVData())
            {
                Console.WriteLine($"Product: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     contains: {item.Proteins} proteins");
                Console.WriteLine($" costs: {item.Price} Eur");
                Console.WriteLine($" barcode: {item.Barcode}");
                Console.WriteLine($"   weight: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Greens()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in greensRepository.LoadGreensCSVData())
            {
                Console.WriteLine($"Product: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     contains: {item.Fibers} fibers");
                Console.WriteLine($" costs: {item.Price} Eur");
                Console.WriteLine($" barcode: {item.Barcode}");
                Console.WriteLine($"   weight: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Drinkables()
        {
            var drinkablesRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in drinkablesRepository.LoadDrinkablesCSVData())
            {
                Console.WriteLine($"Product: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"      yra: {item.Volume} ml container");
                Console.WriteLine($" costs: {item.Price} Eur");
                Console.WriteLine($" barcode: {item.Barcode}");
                Console.WriteLine($"   weight: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintAllCVS_dir()
        {
            PrintProductData_Sweets();
            PrintProductData_Meats();
            PrintProductData_Greens();
            PrintProductData_Drinkables();
        }
        #endregion

        #region MINI-CONSOLE-UI
        public static void ProductSelectorSubMenu_Sweets()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            sweetsRepository.LoadSweetsCSVData();

            Console.WriteLine($"                    -> [1] Sweets     -> [1] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[0].Barcode)}");
            Console.WriteLine($"[2] Choose goods                      -> [2] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[1].Barcode)}");
            Console.WriteLine($"                                      -> [3] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[2].Barcode)}");
            Console.WriteLine($"                                      -> [4] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[3].Barcode)}");
            Console.WriteLine($"                                                        ");
        }
        public static void ProductSelectorSubMenu_Meats()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            meatsRepository.LoadMeatsCSVData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Choose goods  -> [2] Meat products     -> [1] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[0].Barcode)}");
            Console.WriteLine($"                                           -> [2] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[1].Barcode)}");
            Console.WriteLine($"                                           -> [3] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[2].Barcode)}");
            Console.WriteLine($"                                           -> [4] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[3].Barcode)} ");
        }
        public static void ProductSelectorSubMenu_Greens()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            greensRepository.LoadGreensCSVData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Choose goods                                        ");
            Console.WriteLine($"                    -> [3] Greens   -> [1] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[0].Barcode)}");
            Console.WriteLine($"                                    -> [2] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[1].Barcode)}");
            Console.WriteLine($"                                    -> [3] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[2].Barcode)}");
            Console.WriteLine($"                                    -> [4] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[3].Barcode)}");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
        public static void ProductSelectorSubMenu_Drinkables()
        {
            var drinkablessRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            drinkablessRepository.LoadDrinkablesCSVData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Choose goods                                        ");
            Console.WriteLine($"                                                        ");
            Console.WriteLine($"                 -> [4] Drinkables -> [1] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[0].Barcode)}");
            Console.WriteLine($"                                   -> [2] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[1].Barcode)}");
            Console.WriteLine($"                                   -> [3] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[2].Barcode)}");
            Console.WriteLine($"                                   -> [4] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[3].Barcode)}");
        }
        #endregion

        #region OTHER PRINTING
        public static void PrintCart()
        {
            if (CartAndChequeSystem.cartList.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Cart:");
                int index = 1;
                foreach (var item in CartAndChequeSystem.cartList)
                {
                    Console.WriteLine($"   Item #{index++}: {item}");
                }
            }
        }

        public static void PrintCartAndWallet()
        {
            int index = 1;
            foreach (var item in CartAndChequeSystem.cartList)
            {
                Console.WriteLine($"Item #{index++}: {item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Amount paid: {CartAndChequeSystem.cartTotal} Eur");
            Console.WriteLine();
            Console.WriteLine($"     Wallet: {CartAndChequeSystem.wallet} Eur");
            Console.WriteLine();
            CartAndChequeSystem.CheckBalance();
        }
        public static void PrintCheque() // <-- Šita funkcija niekur nenaudojama. Laiško teksto konstrukciją atlieka 
        {                                //     CartAndChequeSystem.ConstructChequeString()
            int index = 1;
            foreach (var item in CartAndChequeSystem.cartList)
            {
                Console.WriteLine($"Item #{index++}: {item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Amount paid: {CartAndChequeSystem.cartTotal} Eur");
            Console.WriteLine();
            Console.WriteLine($"Date of purchase: {DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}, " +
                                                         $"{DateTime.Now.Hour}:{DateTime.Now.Minute} ");
            Console.WriteLine();
        }

        public static void ThankYouForShopping()
        {
            Console.WriteLine($"Check sent via email");
            Console.WriteLine($"Thank you for buying! Please come again!");
            InputValidationSystem.ConsoleDelay(3000);
            Console.Clear();
            Environment.Exit(0);
        }

        #endregion
    }
}