using Backend.Migrations;
using Backend.Models.Entidades;

namespace Backend.Models.Repository
{
    public interface IMascotaRepository
    {
        Task<List<Mascota>> GetListMascotas();
        Task<Mascota> GetMascota(int id);
        Task DeleteMascota(Mascota mascotaToDelete);
        Task<Mascota> AddMascota(Mascota mascota);
        Task UpdateMascota(Mascota mascota);
    }
}
