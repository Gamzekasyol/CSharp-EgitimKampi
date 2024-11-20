using CSahrpEgitimKampi301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.Context
{
    public class KampContext: DbContext
    {
        // Category: C# tarafındaki sınıfın ismi                  
        // Categories: Veri tabnındaki  tablonun ismi 
        public DbSet<Category> Categories{ get; set; } // DbSet: Bunun bir tablo olduğunu belirtir.
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
