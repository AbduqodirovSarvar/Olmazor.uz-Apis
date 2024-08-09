using Application.Models.ViewModels;
using AutoMapper;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries
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

            var enumViewModels = new List<EnumViewModel>();

            enumViewModels.AddRange(genderEnums.Select(g => _mapper.Map<EnumViewModel>(g)));
            enumViewModels.AddRange(userRoleEnums.Select(ur => _mapper.Map<EnumViewModel>(ur)));

            return Task.FromResult(enumViewModels);
        }
    }
}
