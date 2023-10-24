using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IStatService
    {
        public void createStat(Stat stat);
        public StatDto getStat(int id);
        public ICollection<StatDto> getAllStats();
        public void updateStat(Stat stat);
        public void deleteStat(int id);
    }
}
