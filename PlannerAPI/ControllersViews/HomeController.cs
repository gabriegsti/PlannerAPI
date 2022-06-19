using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PlannerAPI.Models;
using System;
using System.Diagnostics;

namespace PlannerAPI.ControllersViews
{
    public class HomeController : Controller
    {
        public IConfiguration configuration;
        public HomeController(IConfiguration configuration)
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Materia()
        {
<<<<<<< HEAD:PlannerAPI/Controllers/HomeController.cs
=======

>>>>>>> ab293ff68a32a6f2e8f7c696b928b4fa5727a406:PlannerAPI/ControllersViews/HomeController.cs
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
   

