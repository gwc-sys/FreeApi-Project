using Microsoft.EntityFrameworkCore;
using WEB_API_8.Modols;

namespace WEB_API_8.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Additional initialization or configuration code can be added here
        }

         DbSet<Category>Categories{ get; set; }
         DbSet<Country> Countries { get; set; }
         DbSet<Owner>Owners { get; set; }
         DbSet<Pokemon> Pokemons { get; set; }
         DbSet<PokemonCategory>pokemonCategories{ get; set; }
         DbSet<PokemonOwner>PokemonOwners { get; set; }
         DbSet<Reviewes>Reviewes { get; set; }
         DbSet<Review>Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                 .HasKey(pc => new { pc.PokemonId,pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                        .HasOne(p => p.Pokemon)
                        .WithMany(pc => pc.PokemonCategories)
                        .HasForeignKey(c => c.CategoryId);
  
        }
    }

}   
