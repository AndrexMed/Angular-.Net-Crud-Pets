namespace Backend.Models.DTOs
{
    public class MascotaDTO
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; } = null!;
        public string Raza { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Edad { get; set; }
        public float Peso { get; set; }
    }
}
