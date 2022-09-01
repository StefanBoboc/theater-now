using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public class ReservationsRepository : IReservationsRepository
    {
        private readonly AppDbContext _context;

        public ReservationsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Reservation> GetAllReservations()
        {
            var reservations = _context.Reservations;

            return reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void UpdateReservationById(Reservation reservation)
        {
            _context.Reservations.Update(reservation);

            _context.SaveChanges();
        }

        public void DeleteReservationById(Reservation reservation)
        {
            _context.Reservations.Remove(reservation);

            _context.SaveChanges();
        }
    }
}
