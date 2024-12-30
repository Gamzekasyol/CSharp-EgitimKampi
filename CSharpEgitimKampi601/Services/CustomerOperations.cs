using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void Addcustomer(Customer customer)
        {
            // Veri tabanına bağlantı isteğinde bulundum.
            var connection = new MongoDbconnection();
            // Tabloma bağlandım.
            var conCustomer = connection.GetCustomersCollection();

            // Ekleme işlemlerini yapıyorum
            var document = new BsonDocument
            {
                { "CustomerName", customer.CustomerName },
                {"CustomerSurname", customer.CustomerSurname},
                {"CustomerCity", customer.CustomerCity},
                {"CustomerBalance", customer.CustomerBalance},
                { "CustomerShoppingCount", customer.CustomerShoppingCount }
            };
            conCustomer.InsertOne(document);
        }
        public List<Customer> GetAllCostomer()
        {
            var connection = new MongoDbconnection();
            var conCustomer = connection.GetCustomersCollection();
            var customers = conCustomer.Find(new BsonDocument()).ToList();
            List<Customer> customerlist = new List<Customer>();
            foreach (var c in customers)
            {
                customerlist.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),
                    CustomerName = c["CustomerName"].ToString(),
                    CustomerSurname = c["CustomerSurname"].ToString(),
                    CustomerCity = c["CustomerCity"].ToString(),
                    CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
                    CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString())
                });
            }
            return customerlist;

        }
        public void DeleteCustomer(string id)
        {
            var connection = new MongoDbconnection();
            var cusConnection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)); // silmek istediğim değeri buldum.
            cusConnection.DeleteOne(filter);

        }
        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbconnection();
            var customerConnection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updateValue = Builders<BsonDocument>.Update.Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            customerConnection.UpdateOne(filter, updateValue);

        }
        public Customer GetCustomerById(string id)
        {
            var connection = new MongoDbconnection();   
            var customerCon = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = customerCon.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerCity = result["CustomerCity"].ToString(),
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomerId = id,
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
            };
        }
    }
}
