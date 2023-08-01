using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombrePersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.ApellidoPersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.EdadPersona)
        .IsRequired()
        .HasColumnType("int");

        builder.HasOne(p => p.Provincia)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdCod);

        builder.HasOne(p => p.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdCod);
    }
}