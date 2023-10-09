using PokemonProject.Models;

namespace PokemonProject.Interfaces
{
    public interface IPokemonTypeRelationRepository
    {
        public void createPokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation);
        public PokemonTypeRelation getPokemonTypeRelation(int id);
        public ICollection<PokemonTypeRelation> getAllPokemonTypeRelations();
        public void updatePokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation);
        public void deletePokemonTypeRelation(int id);
    }
}
