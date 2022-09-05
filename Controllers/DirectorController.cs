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
    public class DirectorController : ControllerBase
    {
        public readonly IDirectorsService _directorsService;

        public DirectorController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        //
        //Return all the directors
        [HttpGet("get-all-directors")]
        public async Task<IActionResult> GetAllDirectors()
        {
            var directors = _directorsService.GetAllDirectors();

            return Ok(directors);
        }

        //
        //Return director by id
        [HttpGet("get-director-by-id/{id}")]
        public async Task<IActionResult> GetDirectorById([FromRoute] int id)
        {
            var director = _directorsService.GetDirectorById(id);
            if (director == null)
                return BadRequest("Director not found.");
            return Ok(director);
        }

        //
        //Add a new director
        [HttpPost("add-director")]
        public IActionResult AddDirector([FromBody] DirectorVM director)
        {
            _directorsService.AddDirector(director);
            return Ok();
        }

        //
        //Update a director
        [HttpPut("update-director-by-id/{id}")]
        public async Task<IActionResult> UpdateDirectorById(int id, [FromBody] DirectorVM Director)
        {
            var updatedDirector = _directorsService.UpdateDirectorById(id, Director);
            if (updatedDirector == null)
                return BadRequest("Director not found.");
            return Ok(updatedDirector);
        }

        //
        //Delete a director
        [HttpDelete("delete-director-by-id/{id}")]
        public async Task<IActionResult> DeleteDirectorById([FromRoute] int id)
        {
            var deletedDirector = _directorsService.DeleteDirectorById(id);
            if (deletedDirector == null)
                return BadRequest("Director not found.");
            return Ok();
        }
    }
}
