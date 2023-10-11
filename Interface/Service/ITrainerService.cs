using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface ITrainerService
    {
        public void createTrainer(Trainer trainer);
        public Trainer getTrainer(int id);
        public ICollection<Trainer> getAllTrainers();
        public void updateTrainer(Trainer trainer);
        public void deleteTrainer(int id);
    }
}
