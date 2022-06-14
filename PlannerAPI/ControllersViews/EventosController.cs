using Microsoft.AspNetCore.Mvc;

namespace PlannerAPI.ControllersViews
{
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
