using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.TasksAndFunctionsToDoList.Queries
{
    public class GetAllTaskOrFunctionQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllTaskOrFunctionQuery, List<TaskOrFunction>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<TaskOrFunction>> Handle(GetAllTaskOrFunctionQuery request, CancellationToken cancellationToken)
        {
            var taskOrFunctions = await _appDbContext.TasksAndFunctions.ToListAsync(cancellationToken);
            return taskOrFunctions;
        }
    }
}
