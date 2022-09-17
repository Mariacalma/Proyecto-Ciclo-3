using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pypSln.persistencia.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historiaClinica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_registro = table.Column<int>(type: "int", nullable: false),
                    Id_propietario = table.Column<int>(type: "int", nullable: false),
                    Id_ovino = table.Column<int>(type: "int", nullable: false),
                    Id_veterinario = table.Column<int>(type: "int", nullable: false),
                    Fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historiaClinica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ovino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ovino", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registroHistoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_propietario = table.Column<int>(type: "int", nullable: false),
                    Id_ovino = table.Column<int>(type: "int", nullable: false),
                    Id_veterinario = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registroHistoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "visitapyp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_ovino = table.Column<int>(type: "int", nullable: false),
                    Id_propietario = table.Column<int>(type: "int", nullable: false),
                    Id_veterinario = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    Fre_respiratoria = table.Column<double>(type: "float", nullable: false),
                    Fre_cardiaca = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    formula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitapyp", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historiaClinica");

            migrationBuilder.DropTable(
                name: "ovino");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "registroHistoria");

            migrationBuilder.DropTable(
                name: "visitapyp");
        }
    }
}
