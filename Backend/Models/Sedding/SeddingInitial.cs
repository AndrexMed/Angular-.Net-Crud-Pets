using Backend.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Sedding
{
    public class SeddingInitial
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            var Morgan = new Mascota()
            {
                IdMascota = 1,
                Nombre = "Morgan",
                Raza = "PitBull",
                Color = "Blanco",
                Edad = 15,
                Peso = 10,
                FechaCreacion = DateTime.Now,
            };

            var Niky = new Mascota()
            {
                IdMascota = 2,
                Nombre = "Niky",
                Raza = "PitBull",
                Color = "Negra",
                Edad = 20,
                Peso = 10.5f,
                FechaCreacion = DateTime.Now,
            };

            var Doggo = new Mascota()
            {
                IdMascota = 3,
                Nombre = "Doggo",
                Raza = "Labrador Retriever",
                Color = "Amarillo",
                Edad = 5,
                Peso = 25,
                FechaCreacion = DateTime.Now,
            };

            var Bella = new Mascota()
            {
                IdMascota = 4,
                Nombre = "Bella",
                Raza = "Golden Retriever",
                Color = "Dorado",
                Edad = 7,
                Peso = 22,
                FechaCreacion = DateTime.Now,
            };

            var Rocky = new Mascota()
            {
                IdMascota = 5,
                Nombre = "Rocky",
                Raza = "German Shepherd",
                Color = "Negro y Marrón",
                Edad = 4,
                Peso = 30,
                FechaCreacion = DateTime.Now,
            };

            var Simba = new Mascota()
            {
                IdMascota = 6,
                Nombre = "Simba",
                Raza = "Bengal Cat",
                Color = "Naranja y Negro",
                Edad = 2,
                Peso = 8,
                FechaCreacion = DateTime.Now,
            };

            var Luna = new Mascota()
            {
                IdMascota = 7,
                Nombre = "Luna",
                Raza = "Maine Coon",
                Color = "Gris",
                Edad = 3,
                Peso = 10,
                FechaCreacion = DateTime.Now,
            };

            var Max = new Mascota()
            {
                IdMascota = 8,
                Nombre = "Max",
                Raza = "Cocker Spaniel",
                Color = "Negro",
                Edad = 6,
                Peso = 15,
                FechaCreacion = DateTime.Now,
            };

            var Daisy = new Mascota()
            {
                IdMascota = 9,
                Nombre = "Daisy",
                Raza = "Beagle",
                Color = "Tricolor",
                Edad = 4,
                Peso = 18,
                FechaCreacion = DateTime.Now,
            };

            var Milo = new Mascota()
            {
                IdMascota = 10,
                Nombre = "Milo",
                Raza = "Shih Tzu",
                Color = "Blanco y Marrón",
                Edad = 1,
                Peso = 12,
                FechaCreacion = DateTime.Now,
            };

            var Whiskers = new Mascota()
            {
                IdMascota = 11,
                Nombre = "Whiskers",
                Raza = "Persian Cat",
                Color = "Blanco",
                Edad = 5,
                Peso = 12,
                FechaCreacion = DateTime.Now,
            };

            var Rocky2 = new Mascota()
            {
                IdMascota = 12,
                Nombre = "Rocky",
                Raza = "Boxer",
                Color = "Marrón y Blanco",
                Edad = 3,
                Peso = 28,
                FechaCreacion = DateTime.Now,
            };

            var Toby = new Mascota()
            {
                IdMascota = 13,
                Nombre = "Toby",
                Raza = "Bulldog Inglés",
                Color = "Atigrado",
                Edad = 2,
                Peso = 20,
                FechaCreacion = DateTime.Now,
            };

            var Luna2 = new Mascota()
            {
                IdMascota = 14,
                Nombre = "Luna",
                Raza = "Siberian Husky",
                Color = "Gris y Blanco",
                Edad = 4,
                Peso = 25,
                FechaCreacion = DateTime.Now,
            };

            var Oliver = new Mascota()
            {
                IdMascota = 15,
                Nombre = "Oliver",
                Raza = "Dachshund",
                Color = "Marrón",
                Edad = 3,
                Peso = 10,
                FechaCreacion = DateTime.Now,
            };

            var Nala = new Mascota()
            {
                IdMascota = 16,
                Nombre = "Nala",
                Raza = "Ragdoll",
                Color = "Gris y Blanco",
                Edad = 2,
                Peso = 12,
                FechaCreacion = DateTime.Now,
            };

            var Jack = new Mascota()
            {
                IdMascota = 17,
                Nombre = "Jack",
                Raza = "Jack Russell Terrier",
                Color = "Blanco y Marrón",
                Edad = 5,
                Peso = 15,
                FechaCreacion = DateTime.Now,
            };

            var Bella2 = new Mascota()
            {
                IdMascota = 18,
                Nombre = "Bella",
                Raza = "Poodle",
                Color = "Blanco",
                Edad = 4,
                Peso = 9,
                FechaCreacion = DateTime.Now,
            };

            var Rocky3 = new Mascota()
            {
                IdMascota = 19,
                Nombre = "Rocky",
                Raza = "Rottweiler",
                Color = "Negro y Marrón",
                Edad = 6,
                Peso = 35,
                FechaCreacion = DateTime.Now,
            };

            var Simba2 = new Mascota()
            {
                IdMascota = 20,
                Nombre = "Simba",
                Raza = "Siamese Cat",
                Color = "Blanco y Marrón",
                Edad = 2,
                Peso = 7,
                FechaCreacion = DateTime.Now,
            };

            var Gizmo = new Mascota()
            {
                IdMascota = 21,
                Nombre = "Gizmo",
                Raza = "Chihuahua",
                Color = "Marrón",
                Edad = 1,
                Peso = 4,
                FechaCreacion = DateTime.Now,
            };

            var Luna3 = new Mascota()
            {
                IdMascota = 22,
                Nombre = "Luna",
                Raza = "Scottish Fold",
                Color = "Blanco y Gris",
                Edad = 3,
                Peso = 9,
                FechaCreacion = DateTime.Now,
            };

            modelBuilder.Entity<Mascota>().HasData(Morgan, Niky, Doggo, Bella, Rocky, Simba, Luna, Max, Daisy, Milo, Whiskers, Rocky2, Toby, Luna2, Oliver, Nala, Jack, Bella2, Rocky3, Simba2, Gizmo, Luna3);


        }
    }

}
