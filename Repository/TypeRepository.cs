using Microsoft.EntityFrameworkCore;
using PokemonProject.Interface.Repository;

namespace PokemonProject.Repository
{
    public class TypeRepository: ITypeRepository
    {
        public readonly DataContext _context;
        public TypeRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Models.Type> getAllTypes()
        {
            return _context.Type.ToList();
        }

        public Models.Type getType(int id)
        {
            return _context.Type.Where(x => x.id == id).Include(x=>x.pokemonTypeRelations).ThenInclude(y=>y.pokemon).FirstOrDefault();

        }

        public void createType(Models.Type type)
        {
            _context.Type.Add(type);
            _context.SaveChanges();
        }

        public void deleteType(int id)
        {
            var type=_context.Type.Where(x=>x.id == id).Include(x=>x.pokemonTypeRelations).FirstOrDefault();
            _context.Type.Remove(type);
            _context.SaveChanges();
        }

        public void updateType(Models.Type type)
        {
            _context.Type.Update(type);
            _context.SaveChanges();
        }
    }
}
