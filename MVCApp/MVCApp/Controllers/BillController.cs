using BusinessEntities;
using Session2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class BillController : Controller
    {
        //
        // GET: /Bill/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View("ViewBill");
        }

        public ActionResult Save(Bill billtosave)
        {
            if (billtosave != null)
            {
                string messagesave = BillOperations.CreateBill(billtosave);
            }

            return RedirectToAction("Index", "Bill");
        }

        public ActionResult Fetch()
        {
            return View();
        }

        public ActionResult ViewBill(int id)
        {
            Bill bill = BillOperations.FetchBill(id);

            return View(bill);
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult DeleteBill(int id)
        {
            string messagedel = BillOperations.DeleteBill(id);

            return RedirectToAction("Index", "Bill");

        }
	}
}