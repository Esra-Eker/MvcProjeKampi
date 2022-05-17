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
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id); //id ye göre tüm listeyi döndürür
        void ContentAdd(Content content);
        Content GetByID(int id); //id ye göre tek değer döndürür
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
