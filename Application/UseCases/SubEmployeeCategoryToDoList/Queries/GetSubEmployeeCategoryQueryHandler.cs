using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SubEmployeeCategoryToDoList.Queries
{
    public class GetSubEmployeeCategoryQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetSubEmployeeCategoryQuery, SubEmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<SubEmployeeCategory> Handle(GetSubEmployeeCategoryQuery request, CancellationToken cancellationToken)
        {
            var subEmployeeCategory = await _appDbContext.SubEmployeeCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                               ?? throw new Exception("Sub Employee Category not found");
            return subEmployeeCategory;
        }
    }
}
