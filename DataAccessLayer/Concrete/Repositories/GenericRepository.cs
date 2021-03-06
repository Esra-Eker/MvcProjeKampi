using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();

        DbSet<T> _object; //_object T değerine karşılık gelen sınıfı tutuyor. Hangi sınıf olacağını belirlemek için constructor metot tanımlamamız gerekli.
        public GenericRepository() //bunu yapmayınca System.ArgumentNullException: Değer null olamaz. hatası geldi!
        {
            _object = c.Set<T>(); //_object e değer ataması yapıyoruz. Dedik ki _object in değeri Context e bağlı olarak gönderilen T değeri olsun.
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //SingleOrDeafult sadece tek değer döndürmek için kullanılır.
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); //filter dan gelen değere göre listeleme yap
        }

        public void Update(T p)
        {
            var updated = c.Entry(p);
            updated.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
