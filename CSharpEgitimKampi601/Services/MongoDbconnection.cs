using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbconnection
    {
        private IMongoDatabase _databse; // bağlantı edresi oluştruyorum
        public MongoDbconnection()
        {
                var client = new MongoClient("mongodb://localhost:27017");
                _databse = client.GetDatabase("Db601Customer");// Tırnak içi oluşacak veri tabının ismidir.
        }
        
        // IMongoCollection benim tablomu temsil edicek.
        public IMongoCollection<BsonDocument> GetCustomersCollection()
        {
            // Veri tabanımın içersine Customer isimli  collection ekliyoruz.
            return _databse.GetCollection<BsonDocument>("Customers");
        }

    }
}
