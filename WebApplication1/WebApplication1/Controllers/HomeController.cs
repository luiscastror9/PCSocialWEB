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
            DatabaseEntities s = new DatabaseEntities();
            string test = "";
            test = s.marcas.FirstOrDefault().descripcion.ToString();
            WebApplication1.Models.Tonto t = new Models.Tonto();
            t.TONTO = test;
            t.numero_tontos = 13;
            //ViewBag.nose = test;
            return View(t);
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


        public int PruebaNumero(int numeroEsperado)
        {
            var test = numeroEsperado / 2;

            //int numeroprocesado = procesadornumero(test);


            return procesadornumero(test);

        }


        private int procesadornumero(int otroNumero)

        {
            int result = otroNumero * 3;

            return result;
        }



    }
}