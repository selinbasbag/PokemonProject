using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;
using PokemonProject.Repository;

namespace PokemonProject.Service
{
    public class PokemonStatRelationService : IPokemonStatRelationService
    {
        private readonly IPokemonStatRelationRepository _pokemonStatRelationRepository;
        private readonly IMapper _autoMapper;
        public PokemonStatRelationService(IPokemonStatRelationRepository pokemonStatRelationRepository,IMapper autoMapper)
        {
            _pokemonStatRelationRepository= pokemonStatRelationRepository;
            _autoMapper= autoMapper;
        }
        public void createPokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _pokemonStatRelationRepository.createPokemonStatRelation(pokemonStatRelation);
        }

        public void deletePokemonStatRelation(int id)
        {
            _pokemonStatRelationRepository.deletePokemonStatRelation(id);
        }

        public ICollection<PokemonStatRelationDto> getAllPokemonStatRelations()
        {
            ICollection<PokemonStatRelationDto> pokemonStatRelationDtos=new List<PokemonStatRelationDto>();
            ICollection<PokemonStatRelation> pokemonStatRelations= _pokemonStatRelationRepository.getAllPokemonStatRelations();
            foreach (var item in pokemonStatRelations)
            {
                pokemonStatRelationDtos.Add(_autoMapper.Map<PokemonStatRelationDto>(item));
            }
            return pokemonStatRelationDtos;
        }

        public PokemonStatRelationDto getPokemonStatRelation(int id)
        {
            return _autoMapper.Map<PokemonStatRelationDto>(_pokemonStatRelationRepository.getPokemonStatRelation(id));
        }

        public void updatePokemonStatRelation(PokemonStatRelation pokemonStatRelation)
        {
            _pokemonStatRelationRepository.updatePokemonStatRelation(pokemonStatRelation);
        }
    }
}
