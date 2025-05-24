namespace repasoAPI.DTOs.Request;

public record EstudianteRequest()
{
    public string Nombre { get; init; } = string.Empty;
    public string Apellido { get; init; } = string.Empty;
    public DateTime FechaNacimiento { get; init; }
    public string Correo { get; init; } = string.Empty;
    public string Telefono { get; init; } = string.Empty;
    public string Direccion { get; init; } = string.Empty;
}