using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T entity);
        void Update(T entitiy);
        void Delete(int id);
        List<T> GetAll(); // tüm verileri listeleme
        T GetById(int id);
    }
}
