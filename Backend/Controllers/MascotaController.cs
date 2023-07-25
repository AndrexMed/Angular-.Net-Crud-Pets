using AutoMapper;
using Backend.Models.DTOs;
using Backend.Models.Entidades;
using Backend.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaRepository _mascotaRepository;
        private readonly IMapper _mapper;

        public MascotaController(IMapper mapper,
                                 IMascotaRepository mascotaRepository) 
        {
            this._mascotaRepository = mascotaRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMascotas()
        {   
            try
            {
                //Thread.Sleep(3000);
                var Mascotas = await _mascotaRepository.GetListMascotas();

                var mascotasDTO = _mapper.Map<IEnumerable<MascotaDTO>>(Mascotas); // Como devuelve un array agregamos el IEnumerable

                return Ok(mascotasDTO);
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
                var mascotaToSearch = await _mascotaRepository.GetMascota(id);

                if ( mascotaToSearch is null)
                {
                    return NotFound();
                }

                var mascotaDTO = _mapper.Map<MascotaDTO>(mascotaToSearch);

                return Ok(mascotaDTO);
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
                var mascotaToDelete = await _mascotaRepository.GetMascota(id);

                if (mascotaToDelete is null)
                {
                    return NotFound();
                }

                await _mascotaRepository.DeleteMascota(mascotaToDelete);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostMascota(MascotaDTO mascotaDTO)
        {
            try
            {
                var mascota = _mapper.Map<Mascota>(mascotaDTO);

                mascota.FechaCreacion = DateTime.Now;

                mascota = await _mascotaRepository.AddMascota(mascota);

                var mascotaItemDTO = _mapper.Map<MascotaDTO>(mascota);

                return CreatedAtAction("GetMascotaPorId", new { id = mascotaItemDTO.IdMascota }, mascotaItemDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMascota(int id,  MascotaDTO mascotaDTO)
        {
            //try
            //{
            //    if (id != mascota.IdMascota)
            //    {
            //        return BadRequest();
            //    }    

            //    var mascotaToUpdate = await _appDbContext.Mascotas.FindAsync(id);

            //    if (mascotaToUpdate == null) {  return NotFound(); }

            //    mascotaToUpdate.Nombre = mascota.Nombre;
            //    mascotaToUpdate.Edad = mascota.Edad;
            //    mascotaToUpdate.Raza = mascota.Raza;
            //    mascotaToUpdate.Color = mascota.Color;
            //    mascotaToUpdate.Peso = mascota.Peso;

            //    await _appDbContext.SaveChangesAsync();

            //    return NoContent();
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
            try
            {
                var mascota = _mapper.Map<Mascota>(mascotaDTO);

                if (id != mascota.IdMascota)
                {
                    return BadRequest();
                }

                var mascotaToUpdate = await _mascotaRepository.GetMascota(id);

                if (mascotaToUpdate is null)
                {
                    return NotFound();
                }

                await _mascotaRepository.UpdateMascota(mascota);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
