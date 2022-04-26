﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel

        HeadingManager hm = new HeadingManager(new EfHeadingDal());

        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading(int id)
        {
            id = 1;
            var values = hm.GetListByWriter(id);
            return View(values);
        }
    }
}