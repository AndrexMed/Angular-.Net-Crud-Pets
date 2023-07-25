using Backend.Models.Data;
using Backend.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Repository
{
    public class MascotaRepository : IMascotaRepository
    {
        private readonly AppDbContext _appDbContext;

        public MascotaRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<Mascota> AddMascota(Mascota mascota)
        {
            _appDbContext.Add(mascota);
            await _appDbContext.SaveChangesAsync();

            return mascota;
        }

        public async Task DeleteMascota(Mascota mascotaToDelete)
        {
            _appDbContext.Remove(mascotaToDelete);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Mascota>> GetListMascotas()
        {
            return await _appDbContext.Mascotas.ToListAsync();
        }

        public async Task<Mascota> GetMascota(int id)
        {
            var mascota = await _appDbContext.Mascotas.FindAsync(id);

            return mascota;
        }

        public async Task UpdateMascota(Mascota mascota)
        {
            var mascotaToUpdate = await _appDbContext.Mascotas.FirstOrDefaultAsync(p => p.IdMascota == mascota.IdMascota);

            if (mascotaToUpdate != null)
            {
                mascotaToUpdate.Nombre = mascota.Nombre;
                mascotaToUpdate.Edad = mascota.Edad;
                mascotaToUpdate.Raza = mascota.Raza;
                mascotaToUpdate.Color = mascota.Color;
                mascotaToUpdate.Peso = mascota.Peso;
            }

            await _appDbContext.SaveChangesAsync();
        }
    }
}