using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaProductoConfiguration : IEntityTypeConfiguration<PersonaProducto>
{
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        builder.ToTable("PersonaProductos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.HasOne(p => p.Persona)
        .WithMany(e => e.PersonaProductos)
        .HasForeignKey(i => i.IdCod);

        builder.HasOne(p => p.Producto)
        .WithMany(e => e.PersonaProductos)
        .HasForeignKey(i => i.IdCod);
    }
}