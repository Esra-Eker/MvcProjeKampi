using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext //DbContext sınıfına ait özellikler Context sınıfına eklensin istiyorum.
    {
        //Context sınıfı, buraya yazılmış olan DBSet türündeki propertyleri SQLe birer tablo olarak yansıtacak. 
        public DbSet<About> Abouts { get; set; } //Başka bir katmanda olan About u kullanamam ilk önce. Eğer ben başka bir katmanda olan metotları sınıflar propertyleri kullanmak istiyorsam o katmanı buraya reference olarak eklemeliyim. Eklediğimde artık About u kullanabildim.
        //About benim projemin içerisinde yer alan sınıfın ismi, Abouts ise SQLde veritabanına yansıcak olan tablonun ismi. Birbirlerine karışmasın diye böyle ayrım yaptım.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
