using repasoAPI.DTOs.Request;
using repasoAPI.DTOs.Response;
using repasoAPI.Models;
using repasoAPI.Repositorio;

namespace repasoAPI.Services;

//OBJETIVO: LOGICA DE NEGOCIO PARA LA ENTIDAD ESTUDIANTE

public class EstudianteService: IEstudianteService
{
    private readonly IRepasoRepository<Estudiante> estudianteRepository;

    public EstudianteService(
        IRepasoRepository<Estudiante> estudianteRepository
    )
    {
        this.estudianteRepository = estudianteRepository ?? throw new ArgumentNullException(nameof(estudianteRepository));
    }
    
    public async Task<List<EstudianteResponse>> GetAllAsync()
    {
        var estudiantes = await estudianteRepository.GetAllAsync();
        //if
        //for
        // comparaciones
        // modificar
        var response = estudiantes.Select(e => new EstudianteResponse
        {
            Id = e.Id,
            Nombre = e.Nombre,
            Apellido = e.Apellido,
            FechaNacimiento = e.FechaNacimiento,
            Correo = e.Correo,
            Telefono = e.Telefono,
            Direccion = e.Direccion
        }).ToList();
        
        return response;
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