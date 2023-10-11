using PokemonProject.Models;

namespace PokemonProject.Interface.Repository
{
    public interface IStatRepository
    {
        public void createStat(Stat stat);
        public Stat getStat(int id);
        public ICollection<Stat> getAllStats();
        public void updateStat(Stat stat);
        public void deleteStat(int id);
    }
}
