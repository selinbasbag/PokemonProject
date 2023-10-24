using Microsoft.AspNetCore.Mvc;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Controllers

{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("{id}")]
        public IActionResult getPokemon(int id)
        {
            var pokemon = _pokemonService.getPokemon(id);
            if (pokemon == null)
            {
                return NoContent();
            }
            return Ok(pokemon);
        }

        [HttpGet("getAllPokemons")]
        public IActionResult getAll()
        {
            var pokemons = _pokemonService.getAllPokemons();
            if ( pokemons== null)
            {
                return NoContent();
            }
            return Ok(pokemons);
        }

        [HttpPost("createPokemon")]
        public IActionResult createPokemon(Pokemon pokemon) 
        {
         _pokemonService.createPokemon(pokemon);
            return Ok();
        }

        [HttpPut("updatePokemon")]
        public IActionResult updatePokemon(Pokemon pokemon)
        {
            _pokemonService.updatePokemon(pokemon);
            return Ok();
        }

        //it should check
        [HttpDelete("DeletePokemon")]
        public IActionResult deletePokemon(int id)
        {
            if (_pokemonService.getPokemon(id)==null )
            {
                return BadRequest();
            }
            _pokemonService.deletePokemon(id);
            return Ok();
        }





    }
}
