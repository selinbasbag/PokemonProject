using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonTrainerRelationService : IPokemonTrainerRelationService
    {
        private readonly IPokemonTrainerRelationService _pokemonTrainerRelationService;
        public PokemonTrainerRelationService(IPokemonTrainerRelationService pokemonTrainerRelationService)
        {
                _pokemonTrainerRelationService = pokemonTrainerRelationService;
        }
        public void createPokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _pokemonTrainerRelationService.createPokemonTrainerRelation(pokemonTrainerRelation);
        }

        public void deletePokemonTrainerRelation(int id)
        {
            _pokemonTrainerRelationService.deletePokemonTrainerRelation(id);
        }

        public ICollection<PokemonTrainerRelation> getAllPokemonTrainerRelations()
        {
            return _pokemonTrainerRelationService.getAllPokemonTrainerRelations();
        }

        public PokemonTrainerRelation getPokemonTrainerRelation(int id)
        {
            return _pokemonTrainerRelationService.getPokemonTrainerRelation(id);
        }

        public void updatePokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _pokemonTrainerRelationService.updatePokemonTrainerRelation(pokemonTrainerRelation);
        }
    }
}
