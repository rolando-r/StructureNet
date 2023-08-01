namespace Dominio;
public class TipoPersona : BaseEntityA
{
    public string ? Descripcion { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}