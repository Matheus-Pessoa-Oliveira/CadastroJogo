using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroJogo.Models;

namespace CadastroJogo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var jogo = new Jogo(); // aqui criamos o projeto
            return View(jogo); // Retornamos para a view dados
        }
        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            if (ModelState.IsValid) // Validamos o estado
            {
                return View("Resultado", jogo);
            }
            return View(jogo);
        }
        public ActionResult Resultado(Jogo jogo)
        {
            return View(jogo);
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