using Microsoft.AspNetCore.Mvc;
using PokemonProject.Interface.Service;
using PokemonProject.Models;
using PokemonProject.Service;

namespace PokemonProject.Controllers
{
    [Route("api/type")]
    [ApiController]
    public class TypeController : Controller
    {
        private readonly TypeService _typeService;
        public TypeController(TypeService TypeService)
        {
            _typeService = TypeService;
        }

        [HttpGet("{id}")]
        public IActionResult getType(int id)
        {
            if (_typeService.getType(id) == null)
            {
                return NotFound();
            }
            _typeService.getType(id);
            return Ok();
        }

        [HttpGet("getAll")]
        public IActionResult getAllTypes()
        {
            if (_typeService.getAllTypes() == null)
            {
                return NoContent();
            }
            return Ok(_typeService.getAllTypes());
        }

        [HttpPost("create")]
        public IActionResult createType(Models.Type type)
        {
            _typeService.createType(type);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult updateType(Models.Type type)
        {
            _typeService.updateType(type);
            return Ok();
        }

        //it should check
        [HttpDelete("delete")]
        public IActionResult deleteType(int id)
        {
            if (_typeService.getType(id) == null)
            {
                return BadRequest();
            }
            _typeService.deleteType(id);
            return Ok();
        }


    }
}
