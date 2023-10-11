using Microsoft.EntityFrameworkCore;
using PokemonProject.Interface.Repository;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly DataContext _context;
        public TrainerRepository(DataContext context)
        {
            _context = context;
        }

        public Trainer getTrainer(int id)
        {
            return _context.Trainer.
                Where(x => x.id == id).FirstOrDefault();
        }

        public ICollection<Trainer> getAllTrainers()
        {
            return _context.Trainer.ToList();
        }

        public void createTrainer(Trainer trainer)
        {
            _context.Trainer.Add(trainer);
            _context.SaveChanges();
        }

        public void deleteTrainer(int id)
        {
            var trainer = _context.Trainer.Where(x => x.id == id).Include(x => x.pokemonTrainerRelations).FirstOrDefault();
            _context.Trainer.Remove(trainer);
            _context.SaveChanges();
        }


        public void updateTrainer(Trainer trainer)
        {
            _context.Trainer.Update(trainer);
            _context.SaveChanges();
        }
    }
}
