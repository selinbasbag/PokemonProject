using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class TrainerService : ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;
        private readonly IMapper _autoMapper;
        public TrainerService(ITrainerRepository trainerRepository, IMapper automapper)
        {
            _trainerRepository = trainerRepository;
            _autoMapper = automapper;
        }
        public void createTrainer(Trainer trainer)
        {
            _trainerRepository.createTrainer(trainer);
        }

        public void deleteTrainer(int id)
        {
            _trainerRepository.deleteTrainer(id);
        }

        public ICollection<TrainerDto> getAllTrainers()
        {
            ICollection<TrainerDto> trainerDtos = new List<TrainerDto>();
            ICollection<Trainer> trainers = _trainerRepository.getAllTrainers();
            foreach (var item in trainers)
            {
                trainerDtos.Add(_autoMapper.Map<TrainerDto>(item));
            }

            return trainerDtos;
        }

        public TrainerDto getTrainer(int id)
        {
            return _autoMapper.Map<TrainerDto>(_trainerRepository.getTrainer(id));
        }

        public void updateTrainer(Trainer trainer)
        {
            _trainerRepository.updateTrainer(trainer);
        }
    }
}
