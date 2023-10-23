using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PokemonProject.Models;
using System.Diagnostics;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        //options.UseLazyLoadingProxies();
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //one to many relations connection
        modelBuilder.Entity<Pokemon>()
            .HasMany<PokemonStatRelation>(s => s.pokemonStatRelations)
            .WithOne(g => g.pokemon)
            .HasForeignKey(e => e.pokemonId)
            .HasPrincipalKey(e => e.id);

        modelBuilder.Entity<Pokemon>()
            .HasMany<PokemonTypeRelation>(s => s.pokemonTypeRelations)
            .WithOne(g => g.pokemon)
            .HasForeignKey(e => e.pokemonId)
            .HasPrincipalKey(e => e.id);

        modelBuilder.Entity<Pokemon>()
            .HasMany<PokemonTrainerRelation>(s => s.pokemonTrainerRelations)
            .WithOne(g => g.pokemon)
            .HasForeignKey(e => e.pokemonId)
            .HasPrincipalKey(e => e.id);

        modelBuilder.Entity<Stat>()
            .HasMany<PokemonStatRelation>(s => s.pokemonStatRelations)
            .WithOne(g => g.stat)
            .HasForeignKey(e => e.statId)
            .HasPrincipalKey(e => e.id);

        modelBuilder.Entity<PokemonProject.Models.Type>()
            .HasMany<PokemonTypeRelation>(s => s.pokemonTypeRelations)
            .WithOne(g => g.type)
            .HasForeignKey(e => e.typeId)
            .HasPrincipalKey(e => e.id);

        modelBuilder.Entity<Trainer>()
            .HasMany<PokemonTrainerRelation>(s => s.pokemonTrainerRelations)
            .WithOne(g => g.trainer)
            .HasForeignKey(e => e.trainerId)
            .HasPrincipalKey(e => e.id);




    }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<PokemonProject.Models.Type> Type { get; set; }
    public DbSet<Trainer> Trainer { get; set; }
    public DbSet<Stat> Stat { get; set; }
    public DbSet<PokemonStatRelation> PokemonStatRelation { get; set; }
    public DbSet<PokemonTrainerRelation> PokemonTrainerRelation { get; set; }
    public DbSet<PokemonTypeRelation> PokemonTypeRelation { get; set; }




}