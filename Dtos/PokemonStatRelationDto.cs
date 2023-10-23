namespace PokemonProject.Dtos
{
    public class PokemonStatRelationDto
    {
        public int id {  get; set; }
        public int value { get; set; }
        public PokemonDto pokemon { get; set; }
        public int pokemonId { get; set; }
        public int statId { get; set; }
        public  StatDto stat { get; set; }

    }
}
