using PokemonProject.Models;

namespace PokemonProject.Interfaces
{
    public interface ITypeRepository
    {
        public void createType(PokemonProject.Models.Type type);
        public PokemonProject.Models.Type getType(int id);
        public ICollection<PokemonProject.Models.Type> getAllTypes();
        public void updateType(PokemonProject.Models.Type type);
        public void deleteType(int id);

    }
}
