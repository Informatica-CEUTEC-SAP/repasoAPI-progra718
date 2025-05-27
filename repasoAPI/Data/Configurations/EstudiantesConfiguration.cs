using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repasoAPI.Models;

namespace repasoAPI.Data.Configurations;

public class EstudiantesConfiguration: IEntityTypeConfiguration<Estudiante>
{
    public void Configure(EntityTypeBuilder<Estudiante> builder)
    {
        builder.ToTable("Estudiantes");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Nombre).HasMaxLength(250).IsRequired();
        builder.Property(e => e.FechaNacimiento)
            .IsRequired()
            .HasColumnType("date");
    }
}