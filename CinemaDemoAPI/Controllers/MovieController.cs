using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaDemoModels.Models;
using CinemaDemoModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        //fields 
        private readonly IMovieRepository _movieRepository;


        //consructor
        public MovieController(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        //methods
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {

            return Ok(await _movieRepository.GetMoviesAsync());
        }
    }
}