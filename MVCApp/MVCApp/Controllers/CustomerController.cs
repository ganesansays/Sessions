using BusinessEntities;
using Session2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Customer cust)
        {
            if (cust != null)
            {
                string messageSave = CustomerOperation.UpdateCustomer(cust);
            }

            return RedirectToAction("Index", "Home"); //Action, Controller
        }
	}
}