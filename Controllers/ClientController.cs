using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public readonly IClientsService _clientsService;

        public ClientController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }
        
        //
        //Return all the clients
        [HttpGet("get-all-clients")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = _clientsService.GetAllClients();

            return Ok(clients);
        }

        //
        //Return client by id
        [HttpGet("get-client-by-id/{id}")]
        public async Task<IActionResult> GetClientById([FromRoute] int id)
        {
            var client = _clientsService.GetClientById(id);
            if (client == null)
                return BadRequest("Client not found.");
            return Ok(client);
        }

        //
        //Return clients including their shows
        [HttpGet("get-clients-with-shows")]
        public async Task<IActionResult> GetClientsWithShows()
        {
            var clientsWithShows = _clientsService.GetClientsWithShows();

            return Ok(clientsWithShows);
        }


        //
        //Add a new client
        [HttpPost("add-client")]
        public IActionResult AddClient([FromBody] ClientVM client)
        {
            _clientsService.AddClient(client);
            return Ok();
        }

        //
        //Update a client
        [HttpPut("update-client-by-id/{id}")]
        public async Task<IActionResult> UpdateClientById(int id, [FromBody] ClientVM client)
        {
            var updatedClient = _clientsService.UpdateClientById(id, client);
            if (updatedClient == null)
                return BadRequest("Client not found.");
            return Ok(updatedClient);
        }

        //
        //Delete a client
        [HttpDelete("delete-client-by-id/{id}")]
        public async Task<IActionResult> DeleteClientById([FromRoute] int id)
        {
            var deletedClient = _clientsService.DeleteClientById(id);
            if (deletedClient == null)
                return BadRequest("Client not found.");
            return Ok();
        }
    }
}
