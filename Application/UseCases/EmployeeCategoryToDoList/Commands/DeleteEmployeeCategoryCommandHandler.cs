using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeCategoryToDoList.Commands
{
    public class DeleteEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteEmployeeCategoryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var employeeCategory = await _appDbContext.EmployeesCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                ?? throw new Exception("Category not found");

            _appDbContext.EmployeesCategories.Remove(employeeCategory);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
