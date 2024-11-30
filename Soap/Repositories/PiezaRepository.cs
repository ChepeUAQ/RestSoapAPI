using Microsoft.EntityFrameworkCore;
using Soap.Infraestructure;
using Soap.Models;
using Soap.Mappers;


namespace Soap.Repositories;

public class PiezaRepository : IPiezaRepository {
    private readonly RelationalDbContext _dbContext;
    public PiezaRepository(RelationalDbContext dbContext) {
        _dbContext = dbContext;
    }public async Task<PiezaModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
{
    var pieza = await _dbContext.piezas
        .AsNoTracking()
        .FirstOrDefaultAsync(s => s.id.Equals(id), cancellationToken);

    if (pieza == null)
    {
        Console.WriteLine($"Pieza con ID {id} no encontrada"); 
        throw new KeyNotFoundException($"Pieza con ID {id} no encontrada");
    }

    return pieza.ToModel();
}




   public async Task<PiezaModel> CreateAsync(PiezaModel pieza, CancellationToken cancellationToken)
    {
        var piezaEntity = pieza.ToEntity();
        piezaEntity.id = Guid.NewGuid();
        
        await _dbContext.AddAsync(piezaEntity, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return piezaEntity.ToModel();
    }

}