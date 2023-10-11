using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonService
    {
        public void createPokemon(Pokemon pokemon);
        public Pokemon getPokemon(int id);
        public ICollection<Pokemon> getAllPokemons();
        public void updatePokemon(Pokemon pokemon);
        public bool deletePokemon(int id);

    }
}
