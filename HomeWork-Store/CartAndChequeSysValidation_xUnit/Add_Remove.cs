using Models.Functionalities;
using System;
using Xunit;

namespace CartAndChequeSysValidation_xUnit
{
    public class CartAndChequeSystemValidation_xUnit
    {
        [Fact]
        public void CartAndChequeSystem_Calculation_Validation_AddingItems()
        {
            // Arange
            CartAndChequeSystem.cartTotal = 50m;
            CartAndChequeSystem.wallet = 100m;
            CartAndChequeSystem.AddSweetsToCartList(2); // 3.50
            CartAndChequeSystem.AddMeatsToCartList(0); // 2.49 
            CartAndChequeSystem.AddGreensToCartList(1); // 1.19
            CartAndChequeSystem.AddDrinkablesToCartList(3); // 1.29
            // Act
            decimal test1Result = CartAndChequeSystem.cartTotal;

            // Asert
            Assert.Equal(58.47m, test1Result);
        }
        [Fact]
        public void CartAndChequeSystem_Calculation_Validation_RemovingItems()
        {
            // Arange
            CartAndChequeSystem.cartTotal = 50m;
            CartAndChequeSystem.wallet = 100m;
            CartAndChequeSystem.AddSweetsToCartList(2); // 3.50
            CartAndChequeSystem.AddMeatsToCartList(0); // 2.49 
            CartAndChequeSystem.AddGreensToCartList(1); // 1.19

            CartAndChequeSystem.RemoveFromCart(2);
            // Act
            decimal test1Result = CartAndChequeSystem.cartTotal;
            int test2Result = CartAndChequeSystem.moneyOperations.Count;

            // Asert
            Assert.Equal(54.69m, test1Result);
            Assert.Equal(2, test2Result);
        }
    }
}
