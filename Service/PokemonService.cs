using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonrepository;
        private readonly IMapper _autoMapper;
        public PokemonService(IPokemonRepository pokemonRepository, IMapper autoMapper)
        {
            _pokemonrepository = pokemonRepository;
            _autoMapper = autoMapper;
        }

        public ICollection<PokemonDto> getAllPokemons()
        {
            ICollection<PokemonDto> pokemonDtos = new List<PokemonDto>();
            ICollection<Pokemon> pokemons = _pokemonrepository.getAllPokemons();
            foreach (var item in pokemons)
            {
                pokemonDtos.Add(_autoMapper.Map<PokemonDto>(item));
            }
            return pokemonDtos;
        }

        public PokemonDto getPokemon(int id)
        {
            return _autoMapper.Map<PokemonDto>(_pokemonrepository.getPokemon(id));
        }
        public void createPokemon(Pokemon pokemon)
        {
            _pokemonrepository.createPokemon(pokemon);

        }

        public bool deletePokemon(int id)
        {
            return _pokemonrepository.deletePokemon(id);

        }


        public void updatePokemon(Pokemon pokemon)
        {
            _pokemonrepository.updatePokemon(pokemon);
        }
    }
}
