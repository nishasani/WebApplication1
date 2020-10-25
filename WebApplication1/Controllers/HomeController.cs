using ModelWebApplication.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            ClientLogic objclientlgc = new ClientLogic();
            ViewBag.ClientList = objclientlgc.get_StudentDetails().ToList();
            //ViewBag.ClientList = string.Join(", ", objclientlgc.get_StudentDetails());
            //ViewBag.ClientList = "Hai, Welcome ...";
            return View();
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