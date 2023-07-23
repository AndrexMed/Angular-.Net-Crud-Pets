using Backend.Models.Data;
using Backend.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public MascotaController(AppDbContext appDbContext) 
        {
            this._appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetMascotas()
        {   
            try
            {
                //Thread.Sleep(3000);
                var Mascotas = await _appDbContext.Mascotas.ToListAsync();

                return Ok(Mascotas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMascotaPorId(int id)
        {
            try
            {
                //Thread.Sleep(2000);
                var mascotaToSearch = await _appDbContext.Mascotas.FindAsync(id);

                if ( mascotaToSearch is null)
                {
                    return NotFound();
                }

                return Ok(mascotaToSearch);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMascotaPorId(int id)
        {
            try
            {
                var mascotaToDelete = await _appDbContext.Mascotas.FindAsync(id);

                if (mascotaToDelete is null)
                {
                    return NotFound();
                }

                _appDbContext.Remove(mascotaToDelete);
                await _appDbContext.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostMascota(Mascota mascota)
        {
            try
            {
                mascota.FechaCreacion = DateTime.Now;

                _appDbContext.Add(mascota);
                await _appDbContext.SaveChangesAsync();

                return CreatedAtAction("GetMascotaPorId", new { id = mascota.IdMascota }, mascota);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
