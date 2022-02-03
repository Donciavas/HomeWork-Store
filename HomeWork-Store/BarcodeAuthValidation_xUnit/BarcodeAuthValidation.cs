using Models.CSV_Repositories;
using Models.Functionalities;
using System;
using Xunit;

namespace BarcodeAuthValidation_xUnit
{
    public class BarcodeAuthenticatorValitation_xUnit
    {
        [Fact]
        public void Test_To_Verify_Barcode_Authentication()
        {
            // Arange
            var itemIdentifier = new BarcodeAuthenticator();

            var sweetsRepository = new SweetsRepository();
            var meatsRepository = new MeatsRepository();
            var greensRepository = new GreensRepository();
            var drinkablesRepository = new DrinkablesRepository();

            // Act
            string test1Result = itemIdentifier.ItemIdentifier(sweetsRepository.LoadSweetsCSVData()[0].Barcode);
            string test2Result = itemIdentifier.ItemIdentifier(meatsRepository.LoadMeatsCSVData()[0].Barcode);
            string test3Result = itemIdentifier.ItemIdentifier(greensRepository.LoadGreensCSVData()[0].Barcode);
            string test4Result = itemIdentifier.ItemIdentifier(drinkablesRepository.LoadDrinkablesCSVData()[0].Barcode);

            // Asert
            Assert.Equal("Chocolate", test1Result);
            Assert.Equal("Insects", test2Result);
            Assert.Equal("Rhubarb", test3Result);
            Assert.Equal("Cola", test4Result);
        }
    }
}