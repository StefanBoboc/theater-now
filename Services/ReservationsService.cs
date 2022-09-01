using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.Repositories;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public class ReservationsService : IReservationsService
    {
        private readonly IReservationsRepository _reservationsRepository;
        public ReservationsService(IReservationsRepository reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservationsRepository.GetAllReservations().ToList();
        }

        public Reservation GetReservationById(int reservationId) => _reservationsRepository.GetAllReservations().FirstOrDefault(x => x.Id == reservationId);

        public void AddReservation(ReservationVM reservation)
        {
            var _reservation = new Reservation()
            {
                BookingDate = reservation.BookingDate,
                ClientId = reservation.ClientId,
                ShowId = reservation.ShowId
            };

            _reservationsRepository.AddReservation(_reservation);
        }

        public Reservation UpdateReservationById(int reservationId, ReservationVM reservation)
        {
            var _reservation = GetReservationById(reservationId);
            if (_reservation != null)
            {
                _reservation.BookingDate = reservation.BookingDate;
                _reservation.ClientId = reservation.ClientId;
                _reservation.ShowId = reservation.ShowId;

                _reservationsRepository.UpdateReservationById(_reservation);
            }

            return _reservation;
        }
        public Reservation DeleteReservationById(int reservationId)
        {
            var _reservation = GetReservationById(reservationId);
            if (_reservation != null)
            {
                _reservationsRepository.DeleteReservationById(_reservation);
            }
            return _reservation;
        }
    }
}
