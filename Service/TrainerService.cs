using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class TrainerService : ITrainerService
    {
        private readonly ITrainerService _trainerService;
        public TrainerService(ITrainerService trainerService)
        {
                _trainerService = trainerService;
        }
        public void createTrainer(Trainer trainer)
        {
            _trainerService.createTrainer(trainer);
        }

        public void deleteTrainer(int id)
        {
            _trainerService.deleteTrainer(id);
        }

        public ICollection<Trainer> getAllTrainers()
        {
            return _trainerService.getAllTrainers();
        }

        public Trainer getTrainer(int id)
        {
            return _trainerService.getTrainer(id);
        }

        public void updateTrainer(Trainer trainer)
        {
            _trainerService.updateTrainer(trainer);
        }
    }
}
