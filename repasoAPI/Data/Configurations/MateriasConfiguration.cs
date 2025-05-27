using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repasoAPI.Models;

namespace repasoAPI.Data.Configurations;

public class MateriasConfiguration: IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.ToTable("Materias");
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Nombre)
            .IsRequired()
            .HasMaxLength(100);
    }
}