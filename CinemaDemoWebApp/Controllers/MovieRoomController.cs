using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaDemoModels.Models;
using CinemaDemoModels.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaDemoWebApp.Controllers
{
    public class MovieRoomController : Controller
    {
        private readonly IMovieRoomRepository _movieRoomRepository;

        public MovieRoomController(IMovieRoomRepository movieRoomRepository)
        {
            this._movieRoomRepository = movieRoomRepository;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _movieRoomRepository.GetMovieRoomsAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(Guid id)
        {


            var movieRoom = await _movieRoomRepository.GetMovieRoomAsync(id);

            if (movieRoom == null)
            {
                return NotFound();
            }

            return View(movieRoom);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlayTime,MovieId,RoomId")] MovieRoom movieRoom)
        {
            if (ModelState.IsValid)
            {
                await _movieRoomRepository.SaveMovieRoomAsync(movieRoom);
                return RedirectToAction(nameof(Index));
            }
            return View(movieRoom);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {


            var movieRoom = await _movieRoomRepository.GetMovieRoomAsync(id);
            if (movieRoom == null)
            {
                return NotFound();
            }
            return View(movieRoom);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PlayTime,MovieId,RoomId")] MovieRoom movieRoom)
        {
            if (id != movieRoom.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _movieRoomRepository.UpdateMovieRoomAsync(movieRoom);

                return RedirectToAction(nameof(Index));
            }
            return View(movieRoom);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {

            var movieRoom = await _movieRoomRepository.GetMovieRoomAsync(id);

            if (movieRoom == null)
            {
                return NotFound();
            }

            return View(movieRoom);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movieRoom = await _movieRoomRepository.GetMovieRoomAsync(id);
            await _movieRoomRepository.DeleteMovieRoomAsync(movieRoom);

            return RedirectToAction(nameof(Index));
        }
    }
}