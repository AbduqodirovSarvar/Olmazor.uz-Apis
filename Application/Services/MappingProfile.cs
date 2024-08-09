using Application.Models.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Enum, EnumViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Convert.ToInt32(src)))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(z => z.ToString()));
        }
    }
}
