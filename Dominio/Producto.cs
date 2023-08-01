namespace Dominio;
public class Producto : BaseEntityA
{
    public string ? RefProducto { get; set; }
    public string ? DescripcionProducto { get; set; }
    public int PrecioProducto { get; set; }
    public int DctoProducto { get; set; }
    public int IdMarca { get; set; }
    public Marca ? Marca { get; set; }
    public ICollection<PersonaProducto> ? PersonaProductos { get; set; }
}