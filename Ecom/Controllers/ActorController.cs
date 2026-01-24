using Ecom.Data.Services;
using Ecom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        //Get:Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
