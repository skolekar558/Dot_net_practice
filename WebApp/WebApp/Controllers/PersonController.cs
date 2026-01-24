using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };

            ViewData["cities"]=new SelectList(cities);
            return View();

            
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            return View("Print");


        }
    }
}
