using Microsoft.AspNetCore.Mvc;
using PokemonProject.Models;

namespace PokemonProject.Interfaces
{
    public interface IPokemonRepository
    {

        public void createPokemon(Pokemon pokemon);
        public Pokemon getPokemon(int id);
        public ICollection<Pokemon> getAllPokemons();
        public void updatePokemon(Pokemon pokemon);
        public void deletePokemon(int id);
      
        


    }
}
