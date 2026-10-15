using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;
using MVC3.Models;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            StudentProfile student = new StudentProfile();

            student.ID = 04349;
            student.FirstName = "Luis";
            student.MiddleName = "Maliwat";
            student.LastName = "Delos Reyes";
            student.Address = "Quezon City";

            return View(student);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
