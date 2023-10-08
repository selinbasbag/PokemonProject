namespace PokemonProject.Models
{
    public class PokemonTrainerRelation
    {
        public int id {  get; set; }
        public Pokemon pokemon { get; set; }
        public int pokemonId { get; set; }
        public int trainerId { get; set; }
        public Trainer trainer { get; set; }
        public bool isActive { get; set; }
    }
}
