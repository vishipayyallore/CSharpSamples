using System;
using CSharp.Samples.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Samples.UtilitiesTests
{

    [TestClass]
    public class NameGeneratorTests
    {

        [TestMethod]
        public void WhenASingleNameIsGenerated()
        {
            Console.WriteLine(NameGenerator.GenerateName());
        }

        [TestMethod]
        public void When10NamesAreGenerated()
        {
            for (var iCtr = 1; iCtr <= 10; iCtr++)
            {
                Console.WriteLine(NameGenerator.GenerateName());
            }
        }
    }

}