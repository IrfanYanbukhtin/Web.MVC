using Microsoft.AspNetCore.Mvc;
using Web.MVC.Models;

namespace Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Firstname = "Irfan",
                    Lastname = "Yanbuxtin",
                    Age = 24,
                },

                new Student
                {
                    Id= 2,
                    Firstname = "Sahlar",
                    Lastname = "Haciyev",
                    Age = 26,
                },

                new Student
                {
                    Id= 3,
                    Firstname = "Elvin",
                    Lastname = "Cebrailov",
                    Age = 24,
                },
            };

            return View(students);
        }
    }
}
