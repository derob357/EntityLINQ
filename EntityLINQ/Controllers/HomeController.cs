using EntityLINQ.Data;
using EntityLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityLINQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            MyVM bucket = new MyVM();
            bucket.PracticeQuery1 = db.Customers.ToList();
            bucket.PracticeQuery2 = db.Orders.ToList();
            bucket.PracticeQuery3 = db.Orders.Where(p => p.Description.Contains("A")).ToList();
            bucket.PracticeQuery4 = db.Orders.Where(o => o.OrderDate.Month > o.OrderDate.Month-6)
                .Where(y => y.OrderDate.Year == 2014)
                .ToList();
            //bucket.PracticeQuery5 = db.Customers.ToList().Find();
            //bucket.PracticeQuery5 = db.Customers.Where(x => x.Id.ToList().Find(5));
           // bucket.PracticeQuery6 = db.Customers.ToList().Skip(); 
          //  bucket.PracticeQuery7 = db.Customers.ToList().OrderByDescending(Customer);
            return View(bucket);
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