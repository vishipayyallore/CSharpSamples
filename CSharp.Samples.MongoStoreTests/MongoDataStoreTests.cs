using System;
using CSharp.Samples.MongoStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Samples.MongoStoreTests
{
    [TestClass]
    public class MongoDataStoreTests
    {
        [TestMethod]
        public void WhenDatabaseRetrievedFromMongoDataStore()
        {
            var mongoDataStoreInstance = MongoDataStore.DataStoreInstance;
            var mongoDatabase = mongoDataStoreInstance.DatabaseInstance;
            Console.WriteLine(mongoDatabase.Client.Settings.Server);
        }

    }

}
