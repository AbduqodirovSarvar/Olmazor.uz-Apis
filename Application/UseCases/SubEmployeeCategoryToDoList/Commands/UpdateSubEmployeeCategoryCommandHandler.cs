using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SubEmployeeCategoryToDoList.Commands
{
    public class UpdateSubEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateSubEmployeeCategoryCommand, SubEmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<SubEmployeeCategory> Handle(UpdateSubEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var subEmployeeCategory = await _appDbContext.SubEmployeeCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                               ?? throw new Exception("Sub Employee Category not found");

            subEmployeeCategory.NameEn = request.NameEn ?? subEmployeeCategory.NameEn;
            subEmployeeCategory.NameRu = request.NameRu ?? subEmployeeCategory.NameRu;
            subEmployeeCategory.NameUz = request.NameUz ?? subEmployeeCategory.NameUz;
            subEmployeeCategory.NameUzRu = request.NameUzRu ?? subEmployeeCategory.NameUzRu;
            subEmployeeCategory.EmployeeCategoryId = request.EmployeeCategoryId ?? subEmployeeCategory.EmployeeCategoryId;
            
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return subEmployeeCategory;
        }
    }
}
