using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeCategoryToDoList.Queries
{
    public class GetAllEmployeeCategoryQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllEmployeeCategoryQuery, List<EmployeeCategory>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public Task<List<EmployeeCategory>> Handle(GetAllEmployeeCategoryQuery request, CancellationToken cancellationToken)
        {
            var employeeCategries = _appDbContext.EmployeesCategories.ToListAsync(cancellationToken);
            return employeeCategries;
        }
    }
}
