using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public interface IReservationsService
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservationById(int id);
        void AddReservation(ReservationVM reservation);
        public Reservation UpdateReservationById(int reservationId, ReservationVM reservation);
        public Reservation DeleteReservationById(int reservationId);
    }
}
