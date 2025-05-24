using repasoAPI.DTOs.Request;
using repasoAPI.DTOs.Response;

namespace repasoAPI.Services;

public class EstudianteService: IEstudianteService
{
    public async Task<List<EstudianteResponse>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<EstudianteResponse> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> CreateAsync(EstudianteRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(EstudianteRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<EstudiantesBirthdaysResponse>> GetEstudiantesBirthdaysAsync(int mes)
    {
        throw new NotImplementedException();
    }
}