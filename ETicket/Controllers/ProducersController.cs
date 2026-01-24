using ETicket.Data;
using ETicket.Data.Services;
using ETicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _producerService;
        public ProducersController(IProducerService producerService)
        {
            _producerService = producerService;
        }
        public async Task<IActionResult> Index()
        {
            var producers = await _producerService.GetAllProducersAsync();
            return View(producers);
        }
        // GET: Producer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var producer = await _producerService.GetProducerByIdAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }
        // GET: Producer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                return View(producer);
            }
           
            await _producerService.CreateProducerAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        // GET: Producer/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var producer = await _producerService.GetProducerByIdAsync(id);
            if (producer == null)
            {
                return NotFound();
            }
            return View(producer);
        }
        // POST: Producer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            if (ModelState.IsValid)
            {
                return View(producer);
            }
            await _producerService.UpdateProducerAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //Get: Producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _producerService.GetProducerByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _producerService.GetProducerByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            await _producerService.DeleteProducerAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
