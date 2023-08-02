using System.Linq.Expressions;
using Dominio;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly StructureNetContext _context;

    public PaisRepository(StructureNetContext context) : base (context)
    {
        this._context = context;
    }
    
}
