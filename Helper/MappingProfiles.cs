using AutoMapper;
using PokemonProject.Dtos;
using PokemonProject.Models;
using PokemonProject.Dtos;
using PokemonProject.Models;
using System.Diagnostics.Metrics;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonStatRelation, PokemonStatRelationDto>();
            CreateMap<PokemonTrainerRelation, PokemonTrainerRelationDto>();
            CreateMap<Stat, StatDto>();
            CreateMap<PokemonTypeRelation, PokemonTypeRelationDto>();
            CreateMap<PokemonProject.Models.Type, TypeDto>();
            CreateMap<Trainer, TrainerDto>();
            CreateMap<Pokemon, IndirectlyPokemonDto>();



        }
    }
}