using System;
using CSharp.Samples.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Samples.UtilitiesTests
{

    [TestClass]
    public class CurrencyGeneratorTests
    {

        [TestMethod]
        public void WhenACurrencyIsGenerated()
        {
            var currencyGenerator = new CurrencyGenerator();
            Console.WriteLine(currencyGenerator.GenerateAmount());
        }

        [TestMethod]
        public void When10DifferentCurrenciesAreGenerated()
        {
            var currencyGenerator = new CurrencyGenerator();
            for (var iCtr = 1; iCtr <= 10; iCtr++)
            {
                Console.WriteLine(currencyGenerator.GenerateAmount());
            }
        }

    }
}
