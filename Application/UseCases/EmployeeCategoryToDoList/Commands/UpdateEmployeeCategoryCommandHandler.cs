using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeCategoryToDoList.Commands
{
    public class UpdateEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateEmployeeCategoryCommand, EmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<EmployeeCategory> Handle(UpdateEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var employeeCategory = await _appDbContext.EmployeesCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                ?? throw new Exception("Category not found");

            employeeCategory.NameEn = request.NameEn ?? employeeCategory.NameEn;
            employeeCategory.NameRu = request.NameRu ?? employeeCategory.NameRu;
            employeeCategory.NameUz = request.NameUz ?? employeeCategory.NameUz;
            employeeCategory.NameUzRu = request.NameUzRu ?? employeeCategory.NameUzRu;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return employeeCategory;
        }
    }
}
