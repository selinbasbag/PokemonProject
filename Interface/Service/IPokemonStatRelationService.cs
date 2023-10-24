using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonStatRelationService
    {
        public void createPokemonStatRelation(PokemonStatRelation pokemonStatRelation);
        public PokemonStatRelationDto getPokemonStatRelation(int id);
        public ICollection<PokemonStatRelationDto> getAllPokemonStatRelations();
        public void updatePokemonStatRelation(PokemonStatRelation pokemonStatRelation);
        public void deletePokemonStatRelation(int id);
    }
}
