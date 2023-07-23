using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Raza = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.IdMascota);
                });

            migrationBuilder.InsertData(
                table: "Mascotas",
                columns: new[] { "IdMascota", "Color", "Edad", "FechaCreacion", "Peso", "Raza" },
                values: new object[,]
                {
                    { 1, "Blanco", 15, new DateTime(2023, 7, 20, 9, 40, 10, 644, DateTimeKind.Local).AddTicks(2071), 10f, "PitBull" },
                    { 2, "Negra", 20, new DateTime(2023, 7, 20, 9, 40, 10, 644, DateTimeKind.Local).AddTicks(2084), 10.5f, "PitBull" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascotas");
        }
    }
}
