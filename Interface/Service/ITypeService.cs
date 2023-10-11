using PokemonProject.Models;

namespace PokemonProject.Interface.Service
{
    public interface ITypeService
    {
        public void createType(Models.Type type);
        public Models.Type getType(int id);
        public ICollection<Models.Type> getAllTypes();
        public void updateType(Models.Type type);
        public void deleteType(int id);

    }
}
