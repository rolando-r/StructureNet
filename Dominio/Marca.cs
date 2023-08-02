namespace Dominio;
public class Marca
{
    public int IdMarca { get; set; }
    public string ? DescripcionMarca { get; set; }
    public ICollection<Producto> ? Productos { get; set; }
}