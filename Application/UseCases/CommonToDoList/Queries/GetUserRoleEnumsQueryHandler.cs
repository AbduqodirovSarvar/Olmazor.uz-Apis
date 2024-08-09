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
    public class GetUserRoleEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetUserRoleEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;
        public Task<List<EnumViewModel>> Handle(GetUserRoleEnumsQuery request, CancellationToken cancellationToken)
        {
            var userRoleEnums = Enum.GetValues(typeof(UserRole)).Cast<UserRole>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(userRoleEnums));
        }
    }
}
