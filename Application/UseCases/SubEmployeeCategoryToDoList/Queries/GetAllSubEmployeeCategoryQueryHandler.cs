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
    public class GetAllSubEmployeeCategoryQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllSubEmployeeCategoryQuery, List<SubEmployeeCategory>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<SubEmployeeCategory>> Handle(GetAllSubEmployeeCategoryQuery request, CancellationToken cancellationToken)
        {
            var subEmployeeCategories = await _appDbContext.SubEmployeeCategories.ToListAsync(cancellationToken);
            return subEmployeeCategories;
        }
    }
}
