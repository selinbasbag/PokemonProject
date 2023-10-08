namespace PokemonProject.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Stat> stats { get; set; }
        public ICollection<Type> types { get; set; }
        string photoUrl { get; set; }
        bool isActive { get; set; }
        public ICollection<PokemonStatRelation> pokemonStatRelations { get; set; }
        public ICollection<PokemonTypeRelation> pokemonTypeRelations { get; set; }
        public ICollection<PokemonTrainerRelation> pokemonTrainerRelations { get; set; }


    }
}
