using Microsoft.EntityFrameworkCore;
using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{

    public class PokemonRepository:IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
                _context = context;
        }

        public ICollection<Pokemon> getAllPokemons()
        {
            return _context.Pokemon.ToList();
            
            
        }

        public Pokemon getPokemon(int id)
        {
            return _context.Pokemon.
                Where(x => x.id == id).FirstOrDefault();
        }

        public void createPokemon(Pokemon pokemon)
        {
            _context.Pokemon.Add(pokemon);
            _context.SaveChanges();

        }

        public bool deletePokemon(int id)
        {
            var pokemon = _context.Pokemon.Where(x => x.id == id).Include(x=>x.pokemonTrainerRelations).FirstOrDefault();
            pokemon.isActive=false;
            foreach (var item in pokemon.pokemonTrainerRelations)
            {
                item.isActive = false;
            }
            _context.Pokemon.Update(pokemon);
            _context.SaveChanges();
            return true;
        }

        public void updatePokemon(Pokemon pokemon)
        {
            _context.Pokemon.Update(pokemon);
            _context.SaveChanges();
        }

       
    }

}
