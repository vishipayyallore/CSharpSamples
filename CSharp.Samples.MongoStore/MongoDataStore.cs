using CSharp.Samples.Utilities;
using MongoDB.Driver;

namespace CSharp.Samples.MongoStore
{

    public class MongoDataStore
    {
        #region Private Variables.
        private static readonly MongoClient DataStoreClient;
        private static readonly IMongoDatabase DataStoreDatabase;
        #endregion

        private MongoDataStore() { }

        static MongoDataStore()
        {
            var mongoDbConnectionString = AppSettingsHelper.GetAppSettingsValue("MongoDbConnectionString");
            DataStoreClient = new MongoClient(mongoDbConnectionString);

            //Data Base
            var mongoDbDatabaseName = AppSettingsHelper.GetAppSettingsValue("MongoDbDatabaseName");
            DataStoreDatabase = DataStoreClient.GetDatabase(mongoDbDatabaseName);
        }

        #region Properties
        public static MongoDataStore DataStoreInstance { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;

        public IMongoDatabase DatabaseInstance => DataStoreDatabase;
        #endregion
    }

}
