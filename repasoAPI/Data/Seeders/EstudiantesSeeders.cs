using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repasoAPI.Models;

namespace repasoAPI.Data.Seeders;

public class EstudiantesSeeders: IEntityTypeConfiguration<Estudiante>
{
    public void Configure(EntityTypeBuilder<Estudiante> builder)
    {
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            builder.HasData(    
                new Estudiante
                    { Id = Guid.NewGuid(), Nombre = "Juan Pérez", FechaNacimiento = new DateTime(1982, 3, 25) },
                new Estudiante
                    { Id = Guid.NewGuid(), Nombre = "Ana Gómez", FechaNacimiento = new DateTime(2020, 1, 11) },
                new Estudiante
                    { Id = Guid.NewGuid(), Nombre = "Luis Fernández", FechaNacimiento = new DateTime(1999, 4, 12) },
                new Estudiante
                    { Id = Guid.NewGuid(), Nombre = "María López", FechaNacimiento = new DateTime(1982, 5, 13) }
            );
        }
    }
}