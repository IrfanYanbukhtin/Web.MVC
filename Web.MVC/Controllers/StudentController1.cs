using Microsoft.AspNetCore.Mvc;
using Web.MVC.Models;

namespace Web.MVC.Controllers
{
    public class StudentController1 : Controller
    {
        private List<Student> _students = new List<Student>
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


        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
