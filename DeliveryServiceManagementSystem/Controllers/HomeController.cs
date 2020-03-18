using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeliveryServiceManagementSystem.Models;

namespace DeliveryServiceManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DeliverRoute()
        {
            var context = new AppDBContext();
            var route = context.routes;
            return View(route.ToList());
        }
        public ActionResult Login()
        {
            var context = new AppDBContext();
            var driver = context.drivers;

            return View(driver.ToList());
        }
        public ActionResult addDriver()
        {
            return View();
        }
        public ActionResult addRoute()
        {
            return View();
        }
        public ActionResult deliver(int id,int driverId)
        {
            var context = new AppDBContext();
            var result = context.drivers.Find(driverId);
            if (result != null)
            {
                result.scheduled = false;
                context.SaveChanges();
            }
            var results = context.routes.Find(id);
            if (results != null)
            {
                results.deliverd = true;
                context.SaveChanges();
            }
            return View("Index");
        }
        public ActionResult delDriver(int id,string name, string surname)
        {
            var context = new AppDBContext();
            var driver = new Driver()
            { 
                Id=id,
                name = name,
                surname = surname
                
            };
            return View(driver);
        }
        public ActionResult delDrivers(int Id, string name, string surname)
        {
            var context = new AppDBContext();
            var driver = new Driver { Id = Id };
            context.drivers.Attach(driver);
            context.drivers.Remove(driver);
            context.SaveChanges();
            ViewBag.Message = "Driver Removed";
            return View("delDriver");
        }
        public ActionResult addDrivers(string name,string surname,bool? scheduled)
        {
            var context = new AppDBContext();
            var driver = new Driver()
            {
                name = name,
                surname=surname,
                scheduled=false
            };
            context.drivers.Add(driver);
            context.SaveChanges();
            ViewBag.Message = "Driver Created";
            return View("addDriver");
        }
        public ActionResult addRoutes(string name, int distance, int driverId)
        {
            var context = new AppDBContext();

            var result = context.drivers.Find(driverId);
            if (result != null)
            {
                result.scheduled = true;
                context.SaveChanges();
            }
            else
            {
                ViewBag.Message = "Driver does not exist";
                return View("addRoute");
            }
            var route = new Route()
            {
                name = name,
                distance = distance,
                driverId = driverId,
                deliverd = false
            };
            context.routes.Add(route);
            context.SaveChanges();
               
            
            ViewBag.Message = "Route Created";
            return View("addRoute");
        }
    }
}