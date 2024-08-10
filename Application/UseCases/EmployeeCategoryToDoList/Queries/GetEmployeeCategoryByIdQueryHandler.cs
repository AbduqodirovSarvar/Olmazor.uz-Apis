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
    public class GetEmployeeCategoryByIdQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetEmployeeCategoryByIdQuery, EmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<EmployeeCategory> Handle(GetEmployeeCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var employeeCategory = await _appDbContext.EmployeesCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                    ?? throw new Exception("Category not found");

            return employeeCategory;
        }
    }
}
