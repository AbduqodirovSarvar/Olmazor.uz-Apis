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
    public class GetContactTypeEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetContactTypeEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;
        public Task<List<EnumViewModel>> Handle(GetContactTypeEnumsQuery request, CancellationToken cancellationToken)
        {
            var contactTypes = Enum.GetValues(typeof(ContactType)).Cast<ContactType>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(contactTypes));
        }
    }
}
