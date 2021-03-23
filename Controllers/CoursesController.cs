using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Model.Services.Application;
using WebApp1.Model.ViewModels;

namespace WebApp1.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
                var courseService = new CourseService();
                List<CourseViewModel> courses = courseService.GetServices();
                return View(courses);
        }

        public IActionResult Detail(string id){
                return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}