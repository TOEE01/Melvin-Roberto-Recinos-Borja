using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MelvinRobertoRecinosBorja.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index(String mon)
        {
            ViewBag.monto = mon;
            return View();
        }
        [HttpPost]
        public ActionResult Mostrar(Int32 monto)
        {


            return View();
        }
    }
}