using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonTypeRelationService : IPokemonTypeRelationService
    {
        private readonly IPokemonTypeRelationService _pokemonTypeRelationService;
        public PokemonTypeRelationService(IPokemonTypeRelationService pokemonTypeRelationService)
        {
                _pokemonTypeRelationService = pokemonTypeRelationService;
        }
        public void createPokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _pokemonTypeRelationService.createPokemonTypeRelation(pokemonTypeRelation); 
        }

        public void deletePokemonTypeRelation(int id)
        {
            _pokemonTypeRelationService.deletePokemonTypeRelation(id);
        }

        public ICollection<PokemonTypeRelation> getAllPokemonTypeRelations()
        {
            return _pokemonTypeRelationService.getAllPokemonTypeRelations();
        }

        public PokemonTypeRelation getPokemonTypeRelation(int id)
        {
            return _pokemonTypeRelationService.getPokemonTypeRelation(id);
        }

        public void updatePokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _pokemonTypeRelationService.updatePokemonTypeRelation(pokemonTypeRelation);
        }
    }
}
