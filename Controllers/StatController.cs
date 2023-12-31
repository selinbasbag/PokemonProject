﻿using Microsoft.AspNetCore.Mvc;
using PokemonProject.Interface.Service;
using PokemonProject.Models;
using PokemonProject.Service;

namespace PokemonProject.Controllers
{
    [Route("api/stat")]
    [ApiController]
    public class StatController : Controller
    {
        public readonly IStatService _statService;
        public StatController(IStatService statService)
        {
            _statService = statService;
        }

        [HttpGet("{id}")]
        public IActionResult getStat(int id)
        {
            var stat = _statService.getStat(id);
            if (stat == null)
            {
                return NoContent();
            }
            return Ok(stat);
        }

        [HttpGet("getAll")]
        public IActionResult getAllStats()
        {
            var stats = _statService.getAllStats();
            if (stats == null)
            {
                return NoContent();
            }
            return Ok(stats);
        }

        [HttpPost("create")]
        public IActionResult createStat(Stat stat)
        {
            _statService.createStat(stat);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult updateStat(Stat stat)
        {
            _statService.updateStat(stat);
            return Ok();
        }

        //should check
        [HttpDelete("delete")]
        public IActionResult deleteStat(int id)
        {
            if (_statService.getStat(id) == null)
            {
                return BadRequest();
            }
            _statService.deleteStat(id);
            return Ok();
        }

    }
}
