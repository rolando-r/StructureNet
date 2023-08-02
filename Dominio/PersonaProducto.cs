namespace Dominio;
public class PersonaProducto : BaseEntity
{
    public int IdPersona { get; set; }
    public int IdProducto { get; set; }
    public Persona ? Persona { get; set; }
    public Producto ? Producto { get; set; }
}