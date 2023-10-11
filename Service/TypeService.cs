using PokemonProject.Interface.Service;

namespace PokemonProject.Service
{
    public class TypeService : ITypeService
    {
        private readonly ITypeService _typeService;
        public TypeService(ITypeService typeservice) 
        { 
                _typeService = typeservice;
        }
        public void createType(Models.Type type)
        {
            _typeService.createType(type);
        }

        public void deleteType(int id)
        {
            _typeService.deleteType(id);
        }

        public ICollection<Models.Type> getAllTypes()
        {
            return _typeService.getAllTypes();
        }

        public Models.Type getType(int id)
        {
            return _typeService.getType(id);
        }

        public void updateType(Models.Type type)
        {
            _typeService.updateType(type);
        }
    }
}
