namespace PokemonProject.Dtos
{
    public class StatDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<PokemonStatRelationDto> pokemonStatRelations { get; set; }
    }
}
