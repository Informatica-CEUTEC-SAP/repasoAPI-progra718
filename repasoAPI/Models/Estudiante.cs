namespace repasoAPI.Models;

public class Estudiante
{
    public Guid Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Correo { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
}

// Class
// getters and setters
// get Obtener el valor de una propiedad
// set Establecer el valor de una propiedad

// Record -> ser recomienda para los DTOs
// get
// init Establecer el valor de una propiedad solo al momento de la inicialización(una unica vez)

// HTTP -> request del usuario -> una unica vez se establece el valor