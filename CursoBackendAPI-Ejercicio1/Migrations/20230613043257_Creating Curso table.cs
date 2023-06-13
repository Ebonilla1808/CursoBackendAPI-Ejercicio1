using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoBackendAPI_Ejercicio1.Migrations
{
    /// <inheritdoc />
    public partial class CreatingCursotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    DescripcionCorta = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    DescripcionLarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicoObjetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requisitos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
