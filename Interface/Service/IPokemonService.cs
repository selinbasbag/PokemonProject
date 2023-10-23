using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonService
    {
        public void createPokemon(Pokemon pokemon);
        public PokemonDto getPokemon(int id);
        public ICollection<PokemonDto> getAllPokemons();
        public void updatePokemon(Pokemon pokemon);
        public bool deletePokemon(int id);

    }
}
