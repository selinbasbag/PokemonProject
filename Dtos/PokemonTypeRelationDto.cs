namespace PokemonProject.Dtos 
{ 

    public class PokemonTypeRelationDto
    {
        public int id { get; set; }
        public PokemonDto pokemon { get; set; }
        public int pokemonId { get; set; }
        public int typeId { get; set; }
        public TypeDto type { get; set; }
    }
}
