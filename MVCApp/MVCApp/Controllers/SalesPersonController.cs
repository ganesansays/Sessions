using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using Session2;



namespace MVCApp.Controllers
{
    public class SalesPersonController : Controller
    {
        //
        // GET: /SalesPerson/
        public ActionResult SalesPerson()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(SalesPerson spObj)
        {
            if (spObj != null)
            {
                SalesPersonOperation.UpdateSalesPerson(spObj);
            }
            //return "Maniraja";
            return RedirectToAction("Index", "Home"); //Action, Controller
        }
	}
}