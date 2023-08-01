using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class StructureNetContext : DbContext
    {
        public StructureNetContext(DbContextOptions<StructureNetContext> options) : base(options)
        {
        }

        public DbSet<Marca> ? Marcas { get; set; }
        public DbSet<Pais> ? Paises { get; set; } 
        public DbSet<Region> ? Regiones { get; set; }
        public DbSet<Provincia> ? Provincias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> ? Productos { get; set; }
        public DbSet<TipoPersona> ? TipoPersonas { get; set; }
        public DbSet<PersonaProducto> ? ProductosPersonas { get; set; }
             
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonaProducto>().HasKey(p => new { p.IdPersona, p.IdProducto} );
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }      
}