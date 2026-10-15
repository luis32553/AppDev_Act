using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

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

            student.ID = 02680;
            student.FirstName = "Marhissa";
            student.MiddleName = "Repato";
            student.LastName = "Cuevas";
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
