using Microsoft.EntityFrameworkCore;
using Soap.Infraestructure.Entities;

namespace Soap.Infraestructure;

public class RelationalDbContext : DbContext {
    public RelationalDbContext(DbContextOptions<RelationalDbContext> options) : base(options) {

    }

    public DbSet<PiezaEntity> piezas {get; set;}

    internal object Where(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }

}