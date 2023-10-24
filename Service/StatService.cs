using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;
using PokemonProject.Repository;

namespace PokemonProject.Service
{
    public class StatService : IStatService
    {
        private readonly IStatRepository _statRepository;
        private readonly IMapper _autoMapper;

        public StatService(IStatRepository statRepository, IMapper automapper)
        {
            _statRepository = statRepository;
            _autoMapper = automapper;

        }

        public ICollection<StatDto> getAllStats()
        {
            ICollection<StatDto> statDtos = new List<StatDto>();
            ICollection<Stat> stats = _statRepository.getAllStats();
            foreach (var item in stats)
            {
                statDtos.Add(_autoMapper.Map<StatDto>(item));
            }
            return statDtos;
           
        }

        public StatDto getStat(int id)
        {
            return _autoMapper.Map<StatDto>(_statRepository.getStat(id));
        }
        public void createStat(Stat stat)
        {
            _statRepository.createStat(stat);
        }

        public void deleteStat(int id)
        {
            _statRepository.deleteStat(id);
        }


        public void updateStat(Stat stat)
        {
            _statRepository.updateStat(stat);
        }
    }
}
