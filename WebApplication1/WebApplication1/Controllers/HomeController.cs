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

        public ActionResult Administracion()
        {
            ViewBag.Message = "Administracion de permisos";

            return View();
        }

        public ActionResult Registrar_material()
        {
            ViewBag.Message = "Registar material";

            return View();
        }

        public ActionResult Ventas()
        {
            ViewBag.Message = "Ventas";

            return View();
        }

        public ActionResult Ordenes_venta()
        {
            ViewBag.Message = "Ordenes de venta";

            return View();
        }
    }
}