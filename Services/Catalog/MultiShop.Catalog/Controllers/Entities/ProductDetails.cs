using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Controllers.Entities
{
    public class ProductDetails
    {


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailsID { get; set; }
        public string ProductDescription{ get; set; }
        public string ProductInfo { get; set; }

        public string ProductID { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }




    }
}
