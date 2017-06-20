using FirstAzureMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAzureMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var db = new AdventureContext();
            // Create and save a new Blog 
            //var user = new adventure_users { firstname = "Test", lastname ="FromApp", email ="" };
            //db.adventure_users.Add(user);
            //db.SaveChanges();

            //// Display all Blogs from the database 
            //var query = from b in db.adventure_users
            //            orderby b.firstname
            //            select b;

            //Console.WriteLine("All blogs in the database:");
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.firstname);
            //}

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            //return View();
            var db = new AdventureContext();
            return View(from user in db.adventure_users
                        orderby user.firstname
                        select user);

            //return View(query.ToList());
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