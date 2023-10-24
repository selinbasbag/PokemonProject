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
        private readonly ITypeService _typeService;
        public TypeController(ITypeService TypeService)
        {
            _typeService = TypeService;
        }

        [HttpGet("{id}")]
        public IActionResult getType(int id)
        {
            var type = _typeService.getType(id);
            if (type == null)
            {
                return NotFound();
            }
            return Ok(type);
        }

        [HttpGet("getAll")]
        public IActionResult getAllTypes()
        {
            var types= _typeService.getAllTypes();
            if (types == null)
            {
                return NoContent();
            }
            return Ok(types);
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
