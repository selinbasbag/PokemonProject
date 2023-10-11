using PokemonProject.Models;

namespace PokemonProject.Interface.Repository
{
    public interface ITrainerRepository
    {
        public void createTrainer(Trainer trainer);
        public Trainer getTrainer(int id);
        public ICollection<Trainer> getAllTrainers();
        public void updateTrainer(Trainer trainer);
        public void deleteTrainer(int id);
    }
}
