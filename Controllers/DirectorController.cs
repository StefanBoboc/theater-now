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
    public class DirectorController : ControllerBase
    {
        public readonly IDirectorsService _directorsService;

        public DirectorController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        [HttpGet("get-all-directors")]
        public async Task<IActionResult> GetAllDirectors()
        {
            var directors = _directorsService.GetAllDirectors();

            return Ok(directors);
        }

        [HttpGet("get-director-by-id/{id}")]
        public async Task<IActionResult> GetDirectorById([FromRoute] int id)
        {
            var director = _directorsService.GetDirectorById(id);
            if (director == null)
                return BadRequest("Director not found.");
            return Ok(director);
        }

        [HttpPost("add-director")]
        public IActionResult AddDirector([FromBody] DirectorVM director)
        {
            _directorsService.AddDirector(director);
            return Ok();
        }

        [HttpPut("update-director-by-id/{id}")]
        public async Task<IActionResult> UpdateDirectorById(int id, [FromBody] DirectorVM Director)
        {
            var updatedDirector = _directorsService.UpdateDirectorById(id, Director);
            if (updatedDirector == null)
                return BadRequest("Director not found.");
            return Ok(updatedDirector);
        }

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
