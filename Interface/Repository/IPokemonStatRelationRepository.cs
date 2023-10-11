using PokemonProject.Models;

namespace PokemonProject.Interface.Repository
{
    public interface IPokemonStatRelationRepository
    {
        public void createPokemonStatRelation(PokemonStatRelation pokemonStatRelation);
        public PokemonStatRelation getPokemonStatRelation(int id);
        public ICollection<PokemonStatRelation> getAllPokemonStatRelations();
        public void updatePokemonStatRelation(PokemonStatRelation pokemonStatRelation);
        public void deletePokemonStatRelation(int id);
    }
}
