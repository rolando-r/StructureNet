namespace Dominio;
public class Provincia : BaseEntity
{
    public string ? NombreProvincia { get; set; }
    public int IdReg { get; set; }
    public Region ? Region { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}