namespace Dominio;
public class Pais : BaseEntity
{
    public string ? NombrePais { get; set; }
    public ICollection<Region> ? Regiones { get; set; }
}