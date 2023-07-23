using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableAddColumnNombre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Mascotas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Nombre" },
                values: new object[] { new DateTime(2023, 7, 20, 10, 29, 11, 610, DateTimeKind.Local).AddTicks(9408), "Morgan" });

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "Nombre" },
                values: new object[] { new DateTime(2023, 7, 20, 10, 29, 11, 610, DateTimeKind.Local).AddTicks(9421), "Niky" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Mascotas");

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 9, 40, 10, 644, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 9, 40, 10, 644, DateTimeKind.Local).AddTicks(2084));
        }
    }
}
