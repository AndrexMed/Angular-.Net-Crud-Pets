using Backend.Models.Entidades;
using Backend.Models.Sedding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Backend.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base (options) { }

        public DbSet<Mascota> Mascotas => Set<Mascota>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeddingInitial.Seed(modelBuilder);

        }

        //Todos los string tienen un maximo de 100 caracteres.
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>().HaveMaxLength(100);
        }
    }
}
