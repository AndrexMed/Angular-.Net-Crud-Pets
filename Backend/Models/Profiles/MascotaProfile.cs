using AutoMapper;
using Backend.Models.DTOs;
using Backend.Models.Entidades;

namespace Backend.Models.Profiles
{
    public class MascotaProfile : Profile
    {
        public MascotaProfile() 
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
        }
    }
}
