using PokemonProject.Dtos;
using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface IPokemonTypeRelationService
    {
        public void createPokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation);
        public PokemonTypeRelationDto getPokemonTypeRelation(int id);
        public ICollection<PokemonTypeRelationDto> getAllPokemonTypeRelations();
        public void updatePokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation);
        public void deletePokemonTypeRelation(int id);
    }
}
