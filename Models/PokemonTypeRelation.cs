namespace PokemonProject.Models
{
    public class PokemonTypeRelation
    {
        public int id { get; set; }
        public Pokemon pokemon { get; set; }
        public int pokemonId { get; set; }
        public int typeId { get; set; }
        virtual public Type type { get; set; }
    }
}
