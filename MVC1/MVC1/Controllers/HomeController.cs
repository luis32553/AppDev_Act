using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "Mai";
            student.MiddleName = "Lui";
            student.LastName = "Erni";
            student.Address = "Quezon City";

            ViewBag.KahitAno = "Welcome mga bata!";
            ViewData["KahitAno"] = "Tangina nyo!";
            
            return View();
        }

        public IActionResult Privacy()
        {

            StudentModel[] studs = new StudentModel[2];
            List<StudentModel> students = new list<StudentModel>();
            students.Add(new StudentModel
            {
                ID = 1;
                FirstName = "Mai";
                MiddleName = "Lui";
                LastName = "Erni";
                Address = "Quezon City";
            });
            students.Add(new StudentModel
            {
                ID = 2;
                FirstName = "Lui";
                MiddleName = "Erni";
                LastName = "Mai";
                Address = "Pasig City";
            });
            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
