using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kekka(int hensu1,int hensu2)
        {
            int hensu3;
            hensu3 = hensu1 + hensu2;
            ViewBag.Kekka = hensu3;
            return View();
        }

    }
}