using Application.Models.ViewModels;
using Application.UseCases.UserToDoList.Commands;
using AutoMapper;
using Domain.Entities;
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

            CreateMap<CreateUserCommand, User>()
                .ForMember(x => x.Photo, y => y.Ignore())
                .ForMember(x => x.PasswordHash, y => y.Ignore());

        }
    }
}
