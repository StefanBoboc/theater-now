using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Services;
using TheaterNow.ViewModels;

namespace TheaterNow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        public readonly IReservationsService _reservationsService;

        public ReservationController(IReservationsService reservationsService)
        {
            _reservationsService = reservationsService;
        }

        [HttpGet("get-all-reservations")]
        public async Task<IActionResult> GetAllreservations()
        {
            var reservations = _reservationsService.GetAllReservations();

            return Ok(reservations);
        }

        [HttpGet("get-reservation-by-id/{id}")]
        public async Task<IActionResult> GetReservationById([FromRoute] int id)
        {
            var reservation = _reservationsService.GetReservationById(id);
            if (reservation == null)
                return BadRequest("Reservation not found.");
            return Ok(reservation);
        }

        [HttpPost("add-reservation")]
        public IActionResult AddReservation([FromBody] ReservationVM reservation)
        {
            _reservationsService.AddReservation(reservation);
            return Ok();
        }

        [HttpPut("update-reservation-by-id/{id}")]
        public async Task<IActionResult> UpdateReservationById(int id, [FromBody] ReservationVM reservation)
        {
            var updatedReservation = _reservationsService.UpdateReservationById(id, reservation);
            if (updatedReservation == null)
                return BadRequest("Reservation not found.");
            return Ok(updatedReservation);
        }

        [HttpDelete("delete-reservation-by-id/{id}")]
        public async Task<IActionResult> DeleteReservationById([FromRoute] int id)
        {
            var deletedReservation = _reservationsService.DeleteReservationById(id);
            if (deletedReservation == null)
                return BadRequest("Reservation not found.");
            return Ok();
        }
    }
}
