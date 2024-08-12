using Application.Models.ViewModels;
using Application.UseCases.AboutToDoList.Commands;
using Application.UseCases.ContactToDoList.Commands;
using Application.UseCases.EmployeeCategoryToDoList.Commands;
using Application.UseCases.EmployeeToDoList.Commands;
using Application.UseCases.JobFairToDoList.Commands;
using Application.UseCases.LocationToDoList.Commands;
using Application.UseCases.PostCategoryToDoList.Commands;
using Application.UseCases.PostToDoList.Commands;
using Application.UseCases.SectorToDoList.Commands;
using Application.UseCases.SlideToDoList.Commands;
using Application.UseCases.SubEmployeeCategoryToDoList.Commands;
using Application.UseCases.TasksAndFunctionsToDoList.Commands;
using Application.UseCases.UsefullLinkToDoList.Commands;
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

            CreateMap<CreateAboutCommand, About>().ReverseMap();
            CreateMap<About, AboutViewModel>().ReverseMap();
            CreateMap<CreateContactCommand, Contact>().ReverseMap();
            CreateMap<CreateEmployeeCategoryCommand, EmployeeCategory>().ReverseMap();
            CreateMap<CreateEmployeeCommand, Employee>()
                .ForMember(x => x.Photo, y => y.Ignore());
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();

            CreateMap<CreateJobFairCommand, JobFair>().ReverseMap();

            CreateMap<CreateLocationCommand, Location>().ReverseMap();

            CreateMap<CreatePostCategoryCommand, PostCategory>().ReverseMap();

            CreateMap<CreatePostCommand, Post>()
                .ForMember(x => x.Photo, y => y.Ignore());

            CreateMap<CreateSectorCommand, Sector>().ReverseMap();

            CreateMap<CreateSlideCommand, Slide>()
                .ForMember(x => x.Photo, y => y.Ignore());

            CreateMap<CreateSubEmployeeCategoryCommand, SubEmployeeCategory>().ReverseMap();

            CreateMap<CreateTasksAndFunctionsCommand, TaskOrFunction>().ReverseMap();

            CreateMap<CreateUsefullLinkCommand, UsefulLink>()
                .ForMember(x => x.Photo, y => y.Ignore());
        }
    }
}
