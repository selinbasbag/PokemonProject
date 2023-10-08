﻿namespace PokemonProject.Models
{
    public class Stat
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<PokemonStatRelation> pokemonStatRelations { get; set; }
    }
}
