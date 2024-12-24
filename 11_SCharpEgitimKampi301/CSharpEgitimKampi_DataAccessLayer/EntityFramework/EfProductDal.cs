using CSahrpEgitimKampi301_EntityLayer.Concrete;
using CSharpEgitimKampi_DataAccessLayer.Abstract;
using CSharpEgitimKampi_DataAccessLayer.Context;
using CSharpEgitimKampi_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {

        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            // context içindeki productsa git ve seç(Product sınıfını seçtim ve süslü parantezimi açtım.
            // )

            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName=x.Category.CategoryName
                }).ToList();

            return values.Cast<Object>().ToList();
        }
    }
}
