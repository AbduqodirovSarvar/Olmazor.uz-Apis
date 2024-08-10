using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeCategoryToDoList.Commands
{
    public class CreateEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper 
        ) : IRequestHandler<CreateEmployeeCategoryCommand, EmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<EmployeeCategory> Handle(CreateEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var employeeCategory = _mapper.Map<EmployeeCategory>(request);

            await _appDbContext.EmployeesCategories.AddAsync(employeeCategory, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return employeeCategory;
        }
    }
}
