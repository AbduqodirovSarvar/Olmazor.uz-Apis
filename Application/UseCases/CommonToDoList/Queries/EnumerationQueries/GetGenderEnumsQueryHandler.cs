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
    public class GetGenderEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetGenderEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;
        public Task<List<EnumViewModel>> Handle(GetGenderEnumsQuery request, CancellationToken cancellationToken)
        {
            var genderEnums = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(genderEnums));
        }
    }
}
