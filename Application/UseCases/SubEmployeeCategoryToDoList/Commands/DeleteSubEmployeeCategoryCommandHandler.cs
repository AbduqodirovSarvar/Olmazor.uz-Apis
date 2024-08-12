using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SubEmployeeCategoryToDoList.Commands
{
    public class DeleteSubEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteSubEmployeeCategoryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteSubEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var subEmployeeCategory = await _appDbContext.SubEmployeeCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                               ?? throw new Exception("Sub Employee Category not found");

            _appDbContext.SubEmployeeCategories.Remove(subEmployeeCategory);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
