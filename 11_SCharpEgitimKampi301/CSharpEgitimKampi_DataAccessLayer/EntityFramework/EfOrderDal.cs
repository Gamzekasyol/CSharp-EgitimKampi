using CSahrpEgitimKampi301_EntityLayer.Concrete;
using CSharpEgitimKampi_DataAccessLayer.Abstract;
using CSharpEgitimKampi_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.EntityFramework
{
    public class EfOrderDal: GenericRepository<Order>, IOrderDal
    {
    }
}
