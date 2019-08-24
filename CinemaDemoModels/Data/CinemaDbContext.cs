using System;
using System.Collections.Generic;
using System.Text;
using CinemaDemoModels.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaDemoModels.Data
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieRoom> MovieRooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }



        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {
        }

        // fluent api 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MovieRoom>().HasKey(mr => new { mr.MovieId, mr.RoomId, mr.PlayTime });
            builder.Entity<Ticket>().HasAlternateKey(t => new { t.SeatId, t.MovieRoomId, t.AspNetUserId });

            Guid cinemaId = Guid.NewGuid();
           

            builder.Entity<Cinema>().HasData(new Cinema() { Id = cinemaId, Name = "Kinepolis Kortrijk" });

            for (int i = 0; i < 5; i++)
            {
                Guid roomId = Guid.NewGuid();
                builder.Entity<Room>().HasData(new Room() { Id = roomId, CinemaId = cinemaId, Nr = i });

                for (int r = 0; r < 10; r++)
                {
                    for (int s = 0; s < 10; s++)
                    {
                        builder.Entity<Seat>().HasData(new Seat() { Id = Guid.NewGuid(), Nr = s, RoomId = roomId, RowNr = r });
                    }
                }
            }
          

        }
    }
}
