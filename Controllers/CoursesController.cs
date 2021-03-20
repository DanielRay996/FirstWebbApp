using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
                return View();
        }

        public IActionResult Detail(string id){
                return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}