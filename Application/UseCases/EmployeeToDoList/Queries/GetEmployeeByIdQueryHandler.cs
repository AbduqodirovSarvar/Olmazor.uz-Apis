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
    public class GetEmployeeByIdQueryHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetEmployeeByIdQuery, EmployeeViewModel>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<EmployeeViewModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Employee not found");
            return _mapper.Map<EmployeeViewModel>(employee);
        }
    }
}
