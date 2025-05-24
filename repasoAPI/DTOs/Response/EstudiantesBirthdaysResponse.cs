namespace repasoAPI.DTOs.Response;

public record EstudiantesBirthdaysResponse()
{
    public Guid Id { get; init; }
    public string FullName { get; init; } = string.Empty;
    public DateTime FechaBirthday { get; init; }
}