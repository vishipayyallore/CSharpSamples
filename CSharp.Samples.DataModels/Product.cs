using CSharp.Samples.IDataModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CSharp.Samples.DataModels
{

    public class Product : IEntity
    {
        /// <summary>
        /// Default constructor needed for MongoDb
        /// </summary>
        public Product() { }

        public Product(string name, decimal price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }

        #region Properties
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Manufacturer { get; set; }
        #endregion
    }

}
