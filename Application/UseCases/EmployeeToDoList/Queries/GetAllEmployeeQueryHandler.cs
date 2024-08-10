using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Queries
{
    public class GetAllEmployeeQueryHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetAllEmployeeQuery, List<EmployeeViewModel>>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<EmployeeViewModel>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employees = await _appDbContext.Employees.ToListAsync(cancellationToken);
            return _mapper.Map<List<EmployeeViewModel>>(employees);
        }
    }
}
