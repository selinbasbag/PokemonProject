﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonProject.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PokemonProject.Models.Pokemon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("photoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonStatRelation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("pokemonId")
                        .HasColumnType("integer");

                    b.Property<int>("statId")
                        .HasColumnType("integer");

                    b.Property<int>("value")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("pokemonId");

                    b.HasIndex("statId");

                    b.ToTable("PokemonStatRelation");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonTrainerRelation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<int>("pokemonId")
                        .HasColumnType("integer");

                    b.Property<int>("trainerId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("pokemonId");

                    b.HasIndex("trainerId");

                    b.ToTable("PokemonTrainerRelation");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonTypeRelation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("pokemonId")
                        .HasColumnType("integer");

                    b.Property<int>("typeId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("pokemonId");

                    b.HasIndex("typeId");

                    b.ToTable("PokemonTypeRelation");
                });

            modelBuilder.Entity("PokemonProject.Models.Stat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("PokemonProject.Models.Trainer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("PokemonProject.Models.Type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonStatRelation", b =>
                {
                    b.HasOne("PokemonProject.Models.Pokemon", "pokemon")
                        .WithMany("pokemonStatRelations")
                        .HasForeignKey("pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonProject.Models.Stat", "stat")
                        .WithMany("pokemonStatRelations")
                        .HasForeignKey("statId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pokemon");

                    b.Navigation("stat");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonTrainerRelation", b =>
                {
                    b.HasOne("PokemonProject.Models.Pokemon", "pokemon")
                        .WithMany("pokemonTrainerRelations")
                        .HasForeignKey("pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonProject.Models.Trainer", "trainer")
                        .WithMany("pokemonTrainerRelations")
                        .HasForeignKey("trainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pokemon");

                    b.Navigation("trainer");
                });

            modelBuilder.Entity("PokemonProject.Models.PokemonTypeRelation", b =>
                {
                    b.HasOne("PokemonProject.Models.Pokemon", "pokemon")
                        .WithMany("pokemonTypeRelations")
                        .HasForeignKey("pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonProject.Models.Type", "type")
                        .WithMany("pokemonTypeRelations")
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pokemon");

                    b.Navigation("type");
                });

            modelBuilder.Entity("PokemonProject.Models.Pokemon", b =>
                {
                    b.Navigation("pokemonStatRelations");

                    b.Navigation("pokemonTrainerRelations");

                    b.Navigation("pokemonTypeRelations");
                });

            modelBuilder.Entity("PokemonProject.Models.Stat", b =>
                {
                    b.Navigation("pokemonStatRelations");
                });

            modelBuilder.Entity("PokemonProject.Models.Trainer", b =>
                {
                    b.Navigation("pokemonTrainerRelations");
                });

            modelBuilder.Entity("PokemonProject.Models.Type", b =>
                {
                    b.Navigation("pokemonTypeRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
