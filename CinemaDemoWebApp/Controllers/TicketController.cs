using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaDemoModels.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaDemoWebApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository _TicketRepository;

        public TicketController(ITicketRepository ticketRepository)
        {
            this._TicketRepository = ticketRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _TicketRepository.GetTicketsAsync());
        }

        public async Task<IActionResult> Delete(Guid id)
        {

            var movie = await _TicketRepository.GetTicketAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movie = await _TicketRepository.GetTicketAsync(id);
            await _TicketRepository.DeleteTicketAsync(movie);

            return RedirectToAction(nameof(Index));
        }
    }
}