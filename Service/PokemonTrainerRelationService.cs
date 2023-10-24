using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Models;

namespace PokemonProject.Service
{
    public class PokemonTrainerRelationService : IPokemonTrainerRelationService
    {
        private readonly IPokemonTrainerRelationRepository _pokemonTrainerRelationRepository;
        private readonly IMapper _autoMapper;
        public PokemonTrainerRelationService(IPokemonTrainerRelationRepository pokemonTrainerRelationRepository, IMapper autoMapper)
        {
            _pokemonTrainerRelationRepository = pokemonTrainerRelationRepository;
            _autoMapper = autoMapper;
        }
        public void createPokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _pokemonTrainerRelationRepository.createPokemonTrainerRelation(pokemonTrainerRelation);
        }

        public void deletePokemonTrainerRelation(int id)
        {
            _pokemonTrainerRelationRepository.deletePokemonTrainerRelation(id);
        }

        public ICollection<PokemonTrainerRelationDto> getAllPokemonTrainerRelations()
        {
            ICollection<PokemonTrainerRelationDto> pokemonTrainerRelationDtos = new List<PokemonTrainerRelationDto>();
            ICollection<PokemonTrainerRelation> pokemonTrainerRelations = _pokemonTrainerRelationRepository.getAllPokemonTrainerRelations();
            foreach (var item in pokemonTrainerRelations)
            {
                pokemonTrainerRelationDtos.Add(_autoMapper.Map<PokemonTrainerRelationDto>(item));
            }
            return pokemonTrainerRelationDtos;
        }

        public PokemonTrainerRelationDto getPokemonTrainerRelation(int id)
        {
            return _autoMapper.Map< PokemonTrainerRelationDto>(_pokemonTrainerRelationRepository.getPokemonTrainerRelation(id));
        }

        public void updatePokemonTrainerRelation(PokemonTrainerRelation pokemonTrainerRelation)
        {
            _pokemonTrainerRelationRepository.updatePokemonTrainerRelation(pokemonTrainerRelation);
        }
    }
}
