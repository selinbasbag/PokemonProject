using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class PokemonTypeRelationRepository: IPokemonTypeRelationRepository
    {
        public readonly DataContext _context;
        public PokemonTypeRelationRepository(DataContext context)
        {
            _context = context;
        }

        public void createPokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _context.PokemonTypeRelation.Add(pokemonTypeRelation);
            _context.SaveChanges();
        }

        public void deletePokemonTypeRelation(int id)
        {
            var deletepokemontype=_context.PokemonTypeRelation.Where(x=>x.id==id).FirstOrDefault();
            _context.PokemonTypeRelation.Remove(deletepokemontype);
            _context.SaveChanges();
        }

        public ICollection<PokemonTypeRelation> getAllPokemonTypeRelations()
        {
            return _context.PokemonTypeRelation.ToList();

        }

        public PokemonTypeRelation getPokemonTypeRelation(int id)
        {
            return _context.PokemonTypeRelation.Where(x => x.id == id).FirstOrDefault();
        }

        public void updatePokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _context.PokemonTypeRelation.Update(pokemonTypeRelation);
            _context.SaveChanges();
        }
    }
}
