using Microsoft.AspNetCore.Mvc;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Controllers
{
    [Route("api/trainer")]
    [ApiController]
    public class TrainerController : Controller
    {
        private readonly ITrainerService _trainerService;
        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        [HttpGet("{id}")]
        public IActionResult getTrainer(int id)
        {
            var trainer = _trainerService.getTrainer(id);
            if ( trainer== null)
            {
                return NotFound();
            }
            return Ok(trainer);
        }

        [HttpGet("getAll")]
        public IActionResult getAllTrainers()
        {
            var trainers = _trainerService.getAllTrainers();
            if (trainers == null)
            {
                return NotFound();
            }
            return Ok(trainers);
        }
        [HttpPost("create")]
        public IActionResult createTrainer(Trainer trainer)
        {
            _trainerService.createTrainer(trainer);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult updateTrainer(Trainer trainer)
        {
            _trainerService.updateTrainer(trainer);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult deleteTrainer(int id)
        {
            _trainerService.deleteTrainer(id);
            return Ok();
        }

    }
}
