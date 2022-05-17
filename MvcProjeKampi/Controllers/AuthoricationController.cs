using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthoricationController : Controller
    {
        // GET: Authorication
        AdminManager adminmanager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminmanager.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminmanager.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = adminmanager.GetByID(id); //id değişkeninden gelen parametre değerine göre ilgili satırın kayıtlarını categoryvalue isimli değişkene atadım.
            return View(adminvalue);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdmin(int id)
        {
            var AdminValue = adminmanager.GetByID(id); //id ye göre buldurdum.
            if (AdminValue.AdminStatus == true)
            {
                AdminValue.AdminStatus = false;
                adminmanager.AdminDelete(AdminValue);  //HeadingValue dan gelen değeri sildirdim.
            }
            else
            {
                AdminValue.AdminStatus = true;
                adminmanager.AdminDelete(AdminValue);
            }
            return RedirectToAction("Index");
        }
    }
}