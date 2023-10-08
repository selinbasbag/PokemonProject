namespace PokemonProject.Models
{
    public class Type
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<PokemonTypeRelation> pokemonTypeRelations { get; set; }
        
    }
}
