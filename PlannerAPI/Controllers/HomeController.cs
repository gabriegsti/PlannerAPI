using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlannerAPI.Models;
using System;
using System.Diagnostics;

namespace PlannerAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Eventos()
        {
            Evento evento = new Evento
            {
                Titulo = "Evento da home controller",
                Id_Usuario = 1,
                Data_Hora = DateTime.Parse("2022 - 05 - 31T18:30:15")
            };

            return View(evento);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
   

