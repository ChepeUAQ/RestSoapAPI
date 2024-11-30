using Soap.Models;

namespace Soap.Repositories;

public interface IPiezaRepository {
    public Task<PiezaModel> GetByIdAsync(Guid piezaid, CancellationToken cancellationToken);
    public Task<PiezaModel>CreateAsync(PiezaModel pieza, CancellationToken cancellationToken);
  
}