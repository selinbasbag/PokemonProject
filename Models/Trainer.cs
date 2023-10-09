namespace PokemonProject.Models
{
    public class Trainer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool isActive { get; set; }
        public ICollection<PokemonTrainerRelation> pokemonTrainerRelations { get; set; }
         
    }
}
