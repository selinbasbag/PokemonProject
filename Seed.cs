using PokemonProject.Models;

namespace PokemonProject
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {/*
            if (!dataContext.Type.Any())
            {
                var types = new List<PokemonProject.Models.Type>{
                     new PokemonProject.Models.Type() {
                     name = "normal"
                     },
                     new PokemonProject.Models.Type() {
                     name = "fighting"
                     },
                     new PokemonProject.Models.Type() {
                     name = "flying"
                     },
                     new PokemonProject.Models.Type() {
                     name = "posion"
                     },
                     new PokemonProject.Models.Type() {
                     name = "ground"
                     },
                     new PokemonProject.Models.Type() {
                     name = "rock"
                     },
                     new PokemonProject.Models.Type() {
                     name = "bug"
                     },
                     new PokemonProject.Models.Type() {
                     name = "ghost"
                     },
                     new PokemonProject.Models.Type() {
                     name = "steel"
                     },
                     new PokemonProject.Models.Type() {
                     name = "fire"
                     },
                     new PokemonProject.Models.Type() {
                     name = "water"
                     },
                     new PokemonProject.Models.Type() {
                     name = "grass"
                     },
                     new PokemonProject.Models.Type() {
                     name = "electric"
                     },
                     new PokemonProject.Models.Type() {
                     name = "psychic"
                     },
                     new PokemonProject.Models.Type() {
                     name = "ice"
                     },
                     new PokemonProject.Models.Type() {
                     name = "dragon"
                     },
                     new PokemonProject.Models.Type() {
                     name = "dark"
                     },
                     new PokemonProject.Models.Type() {
                     name = "fairy"
                     },
                     new PokemonProject.Models.Type() {
                     name = "unknown"
                     },
                     new PokemonProject.Models.Type() {
                     name = "shadow"
                     },
                 };
                dataContext.Type.AddRange(types);
                dataContext.SaveChanges();
            }

            if (!dataContext.Stat.Any())
            {
                var stats = new List<Stat>()
                {
                    new Stat()
                    {
                        name = "hp"
                    },
                    new Stat()
                    {
                        name = "attack"
                    },
                    new Stat()
                    {
                        name = "defence"
                    },
                    new Stat()
                    {
                        name = "special-attack"
                    },
                    new Stat()
                    {
                        name = "special-defence"
                    }
                };
                dataContext.Stat.AddRange(stats);
                dataContext.SaveChanges();
            }

            if (!dataContext.Trainer.Any())
            {
                var trainers = new List<Trainer>()
                {
                    new Trainer()
                    {
                        name = "Deniz",
                        age = 21,
                        isActive = true
                    },
                    new Trainer()
                    {
                        name = "Fatih",
                        age = 25,
                        isActive = true
                    },
                    new Trainer()
                    {
                        name = "Halim",
                        age = 27,
                        isActive = true
                    }
                };
                dataContext.Trainer.AddRange(trainers);
                dataContext.SaveChanges();
            }*/

            if (!dataContext.Pokemon.Any())
            {
                var pokemons = new List<Pokemon>()
                {
                    new Pokemon()
                    {
                        name = "Wartortle",
                        photoUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/008.png",
                        isActive = true,
                        pokemonTrainerRelations = new List<PokemonTrainerRelation>()
                        {
                            new PokemonTrainerRelation()
                            {
                                trainerId =1,
                                isActive = true
                            }
                        },
                        pokemonTypeRelations = new List<PokemonTypeRelation>()
                        {
                            new PokemonTypeRelation() {
                                typeId = 11
                            },
                        },
                        pokemonStatRelations = new List<PokemonStatRelation>()
                        {
                            new PokemonStatRelation()
                            {
                                value = 59,
                                statId =1
                            },
                            new PokemonStatRelation()
                            {
                                value = 63,
                                statId =2
                            },
                            new PokemonStatRelation()
                            {
                                value = 80,
                                statId =3
                            },
                            new PokemonStatRelation()
                            {
                                value = 65,
                                statId =4
                            },
                            new PokemonStatRelation()
                            {
                                value = 80,
                                statId =5
                            },
                        }
                    },

                    new Pokemon()
                    {
                        name = "Blastoise",
                        photoUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/009.png",
                        isActive = true,
                        pokemonTrainerRelations = new List<PokemonTrainerRelation>()
                        {
                            new PokemonTrainerRelation()
                            {
                                trainerId =1,
                                isActive = true
                            }
                        },
                        pokemonTypeRelations = new List<PokemonTypeRelation>()
                        {
                            new PokemonTypeRelation (){
                                typeId =11
                            },
                        },
                        pokemonStatRelations = new List<PokemonStatRelation>()
                        {
                            new PokemonStatRelation()
                            {
                                value = 79,
                                statId =1
                            },
                            new PokemonStatRelation()
                            {
                                value = 83,
                                statId =2
                            },
                            new PokemonStatRelation()
                            {
                                value = 100,
                                statId =3
                            },
                            new PokemonStatRelation()
                            {
                                value = 85,
                                statId =4
                            },
                            new PokemonStatRelation()
                            {
                                value = 105,
                                statId =5
                            },
                        },
                    },

                    new Pokemon()
                    {
                        name = "Raticate",
                        photoUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/020.png",
                        isActive = true,
                        pokemonTrainerRelations = new List<PokemonTrainerRelation>()
                        {
                            new PokemonTrainerRelation()
                            {
                                trainerId =2,
                                isActive = true
                            }
                        },
                        pokemonTypeRelations = new List<PokemonTypeRelation>()
                        {
                            new PokemonTypeRelation (){
                                typeId =1
                            },
                        },
                        pokemonStatRelations = new List<PokemonStatRelation>()
                        {
                            new PokemonStatRelation()
                            {
                                value = 55,
                                statId =1
                            },
                            new PokemonStatRelation()
                            {
                                value = 81,
                                statId =2
                            },
                            new PokemonStatRelation()
                            {
                                value = 60,
                                statId =3
                            },
                            new PokemonStatRelation()
                            {
                                value = 50,
                                statId =4
                            },
                            new PokemonStatRelation()
                            {
                                value = 70,
                                statId =5
                            },
                        },
                    },

                    new Pokemon()
                    {
                        name = "Pikachu",
                        photoUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/025.png",
                        isActive = true,
                        pokemonTrainerRelations = new List<PokemonTrainerRelation>()
                        {
                            new PokemonTrainerRelation()
                            {
                                trainerId =2,
                                isActive = true
                            }
                        },
                        pokemonTypeRelations = new List<PokemonTypeRelation>()
                        {
                            new PokemonTypeRelation (){
                                typeId =13
                            },
                        },
                        pokemonStatRelations = new List<PokemonStatRelation>()
                        {
                            new PokemonStatRelation()
                            {
                                value = 35,
                                statId =1
                            },
                            new PokemonStatRelation()
                            {
                                value = 55,
                                statId =2
                            },
                            new PokemonStatRelation()
                            {
                                value = 40,
                                statId =3
                            },
                            new PokemonStatRelation()
                            {
                                value = 50,
                                statId =4
                            },
                            new PokemonStatRelation()
                            {
                                value = 50,
                                statId =5
                            },
                        },
                    },

                    new Pokemon()
                    {
                        name = "Clefairy",
                        photoUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/035.png",
                        isActive = true,
                        pokemonTrainerRelations = new List<PokemonTrainerRelation>()
                        {
                            new PokemonTrainerRelation()
                            {
                                trainerId =3,
                                isActive = true
                            }
                        },
                        pokemonTypeRelations = new List<PokemonTypeRelation>()
                        {
                            new PokemonTypeRelation (){
                                typeId =18
                            },
                        },
                        pokemonStatRelations = new List<PokemonStatRelation>()
                        {
                            new PokemonStatRelation()
                            {
                                value = 70,
                                statId =1
                            },
                            new PokemonStatRelation()
                            {
                                value = 45,
                                statId =2
                            },
                            new PokemonStatRelation()
                            {
                                value = 48,
                                statId =3
                            },
                            new PokemonStatRelation()
                            {
                                value = 60,
                                statId =4
                            },
                            new PokemonStatRelation()
                            {
                                value = 65,
                                statId =5
                            },
                        },
                    }
                };
                dataContext.Pokemon.AddRange(pokemons);
                dataContext.SaveChanges();

            }
        }
    }
}
