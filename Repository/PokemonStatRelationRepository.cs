using Microsoft.EntityFrameworkCore;
using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class PokemonStatRelationRepository:IPokemonStatRelationRepository
    {
        public readonly DataContext _context;
        public PokemonStatRelationRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<PokemonStatRelation> getAllPokemonStatRelations()
        {
            return _context.PokemonStatRelation.ToList();
        }

        public PokemonStatRelation getPokemonStatRelation(int id)
        {
            return _context.PokemonStatRelation.Where(x => x.id == id).FirstOrDefault();
        }

        public void createPokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _context.PokemonStatRelation.Add(pokemonStatRelation);
            _context.SaveChanges();
 
        }

        public void deletePokemonStatRelation(int id)
        {
            var pokemonStatRel = _context.PokemonStatRelation.Where(x => x.id == id).FirstOrDefault();
            _context.Remove(pokemonStatRel);
        }


        public void updatePokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _context.PokemonStatRelation.Update(pokemonStatRelation);
            _context.SaveChanges();
        }
    }
}
