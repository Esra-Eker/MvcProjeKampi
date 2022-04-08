using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //Bu T değeri typem olucak, bi entity i karşılıcak, yani tabloyu.Category, About vs. 
    {
        //CRUD operasyonlarını birer metot olarak tanımlıcam
        //Type Name();
        List<T> List();
        void Insert(T p); //Ekleme işlemini gerçekleştirebilmek için T sınıfından gelen bir p parametresi tanımladım. Böylece T sınıfında yer alan tüm propertylere ulaşabilicem.
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter); //şartlı listeleme için kullanıcam.
    }
}
