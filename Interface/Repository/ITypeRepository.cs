using PokemonProject.Models;

namespace PokemonProject.Interface.Repository
{
    public interface ITypeRepository
    {
        public void createType(Models.Type type);
        public Models.Type getType(int id);
        public ICollection<Models.Type> getAllTypes();
        public void updateType(Models.Type type);
        public void deleteType(int id);

    }
}
