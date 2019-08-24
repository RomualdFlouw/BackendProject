using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaDemoModels.Data;
using CinemaDemoModels.Models;
using CinemaDemoModels.Repositories;

namespace CinemaDemoWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View( await _movieRepository.GetMoviesAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
           

            var movie = await _movieRepository.GetMovieAsync(id);
               
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
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
        public async Task<IActionResult> Create([Bind("Id,Name,ImageUrl,Duration")] Movie movie)
        {
            if (ModelState.IsValid)
            {
               await  _movieRepository.SaveMovieAsync(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
           

            var movie = await _movieRepository.GetMovieAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,ImageUrl,Duration")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
              
                    await _movieRepository.UpdateMovieAsync(movie);               
                
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {          

            var movie = await _movieRepository.GetMovieAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movie = await _movieRepository.GetMovieAsync(id);
            await _movieRepository.DeleteMovieAsync(movie);
           
            return RedirectToAction(nameof(Index));
        }

      
    }
}
