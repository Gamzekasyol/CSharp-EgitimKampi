using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_BusinnessLayer.Abstract
{
    public interface IGenericServices<T> where T : class
    {
        // IGenericDal sınıfındaki metotlarla arışmasın diye başına T ekledik.
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetAll(); // tüm verileri listeleme
        T TGetById(int id);
    }
}
