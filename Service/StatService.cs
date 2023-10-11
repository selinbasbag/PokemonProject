using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class StatService : IStatService
    {
        private readonly IStatService _statService;
        public StatService(IStatService statService)
        {
                _statService = statService;
        }
        public void createStat(Stat stat)
        {
            _statService.createStat(stat);
        }

        public void deleteStat(int id)
        {
            _statService.deleteStat(id);
        }

        public ICollection<Stat> getAllStats()
        {
            return _statService.getAllStats();
        }

        public Stat getStat(int id)
        {
            return _statService.getStat(id);
        }

        public void updateStat(Stat stat)
        {
            _statService.updateStat(stat);
        }
    }
}
