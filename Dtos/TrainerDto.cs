namespace PokemonProject.Dtos
{
    public class TrainerDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool isActive { get; set; }
        public ICollection<PokemonTrainerRelationDto> pokemonTrainerRelations { get; set; }
         
    }
}
