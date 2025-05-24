using repasoAPI.DTOs.Request;
using repasoAPI.DTOs.Response;

namespace repasoAPI.Services;

public interface IEstudianteService
{
    //CRUD
    Task<List<EstudianteResponse>> GetAllAsync();
    Task<EstudianteResponse> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(EstudianteRequest request);
    Task UpdateAsync(EstudianteRequest request);
    Task DeleteAsync(Guid id);
    Task<List<EstudiantesBirthdaysResponse>> GetEstudiantesBirthdaysAsync(int mes);
}