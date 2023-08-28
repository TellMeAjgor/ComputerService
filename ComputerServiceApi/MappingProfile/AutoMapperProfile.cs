using AutoMapper;
using ComputerServiceModels.Models.Entities;
using ComputerServiceModels.Models.Informations;

namespace ComputerService.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserInformation>().ReverseMap();
        }  
    }
}
