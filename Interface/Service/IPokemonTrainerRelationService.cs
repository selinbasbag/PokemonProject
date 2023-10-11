using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonTrainerRelationService
    {
        public void createPokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation);
        public PokemonTrainerRelation getPokemonTrainerRelation(int id);
        public ICollection<PokemonTrainerRelation> getAllPokemonTrainerRelations();
        public void updatePokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation);
        public void deletePokemonTrainerRelation(int id);
    }
}
