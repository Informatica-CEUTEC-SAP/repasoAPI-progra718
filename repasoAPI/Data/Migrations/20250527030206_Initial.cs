using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repasoAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Correo = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "Apellido", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { new Guid("0c48d132-fb36-4732-8874-8dc523b46f57"), "", "", "", new DateTime(1999, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis Fernández", "" },
                    { new Guid("807ddb1f-2d0a-4ace-b358-6ff177133672"), "", "", "", new DateTime(1982, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "María López", "" },
                    { new Guid("e6717d93-e98d-4b08-9c18-231c651d2429"), "", "", "", new DateTime(1982, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan Pérez", "" },
                    { new Guid("f2d8f7e4-62d0-4fbb-a3db-af69c3224584"), "", "", "", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana Gómez", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
