using System.ServiceModel;
using Soap.Dtos;

namespace Soap.Contracts;

[ServiceContract]
public interface IPiezaContract {
    [OperationContract]
    public Task<PiezaResponseDto> GetPiezaById(Guid id, CancellationToken cancellationToken);

    [OperationContract]
    public Task<PiezaResponseDto>CreatePieza(PiezaCreateRequestDto pieza, CancellationToken cancellationToken);
   
}