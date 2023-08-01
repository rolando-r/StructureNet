namespace Dominio;
public class Pais : BaseEntityA
{
    public string ? NombrePais { get; set; }
    public ICollection<Region> ? Regiones { get; set; }
}