using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonTrainerRelationService
    {
        public void createPokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation);
        public PokemonTrainerRelationDto getPokemonTrainerRelation(int id);
        public ICollection<PokemonTrainerRelationDto> getAllPokemonTrainerRelations();
        public void updatePokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation);
        public void deletePokemonTrainerRelation(int id);
    }
}
