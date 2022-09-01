﻿using Microsoft.AspNetCore.Http;
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
    public class ShowController : ControllerBase
    {
        public readonly IShowsService _showsService;

        public ShowController(IShowsService showsService)
        {
            _showsService = showsService;
        }

        [HttpGet("get-all-shows")]
        public async Task<IActionResult> GetAllShows()
        {
            var shows = _showsService.GetAllShows();

            return Ok(shows);
        }

        [HttpGet("get-show-by-id/{id}")]
        public async Task<IActionResult> GetShowById([FromRoute] int id)
        {
            var show = _showsService.GetShowById(id);
            if (show == null)
                return BadRequest("Show not found.");
            return Ok(show);
        }

        [HttpPost("add-show")]
        public IActionResult AddShow([FromBody] ShowVM show)
        {
            _showsService.AddShow(show);
            return Ok();
        }

        [HttpPut("update-show-by-id/{id}")]
        public async Task<IActionResult> UpdateShowById(int id, [FromBody] ShowVM show)
        {
            var updatedShow = _showsService.UpdateShowById(id, show);
            if (updatedShow == null)
                return BadRequest("Show not found.");
            return Ok(updatedShow);
        }

        [HttpDelete("delete-show-by-id/{id}")]
        public async Task<IActionResult> DeleteShowById([FromRoute] int id)
        {
            var deletedShow = _showsService.DeleteShowById(id);
            if (deletedShow == null)
                return BadRequest("Show not found.");
            return Ok();
        }
    }
}