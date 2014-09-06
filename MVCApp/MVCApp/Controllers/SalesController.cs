using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using Session2;


namespace MVCApp.Controllers
{
    public class SalesController : Controller
    {
        //
        // GET: /Sales/
        public ActionResult Sales()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Sale saObj)
        {
            //return "Maniraja";
            return RedirectToAction("Index", "Home"); //Action, Controller
        }
	}
}