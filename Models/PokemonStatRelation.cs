namespace PokemonProject.Models
{
    public class PokemonStatRelation
    {
        public int id {  get; set; }
        public int value { get; set; }
        public Pokemon pokemon { get; set; }
        public int pokemonId { get; set; }
        public int statId { get; set; }
        public  Stat stat { get; set; }

    }
}
