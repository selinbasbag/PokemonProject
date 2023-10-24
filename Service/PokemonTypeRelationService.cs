using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonTypeRelationService : IPokemonTypeRelationService
    {
        private readonly IPokemonTypeRelationRepository _pokemonTypeRelationRepository;
        private readonly IMapper _autoMapper;
        public PokemonTypeRelationService(IPokemonTypeRelationRepository pokemonTypeRelationRepository, IMapper autoMapper)
        {
            _pokemonTypeRelationRepository = pokemonTypeRelationRepository;
            _autoMapper = autoMapper;
        }
        public void createPokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _pokemonTypeRelationRepository.createPokemonTypeRelation(pokemonTypeRelation);
        }

        public void deletePokemonTypeRelation(int id)
        {
            _pokemonTypeRelationRepository.deletePokemonTypeRelation(id);
        }

        public ICollection<PokemonTypeRelationDto> getAllPokemonTypeRelations()
        {
            ICollection<PokemonTypeRelationDto > pokemonTypeRelationDtos=new List<PokemonTypeRelationDto>();
            ICollection<PokemonTypeRelation>pokemonTypeRelations= _pokemonTypeRelationRepository.getAllPokemonTypeRelations();
            foreach (var item in pokemonTypeRelations)
            {
                pokemonTypeRelationDtos.Add(_autoMapper.Map<PokemonTypeRelationDto>(item));
            }
            return pokemonTypeRelationDtos;
        }

        public PokemonTypeRelationDto getPokemonTypeRelation(int id)
        {
            return _autoMapper.Map<PokemonTypeRelationDto>(_pokemonTypeRelationRepository.getPokemonTypeRelation(id));
        }

        public void updatePokemonTypeRelation(PokemonTypeRelation pokemonTypeRelation)
        {
            _pokemonTypeRelationRepository.updatePokemonTypeRelation(pokemonTypeRelation);
        }
    }
}
