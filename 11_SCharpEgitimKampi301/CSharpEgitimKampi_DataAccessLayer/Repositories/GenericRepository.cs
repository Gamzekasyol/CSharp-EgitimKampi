using CSharpEgitimKampi_DataAccessLayer.Abstract;
using CSharpEgitimKampi_DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();   
        private readonly DbSet<T> _object;

        // GenericRepositroy çağırıldığı zaman _object'e bir atama yapsın.
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity= context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            // EntityState= Ekleme, Silme, güncelleme değişikliklerine izin veren bir kod bloğu.
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
            // EntityState kullanmadık çünkü yapılacak bir değişiklik yok.
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entitiy)
        {
            var updatedEntity = context.Entry(entitiy);
            updatedEntity.State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}
