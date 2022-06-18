using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PlannerAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Json;

namespace PlannerAPI.ControllersViews
{
    public class EventosController : Controller
    {
        private HttpClient HttpClient { get; set; }
        private string BaseUrl { get; set; }
        public EventosController(HttpClient httpClient, IConfiguration configuration)
        {
            HttpClient = httpClient;
            BaseUrl = configuration.GetValue<string>("BaseUrl");

        }
        public async Task<IActionResult> Index()
        {
            var response = await HttpClient.GetFromJsonAsync<List<Evento>>(BaseUrl + "Evento");

            if (response != null)
            { 
                ViewBag.eventos = response;
                return View();
            }
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Criar(Evento evento)
        {

            evento.Id_Usuario = 1;

            await HttpClient.PostAsJsonAsync<Evento>(BaseUrl + "Evento", evento);
            return RedirectToAction("Index");
        }
        public IActionResult Editar()
        {
           return View();
        }
        public IActionResult Apagar()
        {
           return View();
        }
    }
}
