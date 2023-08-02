using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marcas");

        builder.HasKey(p => p.IdMarca);
        builder.Property(p => p.IdMarca)
        .ValueGeneratedNever();
        
        builder.Property(p => p.DescripcionMarca)
        .IsRequired()
        .HasMaxLength(250);
    }
}