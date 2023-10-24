using AutoMapper;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;

namespace PokemonProject.Service
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;
        private readonly IMapper _autoMapper;
        public TypeService(ITypeRepository type, IMapper automapper)
        {
            _autoMapper = automapper;
            _typeRepository = type;
        }
        public void createType(Models.Type type)
        {
            _typeRepository.createType(type);
        }

        public void deleteType(int id)
        {
            _typeRepository.deleteType(id);
        }

        public ICollection<Dtos.TypeDto> getAllTypes()
        {
            ICollection<Dtos.TypeDto> typeDtos = new List<Dtos.TypeDto>();
            ICollection<Models.Type> types = _typeRepository.getAllTypes();
            foreach (var item in types)
            {
                typeDtos.Add(_autoMapper.Map<Dtos.TypeDto>(item));
            }
            return typeDtos;
        }

        public Dtos.TypeDto getType(int id)
        {
            return _autoMapper.Map < Dtos.TypeDto > (_typeRepository.getType(id));
        }

        public void updateType(Models.Type type)
        {
            _typeRepository.updateType(type);
        }
    }
}
