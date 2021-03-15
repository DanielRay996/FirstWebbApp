using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
                return Content("Sono index");
        }

        public IActionResult Detail(string id){
            return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}