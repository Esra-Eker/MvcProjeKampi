using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        CategoryManager cm = new CategoryManager(new EfCategoryDal()); //BusinessLayer katmanındaki CategoryManager sınıfını çağırmam gerekliydi.
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList(); //categoryvalues isimli değişkenimin içine category tablomda yer alan değerler gelecek.
            return View(categoryvalues);
        }

        [HttpGet] //sayfa yüklendiği zaman çalışacak.
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]  //AddCategory metoduna HttpPost attribute u devreye girdiği zaman çalışacaksın dedim. yani sayfamda bir şey post edildiği zaman çalışacak. HttpGet i de yukarıda yazdım, sebebi: sayfa yüklenir yüklenmez veri kaydetme işlemi yapmamak. 
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if(results.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(); 
        }

    }
}