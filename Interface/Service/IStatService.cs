using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IStatService
    {
        public void createStat(Stat stat);
        public Stat getStat(int id);
        public ICollection<Stat> getAllStats();
        public void updateStat(Stat stat);
        public void deleteStat(int id);
    }
}
