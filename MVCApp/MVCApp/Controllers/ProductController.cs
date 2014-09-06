using BusinessEntities;
using Session2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Save(Product prod)
        {
            if (prod != null)
            {
                string messagesave = ProductOperation.CreateProduct(prod);
            }
            return RedirectToAction("Index", "Product");
        }
	}
}