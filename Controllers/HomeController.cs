﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fyp_hunger_nd_spice_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Indexcustomer()
        {
            return View();
        } public ActionResult Indexadmin()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}