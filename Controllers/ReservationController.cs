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
        public readonly IClientsService _clientsService;

        public ReservationController(IReservationsService reservationsService, IClientsService clientsService)
        {
            _reservationsService = reservationsService;
            _clientsService = clientsService;
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

        [HttpGet("get-shows-number-per-client")]
        public async Task<IActionResult> GetShowsNumberPerClient()
        {
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

            List<string> groupList = new List<string>();

            var innerJoinResult = (from r in _reservationsService.GetAllReservations() 
                                  join c in _clientsService.GetAllClients() 
                                  on r.ClientId equals c.Id 
                                  select new
                                  { 
                                      ClientId = c.Id,
                                      ClientLastName = c.LastName,
                                      ClientFirstName = c.FirstName
                                  }).Distinct();

            foreach (var join in innerJoinResult)
            {
                My_dict1.Add(join.ClientId, string.Format("{0} {1}", join.ClientFirstName, join.ClientLastName));
            }

            var showsNumberPerClient = _reservationsService.GetAllReservations().GroupBy(x => x.ClientId);

            foreach (var group in showsNumberPerClient)
            {

                groupList.Add(string.Format("{0} - {1}", My_dict1[group.Key], group.Count()));
            }

            return Ok(groupList);

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
