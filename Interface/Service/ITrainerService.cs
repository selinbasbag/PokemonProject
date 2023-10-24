using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface ITrainerService
    {
        public void createTrainer(Trainer trainer);
        public TrainerDto getTrainer(int id);
        public ICollection<TrainerDto> getAllTrainers();
        public void updateTrainer(Trainer trainer);
        public void deleteTrainer(int id);
    }
}
