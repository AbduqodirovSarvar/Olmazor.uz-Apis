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
    public class GetWeekDaysEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetWeekDaysEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;

        public Task<List<EnumViewModel>> Handle(GetWeekDaysEnumsQuery request, CancellationToken cancellationToken)
        {
            var weekDays = Enum.GetValues(typeof(WeekDays)).Cast<WeekDays>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(weekDays));
        }
    }
}
