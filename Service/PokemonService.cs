using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonrepository;
        public PokemonService(IPokemonRepository pokemonRepository)
        {
                _pokemonrepository= pokemonRepository;
        }
        public void createPokemon(Pokemon pokemon)
        {
            _pokemonrepository.createPokemon(pokemon);
            
        }

        public bool deletePokemon(int id)
        {
            return _pokemonrepository.deletePokemon(id);
            
        }

        public ICollection<Pokemon> getAllPokemons()
        {
            return _pokemonrepository.getAllPokemons();
        }

        public Pokemon getPokemon(int id)
        {
            return _pokemonrepository.getPokemon(id);
        }

        public void updatePokemon(Pokemon pokemon)
        {
            _pokemonrepository.updatePokemon(pokemon);
        }
    }
}
