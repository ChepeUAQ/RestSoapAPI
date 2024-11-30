using System.ServiceModel;
using Soap.Contracts;
using Soap.Dtos;
using Soap.Mappers;
using Soap.Repositories;


namespace Soap.Services;

public class PiezaService : IPiezaContract {
    private readonly IPiezaRepository _piezaRepository;
    public PiezaService(IPiezaRepository piezaRepository) {
        _piezaRepository = piezaRepository;
    }


    public async Task<PiezaResponseDto> GetPiezaById(Guid piezaid, CancellationToken cancellationToken) {
        var pieza = await _piezaRepository.GetByIdAsync(piezaid, cancellationToken);

        if (pieza is not null) {
            return pieza.ToDto();
        }

        throw new FaultException("Pieza not found");
    }


    public async Task<PiezaResponseDto> CreatePieza(PiezaCreateRequestDto piezaRequest, CancellationToken cancellationToken)
    {
        var pieza = piezaRequest.ToModel();
        var createdPieza = await _piezaRepository.CreateAsync(pieza, cancellationToken);
        return createdPieza.ToDto();
    }

   
}