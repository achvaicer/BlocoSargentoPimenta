using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlocoSargentoPimenta.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuemSomos()
        {
            return View();
        }

        public ActionResult NovidadesProgramacao()
        {
            return View();
        }

        public ActionResult Galeria()
        {
            return View();
        }

        public ActionResult HinoLetras()
        {
            return View();
        }

        public ActionResult Curiosidades()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }
    }
}
