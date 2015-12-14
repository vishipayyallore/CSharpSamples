using System;
using CSharp.Samples.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Samples.DataModelsTests
{

    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void When_Product_Default_Constructor_Called()
        {
            var product = new Product();
            Console.WriteLine(product);
        }

        [TestMethod]
        public void When_Product_Parameterized_Constructor_Called()
        {
            var product = new Product("Car", 1736.45M, "Tata");
            Console.WriteLine(product);
        }
    }

}
