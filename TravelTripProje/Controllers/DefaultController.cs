﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partil1()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partil3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partil4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partil5()
        {
            //by.Deger3 = c.Blogs.OrderByDescending(b => b.ID).Take(3).ToList();
            var deger = c.Blogs.OrderByDescending(b => b.ID).Take(3).ToList();
            return PartialView(deger);
        }

    }
}