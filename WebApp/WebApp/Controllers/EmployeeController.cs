using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };

            List<string> dept = new List<string>()
            {
                "HR", "MANAGEMENT","TESTING","MARKETING"
            };

            ViewData["cities"] = new SelectList(cities);
            ViewData["dept"] = new SelectList(dept);
            return View();
           
        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Departments = form["dept"];
            ViewBag.Qualification = form["Qual"];

            return View("PrintEmpDetails");
        }
    }
}
