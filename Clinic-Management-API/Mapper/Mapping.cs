using AutoMapper;
using Clinic_Management_API.Models;
using Clinic_Management_API.Models.DTOs;

namespace Clinic_Management_API.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AppUser, AppUserDTOs>().ReverseMap();
            CreateMap<CheckUp, CheckUpDTOs>().ReverseMap();
            CreateMap<Equipment, EquipmentDTOs>().ReverseMap();
            CreateMap<Treatment, TreatmentDTOs>().ReverseMap();
        }
    }
}