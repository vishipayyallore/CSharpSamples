using CSharp.Samples.Utilities;
using MongoDB.Driver;

namespace CSharp.Samples.MongoStore
{

    public class MongoDataStore
    {
        #region Private Variables.
        private static readonly IMongoDatabase DataStoreDatabase;
        #endregion

        private MongoDataStore() { }

        static MongoDataStore()
        {
            var mongoDbConnectionString = AppSettingsHelper.GetAppSettingsValue("MongoDbConnectionString");
            var dataStoreClient = new MongoClient(mongoDbConnectionString);

            //Data Base
            var mongoDbDatabaseName = AppSettingsHelper.GetAppSettingsValue("MongoDbDatabaseName");
            DataStoreDatabase = dataStoreClient.GetDatabase(mongoDbDatabaseName);
        }

        #region Properties
        public static MongoDataStore DataStoreInstance { get; } = new MongoDataStore();

        public IMongoDatabase DatabaseInstance => DataStoreDatabase;
        #endregion
    }

}
