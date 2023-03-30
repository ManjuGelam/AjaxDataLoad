using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDataLoad.Models;


namespace AjaxDataLoad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
              

                List<Product> ProductList = db.Products.ToList<Product>();
                return Json(new { data = ProductList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}