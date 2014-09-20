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
            return View("ViewProduct");
        }

        public ActionResult Save(Product prod)
        {
            if (prod != null)
            {
                string messagesave = ProductOperation.CreateProduct(prod);
            }
            return RedirectToAction("Index", "Product");
        }

        public ActionResult Fetch()
        {
            return View();
        }

        public ActionResult ViewProduct(int? id)
        {
            if (id != null)
            { 
            Product product = ProductOperation.FetchProduct(id.Value);
            return View(product);
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult DeleteProduct(int? id)
        {
            if (id != null)
            {
                string messagedel = ProductOperation.DeleteProduct(id.Value);
            }
            
            return RedirectToAction("Index", "Product");
        }
	}
}