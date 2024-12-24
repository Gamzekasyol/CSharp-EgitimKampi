using CSahrpEgitimKampi301_EntityLayer.Concrete;
using CSharpEgitimKampi_DataAccessLayer.Abstract;
using CSharpEgitimKampi301_BusinnessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_BusinnessLayer.Concrete
{
    public class ProductManager : IProductServices
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

     

        public List<Object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
           _productDal.Update(entity);
        }
    }
}
