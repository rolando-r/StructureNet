using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.RefProducto)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.DescripcionProducto)
        .IsRequired()
        .HasMaxLength(250);

        builder.Property(p => p.PrecioProducto)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.DctoProducto)
        .IsRequired()
        .HasColumnType("int");

        builder.HasOne(p => p.Marca)
        .WithMany(e => e.Productos)
        .HasForeignKey(i => i.IdCod);
    }
}