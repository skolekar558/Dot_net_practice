using ETicket.Data;
using ETicket.Data.Services;
using ETicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _cinemaService;
        public CinemasController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        // GET: Cinema
        public async Task<IActionResult> Index()
        {
            var cinemas = await _cinemaService.GetAllCinemasAsync();
            return View(cinemas);
        }

        // GET: Cinema/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var cinema = await _cinemaService.GetCinemaByIdAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }
        // GET: Cinema/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Cinema/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                await _cinemaService.CreateCinemaAsync(cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }
        // GET: Cinema/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var cinema = await _cinemaService.GetCinemaByIdAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }
            return View(cinema);
        }
        // POST: Producer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.UpdateCinemaAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get: Cinema/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var CinemaDetails = await _cinemaService.GetCinemaByIdAsync(id);
            if (CinemaDetails == null) return View("NotFound");
            return View(CinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CinemaDetails = await _cinemaService.GetCinemaByIdAsync(id);
            if (CinemaDetails == null) return View("NotFound");

            await _cinemaService.DeleteCinemaAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
