using ETicket.Data;
using ETicket.Data.Services;
using ETicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorService;

        public ActorsController(IActorsService actorService)
        {
            _actorService = actorService;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _actorService.GetAllActorsAsync();
            return View(actors);
        }
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _actorService.GetActorByIdAsync(id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorService.CreateActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }


        // GET: Actor/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _actorService.GetActorByIdAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        // POST: Actor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorService.UpdateActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }


        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorService.GetActorByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorService.GetActorByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _actorService.DeleteActorAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
