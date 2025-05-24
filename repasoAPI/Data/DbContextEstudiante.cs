using Microsoft.EntityFrameworkCore;
using repasoAPI.Models;

namespace repasoAPI.Data;

public class DbContextEstudiante: DbContext
{
    public DbContextEstudiante(DbContextOptions<DbContextEstudiante> options) : base(options)
    {
        
    }

    public DbSet<Estudiante> Estudiantes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
    }
}