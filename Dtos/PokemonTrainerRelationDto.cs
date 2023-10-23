namespace PokemonProject.Dtos
{
    public class PokemonTrainerRelationDto
    {
        public int id {  get; set; }
        public PokemonDto pokemon { get; set; }
        public int pokemonId { get; set; }
        public int trainerId { get; set; }
        public TrainerDto trainer { get; set; }
        public bool isActive { get; set; }
    }
}
