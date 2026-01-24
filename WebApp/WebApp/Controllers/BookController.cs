using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            return View();
        }
    }
}
