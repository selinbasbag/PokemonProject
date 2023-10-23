namespace PokemonProject.Dtos
{
    public class TypeDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<PokemonTypeRelationDto> pokemonTypeRelations { get; set; }
        
    }
}
