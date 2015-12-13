using System;
using CSharp.Samples.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Samples.UtilitiesTests
{

    [TestClass]
    public class AppSettingsHelperTests
    {

        [TestMethod]
        public void WhenAppSettingsValueExists()
        {
            Console.WriteLine(AppSettingsHelper.GetAppSettingsValue("MongoDbConfiguration"));
        }
    }
}