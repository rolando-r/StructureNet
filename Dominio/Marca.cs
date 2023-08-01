namespace Dominio;
public class Marca : BaseEntityA
{
    public string ? DescripcionMarca { get; set; }
    public ICollection<Producto> ? Productos { get; set; }
}