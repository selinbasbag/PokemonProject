using Microsoft.EntityFrameworkCore;
using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class StatRepository: IStatRepository
    {
        private readonly DataContext _context;
        public StatRepository(DataContext context)
        {
            _context = context;
        }

        public void createStat(Stat stat)
        {
           _context.Stat.Add(stat);
            _context.SaveChanges();
        }

        public void deleteStat(int id)
        {
            var stat = _context.Stat.Where(x => x.id == id).Include(x => x.pokemonStatRelations).FirstOrDefault();
            _context.Stat.Remove(stat);
            _context.SaveChanges();
        }

        public ICollection<Stat> getAllStats()
        {
            return _context.Stat.ToList();
        }

        public Stat getStat(int id)
        {
            return _context.Stat.Where(x => x.id == id).FirstOrDefault();
        }

        public void updateStat(Stat stat)
        {
           _context.Stat.Update(stat);
            _context.SaveChanges();
        }
    }
}
