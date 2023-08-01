namespace Dominio;
public class Persona : BaseEntityA
{
    public string ? NombrePersona { get; set; }
    public string ? ApellidoPersona { get; set; }
    public int EdadPersona { get; set; }
    public int IdProvincia { get; set; }
    public Provincia ? Provincia { get; set; }
    public int IdTipoPer { get; set; }
    public TipoPersona ? TipoPersona { get; set; }
    public ICollection<PersonaProducto> ? PersonaProductos {get; set; }
}