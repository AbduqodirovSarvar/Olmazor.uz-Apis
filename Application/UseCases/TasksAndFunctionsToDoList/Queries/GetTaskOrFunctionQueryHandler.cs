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
    public class GetTaskOrFunctionQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetTaskOrFunctionQuery, TaskOrFunction>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<TaskOrFunction> Handle(GetTaskOrFunctionQuery request, CancellationToken cancellationToken)
        {
            var taskOrFunction = await _appDbContext.TasksAndFunctions.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                    ?? throw new Exception("Task or Function not found");
            return taskOrFunction;
        }
    }
}
