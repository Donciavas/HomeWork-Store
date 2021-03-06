using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functionalities
{
    public class StoreFrontMenu
    {
        public static void Menu()
        {
            Console.WriteLine($"Wallet: ___ Eur");
            decimal walletInput = InputValidationSystem.InputValidationDecimal();
            CartAndChequeSystem.wallet = walletInput; // <-- pasikviečiu klasės CartAndChequeSystem "Global'ą",
                                                      //     kuris laikys sumas, etc.
            #region MENU
            while (true)
            {
                Console.WriteLine($"MENIU");
                Console.WriteLine($"Available options");
                Console.WriteLine($"[1] Catalogue");
                Console.WriteLine($"[2] Choose goods");
                Console.WriteLine($"[3] Cart");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int input = InputValidationSystem.InputValidation(3);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Catalogue();
                        break;
                    case 2:
                        AddToCart();
                        break;
                    case 3:
                        PurchaseSubMenu();
                        break;
                        
                }
            }
            #endregion

            #region SUBMENU - Show goods
            static void Catalogue()
            {
                Console.WriteLine($"[1] Show goods      -> [1] Sweets");
                Console.WriteLine($"                    -> [2] Meat products");
                Console.WriteLine($"                    -> [3] Greens");
                Console.WriteLine($"                    -> [4] Drinkables");
                Console.WriteLine($"                    -> [5] All Catalogue");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();
        
                int input = InputValidationSystem.InputValidation(5);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        DataPrinting.PrintProductData_Sweets();
                        break;
                    case 2:
                        DataPrinting.PrintProductData_Meats();
                        break;
                    case 3:
                        DataPrinting.PrintProductData_Greens();
                        break;
                    case 4:
                        DataPrinting.PrintProductData_Drinkables();
                        break;
                    case 5:
                        DataPrinting.PrintAllCVS_dir();
                        break;
                }
            }
            #endregion

            #region SUBMENU - to Choose goods
            static void AddToCart()
            {
                Console.WriteLine($"                    -> [1] Sweets");
                Console.WriteLine($"[2] Choose goods    -> [2] Meat products");
                Console.WriteLine($"                    -> [3] Greens");
                Console.WriteLine($"                    -> [4] Drinkables");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int input = InputValidationSystem.InputValidation(4);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        DataPrinting.ProductSelectorSubMenu_Sweets();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddSweetsToCartList(index - 1);
                        break;
                    case 2:
                        DataPrinting.ProductSelectorSubMenu_Meats();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index2 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddMeatsToCartList(index2 - 1);
                        break;
                    case 3:
                        DataPrinting.ProductSelectorSubMenu_Greens();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index3 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddGreensToCartList(index3 - 1);
                        break;
                    case 4:
                        DataPrinting.ProductSelectorSubMenu_Drinkables();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index4 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddDrinkablesToCartList(index4 - 1);
                        break;
                }
            }
            #endregion

            #region SUBMENU - Cart
            static void PurchaseSubMenu()
            {
                Console.WriteLine($"Meniu");
                Console.WriteLine($"Available options");
                Console.WriteLine($"[1] Catalogue");
                Console.WriteLine($"[2] Choose goods");
                Console.WriteLine($"[3] Cart             -> [1] Show my cart");
                Console.WriteLine($"                     -> [2] Remove from cart");
                Console.WriteLine($"                     -> [3] Confirm purchase");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int menuInput = InputValidationSystem.InputValidation(3);
                Console.Clear();

                switch (menuInput)
                {
                    case 1:
                        DataPrinting.PrintCartAndWallet();
                        break;
                    case 2:
                        CartAndChequeSystem.ShowCurrentCartWithIndexing();
                        Console.WriteLine($"Select the index of the item to be removed");
                        int indexToRemove = InputValidationSystem.InputValidation(CartAndChequeSystem.moneyOperations.Count + 1); 
                        CartAndChequeSystem.RemoveFromCart(indexToRemove);                                                        
                        break;
                    case 3:
                        CartAndChequeSystem.CheckWallet();
                        MailingSystem.MIMEMessage();
                        DataPrinting.ThankYouForShopping();
                        break;
                }
            }
            #endregion
        }
    }
}