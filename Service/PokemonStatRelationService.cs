using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonStatRelationService : IPokemonStatRelationService
    {
        private readonly IPokemonStatRelationService _pokemonStatRelationService;
        public PokemonStatRelationService(IPokemonStatRelationService pokemonStatRelationService)
        {
                _pokemonStatRelationService = pokemonStatRelationService;
        }
        public void createPokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _pokemonStatRelationService.createPokemonStatRelation(pokemonStatRelation);
        }

        public void deletePokemonStatRelation(int id)
        {
            _pokemonStatRelationService.deletePokemonStatRelation(id);
        }

        public ICollection<PokemonStatRelation> getAllPokemonStatRelations()
        {
           return  _pokemonStatRelationService.getAllPokemonStatRelations();
        }

        public PokemonStatRelation getPokemonStatRelation(int id)
        {
            return _pokemonStatRelationService.getPokemonStatRelation(id);
        }

        public void updatePokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _pokemonStatRelationService.updatePokemonStatRelation(pokemonStatRelation);
        }
    }
}
