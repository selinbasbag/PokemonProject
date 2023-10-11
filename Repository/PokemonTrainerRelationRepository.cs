using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class PokemonTrainerRelationRepository : IPokemonTrainerRelationRepository
    {
        public readonly DataContext _context;
        public PokemonTrainerRelationRepository(DataContext context)
        {
            _context=context;
        }
        public void createPokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _context.PokemonTrainerRelation.Add(pokemonTrainerRelation);
            _context.SaveChanges();
        }

        public void deletePokemonTrainerRelation(int id)
        {
            var deletePokemonTrainerRel=_context.PokemonTrainerRelation.Where(x=>id==id).FirstOrDefault();
            _context.Remove(deletePokemonTrainerRel);
            _context.SaveChanges();

        }

        public ICollection<PokemonTrainerRelation> getAllPokemonTrainerRelations()
        {
            return _context.PokemonTrainerRelation.ToList();

        }

        public PokemonTrainerRelation getPokemonTrainerRelation(int id)
        {
            return _context.PokemonTrainerRelation.Where(x => x.id == id).FirstOrDefault();
        }

        public void updatePokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _context.PokemonTrainerRelation.Update(pokemonTrainerRelation);
            _context.SaveChanges();
        }
    }
}
