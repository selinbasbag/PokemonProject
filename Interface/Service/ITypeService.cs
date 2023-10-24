using PokemonProject.Models;
using PokemonProject.Dtos;

namespace PokemonProject.Interface.Service
{
    public interface ITypeService
    {
        public void createType(Models.Type type);
        public Dtos.TypeDto getType(int id);
        public ICollection<Dtos.TypeDto> getAllTypes();
        public void updateType(Models.Type type);
        public void deleteType(int id);

    }
}
