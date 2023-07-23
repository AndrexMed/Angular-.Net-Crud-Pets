using Backend.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Models.Configurations
{
    public class MascotaConfig : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.HasKey(p => p.IdMascota);
            builder.Property(p => p.Nombre);
            builder.Property(p => p.Raza);
            builder.Property(p => p.Color);
            builder.Property(p => p.Edad);
            builder.Property(p => p.Peso);
            builder.Property(p => p.FechaCreacion).HasColumnType("date");
           
        }
    }
}
