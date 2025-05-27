using Microsoft.EntityFrameworkCore;
using repasoAPI.Data.Configurations;
using repasoAPI.Data.Seeders;
using repasoAPI.Models;

namespace repasoAPI.Data;

public class DbContextEstudiante: DbContext
{
    public DbContextEstudiante(DbContextOptions<DbContextEstudiante> options) : base(options)
    {
        
    }
    // DbSets para las entidades
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Materia> Materias { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de las entidades
        new EstudiantesConfiguration().Configure(modelBuilder.Entity<Estudiante>());
        new MateriasConfiguration().Configure(modelBuilder.Entity<Materia>());
        
        // Seeders para inicializar datos
        new EstudiantesSeeders().Configure(modelBuilder.Entity<Estudiante>());
    }
    
}