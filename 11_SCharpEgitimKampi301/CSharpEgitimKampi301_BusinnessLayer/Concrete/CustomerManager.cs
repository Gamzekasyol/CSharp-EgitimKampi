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
    public class CustomerManager : ICustomerServices
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            //if ( yetki varsa )
            //{
            //    listeleme yap
            //}
            //else 
            //{
            //    uyarı ver
            //}
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerName.Length <= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {
                // hata mesajı ver
            }
             
        }

        public void TUpdate(Customer entity)
        {
            if ( entity.CustomerId != 0 && entity.CustomerCity.Length >= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                // hata mesajı ver
            }
        }
    }
}

