using Application.Models.ViewModels;
using Application.UseCases.AboutToDoList.Commands;
using Application.UseCases.ContactToDoList.Commands;
using Application.UseCases.EmployeeToDoList.Commands;
using Application.UseCases.LocationToDoList.Commands;
using Application.UseCases.PostToDoList.Commands;
using Application.UseCases.SectorToDoList.Commands;
using Application.UseCases.SlideToDoList.Commands;
using Application.UseCases.UsefullLinkToDoList.Commands;
using Application.UseCases.UserToDoList.Commands;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MappingProfile : Profile
    {
        private readonly EnumTranslator _translator;
        public MappingProfile()
        {
            _translator = new EnumTranslator();

            CreateMap<CreateUserCommand, User>()
                .ForMember(x => x.Photo, y => y.Ignore())
                .ForMember(x => x.PasswordHash, y => y.Ignore());
            CreateMap<CreateAboutCommand, About>().ReverseMap();
            CreateMap<CreateLocationCommand, Location>().ReverseMap();
            CreateMap<CreatePostCommand, Post>()
                .ForMember(x => x.Photo, y => y.Ignore());
            CreateMap<CreateSectorCommand, Sector>().ReverseMap();
            CreateMap<CreateSlideCommand, Slide>()
                .ForMember(x => x.Photo, y => y.Ignore());
            CreateMap<CreateUsefullLinkCommand, UsefullLink>()
                .ForMember(x => x.Photo, y => y.Ignore());
            CreateMap<CreateContactCommand, Contact>().ReverseMap();
            CreateMap<CreateEmployeeCommand, Employee>()
                .ForMember(x => x.Photo, y => y.Ignore());

            CreateMap<Enum, EnumViewModel>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Convert.ToInt32(src)))
               .ForMember(dest => dest.NameUz, opt => opt.MapFrom(src => _translator.GetEnumName(src, "Uz")))
               .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => _translator.GetEnumName(src, "En")))
               .ForMember(dest => dest.NameRu, opt => opt.MapFrom(src => _translator.GetEnumName(src, "Ru")))
               .ForMember(dest => dest.NameUzRu, opt => opt.MapFrom(src => _translator.GetEnumName(src, "UzRu")));

            CreateMap<About, AboutViewModel>().ReverseMap();
            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Location, LocationViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<Sector, SectorViewModel>().ReverseMap();
            CreateMap<Slide, SlideViewModel>().ReverseMap();
            CreateMap<UsefullLink, UsefullLinkViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
