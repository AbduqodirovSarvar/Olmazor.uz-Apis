using Application.Abstractions;
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
    public class GetEmployeeCategoryEnumsQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetEmployeeCategoryEnumsQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;

        public Task<List<EnumViewModel>> Handle(GetEmployeeCategoryEnumsQuery request, CancellationToken cancellationToken)
        {
            var employeeCategories = Enum.GetValues(typeof(EmployeeCategory)).Cast<EmployeeCategory>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(employeeCategories));
        }
    }
}
