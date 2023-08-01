namespace Dominio;
public class Region : BaseEntityA
{
    public string ? NombreRegion { get; set; }
    public int ? IdPais { get; set; }
    public Pais ? Pais { get; set; }
    public ICollection<Provincia> ? Provincias { get; set; }
}