using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CinemaDemoModels.Models;
using CinemaDemoModels.Repositories;
using CinemaDemoWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaDemoWebApp.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaController(ICinemaRepository cinemaRepository)
        {
            this._cinemaRepository = cinemaRepository;
        }
        // GET: Cinema
        public async Task<ActionResult> Index()
        {
            IEnumerable<Cinema> cinemas = await _cinemaRepository.GetCinemasAsync();
            return View(cinemas);
        }

        // GET: Cinema/Details/5
        public async Task<ActionResult> Movies(Guid id)
        {
            Cinema cinema = await _cinemaRepository.GetCinemaWithMoviesAsync(id);

            if (cinema == null)
                return NotFound();
            return View(cinema);
        }

        public async Task<ActionResult> ClaimSeat(Guid roomId, Guid MovieRoomId, DateTime Playtime, Guid MovieId)
        {
            TicketsViewModel tickets = new TicketsViewModel();

            Room room = await _cinemaRepository.GetRoomsAsync(roomId);

            if (room == null)
                return NotFound();
            tickets.MovieId = MovieId;
            tickets.MovieRoomId = MovieRoomId;
            tickets.room = room;
            tickets.Playtime = Playtime;
            return View(tickets);
        }

        public async Task<IActionResult> SeatDetails(Guid SeatId, Guid RoomId, Guid MovieRoomId, DateTime Playtime, Guid MovieId, string user)
        {
            try
            {
                Ticket t = new Ticket();
                Guid TicketId = new Guid();

                var User = await _cinemaRepository.GetUserByName(user);

                t.Id = TicketId;
                t.SeatId = SeatId;
                t.MovieRoomId = MovieRoomId;
                t.AspNetUserId = User.Id;
                t.MovieRoomMovieId = MovieId;
                t.MovieRoomRoomId = RoomId;
                t.MovieRoomPlayTime = Playtime;

                await _cinemaRepository.PostTicketAsync(t);
                Seat seat = await _cinemaRepository.GetSeatById(SeatId);

                return View(seat);
            }
            catch (Exception)
            {

                return Redirect("/Cinema/ErrorPage");
            }
        }

        public async Task<IActionResult> ErrorPage()
        {
            return View();
        }
    }
}