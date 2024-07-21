using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SuperShop.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["Nome"] = "João";
            //ViewData["Email"] = "joao.cinel.pt";
            //ViewData["Curso"] = "ASP.NET.MVC";
            //ViewData["Data Inicio"] = new DateTime(2021, 07, 01);

            //ViewBag.Nome = "Maria Joana";
            //ViewBag.Email = "maria.joana@cinel.pt";
            //ViewBag.Curso = "ASP.NET.MVC";
            //ViewBag.DataInicio = new DateTime(2021, 07, 01);

            //ViewBag.Paises = new List<string>()
            //{
            //    "Brasil",
            //    "Peru",
            //    "China",
            //    "Canadá",
            //    "Portugal"
            //};

            ViewData["Paises"] = new List<string>()
            {
                "Brasil",
                "Peru",
                "China",
                "Canadá",
                "Portugal"
            };

            return View();
        }

        public string Inicio()
        {
            return "A minha primeira aplicação ASP.NET MVC!!";
        }

        public string Saudacao(int id)
        {
            return $"Codigo recebido da url = {id.ToString()}";
        }
    }
}
