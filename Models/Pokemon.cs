namespace PokemonProject.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public bool isActive { get; set; }
        public  ICollection<PokemonStatRelation> pokemonStatRelations { get; set; }
        public ICollection<PokemonTypeRelation> pokemonTypeRelations { get; set; }
        public ICollection<PokemonTrainerRelation> pokemonTrainerRelations { get; set; }


    }
}
