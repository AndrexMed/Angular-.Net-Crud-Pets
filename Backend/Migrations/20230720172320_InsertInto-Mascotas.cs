using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InsertIntoMascotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.InsertData(
                table: "Mascotas",
                columns: new[] { "IdMascota", "Color", "Edad", "FechaCreacion", "Nombre", "Peso", "Raza" },
                values: new object[,]
                {
                    { 3, "Amarillo", 5, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2820), "Doggo", 25f, "Labrador Retriever" },
                    { 4, "Dorado", 7, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2822), "Bella", 22f, "Golden Retriever" },
                    { 5, "Negro y Marrón", 4, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2823), "Rocky", 30f, "German Shepherd" },
                    { 6, "Naranja y Negro", 2, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2824), "Simba", 8f, "Bengal Cat" },
                    { 7, "Gris", 3, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2826), "Luna", 10f, "Maine Coon" },
                    { 8, "Negro", 6, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2828), "Max", 15f, "Cocker Spaniel" },
                    { 9, "Tricolor", 4, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2829), "Daisy", 18f, "Beagle" },
                    { 10, "Blanco y Marrón", 1, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2831), "Milo", 12f, "Shih Tzu" },
                    { 11, "Blanco", 5, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2832), "Whiskers", 12f, "Persian Cat" },
                    { 12, "Marrón y Blanco", 3, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2834), "Rocky", 28f, "Boxer" },
                    { 13, "Atigrado", 2, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2835), "Toby", 20f, "Bulldog Inglés" },
                    { 14, "Gris y Blanco", 4, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2837), "Luna", 25f, "Siberian Husky" },
                    { 15, "Marrón", 3, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2838), "Oliver", 10f, "Dachshund" },
                    { 16, "Gris y Blanco", 2, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2840), "Nala", 12f, "Ragdoll" },
                    { 17, "Blanco y Marrón", 5, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2841), "Jack", 15f, "Jack Russell Terrier" },
                    { 18, "Blanco", 4, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2842), "Bella", 9f, "Poodle" },
                    { 19, "Negro y Marrón", 6, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2844), "Rocky", 35f, "Rottweiler" },
                    { 20, "Blanco y Marrón", 2, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2845), "Simba", 7f, "Siamese Cat" },
                    { 21, "Marrón", 1, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2847), "Gizmo", 4f, "Chihuahua" },
                    { 22, "Blanco y Gris", 3, new DateTime(2023, 7, 20, 12, 23, 20, 779, DateTimeKind.Local).AddTicks(2848), "Luna", 9f, "Scottish Fold" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 10, 29, 11, 610, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Mascotas",
                keyColumn: "IdMascota",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 7, 20, 10, 29, 11, 610, DateTimeKind.Local).AddTicks(9421));
        }
    }
}
