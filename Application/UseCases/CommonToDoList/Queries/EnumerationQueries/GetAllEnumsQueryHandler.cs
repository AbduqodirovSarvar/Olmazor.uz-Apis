using Application.Models.ViewModels;
using AutoMapper;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries.EnumerationQueries
{
    public class GetAllEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetAllEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;

        public Task<List<EnumViewModel>> Handle(GetAllEnumsQuery request, CancellationToken cancellationToken)
        {
            var genderEnums = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            var userRoleEnums = Enum.GetValues(typeof(UserRole)).Cast<UserRole>();
            var contactTypes = Enum.GetValues(typeof(ContactType)).Cast<ContactType>();
            var employeeCategories = Enum.GetValues(typeof(EmployeeCategory)).Cast<EmployeeCategory>();
            var postCategories = Enum.GetValues(typeof(PostCategory)).Cast<PostCategory>();
            var weekDays = Enum.GetValues(typeof(WeekDays)).Cast<WeekDays>();

            var enumViewModels = new List<EnumViewModel>();

            enumViewModels.AddRange(genderEnums.Select(g => _mapper.Map<EnumViewModel>(g)));
            enumViewModels.AddRange(userRoleEnums.Select(ur => _mapper.Map<EnumViewModel>(ur)));
            enumViewModels.AddRange(contactTypes.Select(ct => _mapper.Map<EnumViewModel>(ct)));
            enumViewModels.AddRange(employeeCategories.Select(ec =>  _mapper.Map<EnumViewModel>(ec)));
            enumViewModels.AddRange(postCategories.Select(pc => _mapper.Map<EnumViewModel>(pc)));
            enumViewModels.AddRange(weekDays.Select(wd =>  _mapper.Map<EnumViewModel>(wd)));

            return Task.FromResult(enumViewModels);
        }
    }
}
