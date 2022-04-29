using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByWriter();
        List<Content> GetListByHeadingID(int id); //id ye göre tüm listeyi döndürür
        void ContentAdd(Content content);
        Content GetByID(int id); //id ye göre tek değer döndürür
        void HeadingDelete(Content content);
        void HeadingUpdate(Content content);
    }
}
