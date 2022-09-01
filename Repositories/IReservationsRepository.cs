using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public interface IReservationsRepository
    {
        IQueryable<Reservation> GetAllReservations();
        void AddReservation(Reservation reservation);
        void UpdateReservationById(Reservation reservation);
        void DeleteReservationById(Reservation reservation);
    }
}
