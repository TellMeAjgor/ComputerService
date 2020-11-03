using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComputerServiceModels.Models.Entities;
using ComputerServiceModels.Models.Informations;

namespace ComputerServiceMainApi.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Computer, ComputerInformation>().ReverseMap();
            CreateMap<Owner, OwnerInformation>().ReverseMap();
        }
    }
}
