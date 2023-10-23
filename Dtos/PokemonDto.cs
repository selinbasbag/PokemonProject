namespace PokemonProject.Dtos
{
    public class PokemonDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public ICollection<PokemonStatRelationDto> pokemonStatRelations { get; set; }
        public ICollection<PokemonTypeRelationDto> pokemonTypeRelations { get; set; }
        public ICollection<PokemonTrainerRelationDto> pokemonTrainerRelations { get; set; }


    }
}
