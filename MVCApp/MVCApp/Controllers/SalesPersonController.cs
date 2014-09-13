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
        public ActionResult Fetch()
        {
            return View();
        } 
        //ViewSalesPerson
        public ActionResult ViewSalesPerson(int Id)
        {
            
            SalesPerson spObj = SalesPersonOperation.FetchSalesPerson(Id);

            return View(spObj);
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult DeleteSalesPerson(int Id)
        { 
             string result = SalesPersonOperation.DeleteSalesPerson(Id);
             return RedirectToAction("Index", "Home"); //Action, Controller
        }
	}
}


