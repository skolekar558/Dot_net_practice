using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return View();
        }
       

    }
}
