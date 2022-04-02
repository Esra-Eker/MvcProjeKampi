using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(); //BusinessLayer katmanındaki CategoryManager sınıfını çağırmam gerekliydi.
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBL(); //categoryvalues isimli değişkenimin içine category tablomda yer alan değerler gelecek.
            return View(categoryvalues);
        }

    }
}